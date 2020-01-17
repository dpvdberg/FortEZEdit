using Interceptor;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace FortEZEdit
{
    public sealed class InterceptorFacade
    {
        private static readonly Lazy<InterceptorFacade> lazy = new Lazy<InterceptorFacade>(() => new InterceptorFacade());

        public static InterceptorFacade Instance { get { return lazy.Value; } }

        private readonly Input input;
        private readonly string interceptionInstallPath = "install-interception.exe";
        private readonly string interceptionInstallationSuccessNeedle = "successfully installed";
        private bool isBroadcastingKeys = true;
        private List<InterceptionListener> listeners = new List<InterceptionListener>();

        private InterceptorFacade()
        {
            input = new Input();
            input.setMouseId(Properties.Settings.Default.id_Mouse);
        }

        public void addListener(InterceptionListener listener)
        {
            listeners.Add(listener);
        }

        public void removeListener(InterceptionListener listener)
        {
            listeners.Remove(listener);
        }

        public void setBroadcasting(bool enable)
        {
            isBroadcastingKeys = enable;
        }

        public void Load()
        {
            input.KeyboardFilterMode = KeyboardFilterMode.All;
            try
            {
                input.Load();
            }
            catch (DllNotFoundException)
            {
                throw new InterceptionException("Interception dll not found.");
            }

            input.OnKeyPressed += Input_OnKeyPressed;

            System.Timers.Timer activeProcessTimer = new System.Timers.Timer();
            activeProcessTimer.Elapsed += ActiveProcessTimer_Elapsed;
            activeProcessTimer.Interval = 500;
            activeProcessTimer.Enabled = true;
            activeProcessTimer.Start();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        private string GetCaptionOfActiveWindow()
        {
            IntPtr handle = GetForegroundWindow();
            uint processId;
            GetWindowThreadProcessId(handle, out processId);

            return Process.GetProcessById((int)processId).ProcessName;
        }

        private bool isFortniteActive = false;
        private void ActiveProcessTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            isFortniteActive = GetCaptionOfActiveWindow().ToLower().Contains("fortnite");
        }

        private enum TUNNEL_TYPE
        {
            FORWARD_SIMPLE
        }

        private bool isTunneling = false;
        Thread tunnelThread;
        private void Tunnel(TUNNEL_TYPE type)
        {
            isTunneling = true;
            Properties.Settings defaultSettings = Properties.Settings.Default;

            TunnelSetup(type);

            input.SendKey(Keys.W, KeyState.Down);
            Thread.Sleep(100);
            bool isRightFirst = true;
            while(isTunneling)
            {
                input.SendKey(defaultSettings.FnKey_Floor);
                input.SendMouseEvent(MouseState.LeftDown);

                Thread.Sleep(300);

                // Look up slightly
                input.MoveMouseBy(0, -600, true);
                Thread.Sleep(100);

                // Look back down
                input.MoveMouseBy(0, 600, true);
                input.SendMouseEvent(MouseState.LeftUp);

                Thread.Sleep(440);

                Wall(isRightFirst, defaultSettings, true, true, MOUSE_TURN60);
                Wall(!isRightFirst, defaultSettings, true, true, MOUSE_TURN60);
                isRightFirst = !isRightFirst;
            }
            input.SendKey(Keys.W, KeyState.Up);
        }

        private void TunnelSetup(TUNNEL_TYPE type)
        {
            CenterScreen();
            if (type == TUNNEL_TYPE.FORWARD_SIMPLE)
            {
                // Look down slightly
                input.MoveMouseBy(0, 200, true);

                Properties.Settings defaultSettings = Properties.Settings.Default;

                Wall(true, defaultSettings);
                Wall(false, defaultSettings);

                input.SendKey(defaultSettings.FnKey_Floor);
                input.MoveMouseBy(0, -2000, true);
                input.SendMouseEvent(MouseState.LeftDown);
                Thread.Sleep(BUILD_WAIT);
                input.SendMouseEvent(MouseState.LeftUp);
                Thread.Sleep(MOUSE_MOVE_SLEEP);
                input.MoveMouseBy(0, 2000, true);


                Thread.Sleep(MOUSE_MOVE_SLEEP);
            }
        }

        private const int MAX_MOUSE_MOVE = 2500;
        private const int MOUSE_MOVE_SLEEP = 5;
        private const int MOUSE_TURN360 = 10600;
        private const int MOUSE_TURN90 = (int) (MOUSE_TURN360 / 4.0);
        private const int MOUSE_TURN180 = (int) (MOUSE_TURN360 / 2.0);
        private const int MOUSE_TURN45 = (int)(MOUSE_TURN90 / 2.0);
        private const int MOUSE_TURN60 = (int)(MOUSE_TURN360 * (60.0 / 360.0));
        private const int BUILD_WAIT = 55;

        private void Wall(bool right, Properties.Settings settings, bool reset = true, bool releaseMouse = true, int turn = MOUSE_TURN90)
        {
            input.MoveMouseBy(right ? turn : -turn, 0, true);
            Thread.Sleep(MOUSE_MOVE_SLEEP * 2);
            input.SendKey(settings.FnKey_Wall);
            input.SendMouseEvent(MouseState.LeftDown);
            Thread.Sleep(BUILD_WAIT);
            if (releaseMouse)
            {
                input.SendMouseEvent(MouseState.LeftUp);
                Thread.Sleep(MOUSE_MOVE_SLEEP * 2);
            }
            if (reset)
            {
                input.MoveMouseBy(right ? -turn : turn, 0, true);
                Thread.Sleep(MOUSE_MOVE_SLEEP);
            }
        }

        private void CenterScreen()
        {
            // Flush down
            input.MoveMouseBy(0, MAX_MOUSE_MOVE, true);
            Thread.Sleep(MOUSE_MOVE_SLEEP);
            input.MoveMouseBy(0, MAX_MOUSE_MOVE, true);
            Thread.Sleep(MOUSE_MOVE_SLEEP);
            input.MoveMouseBy(0, MAX_MOUSE_MOVE, true);
            Thread.Sleep(MOUSE_MOVE_SLEEP);

            // center camera
            input.MoveMouseBy(0, -2600, true);
            Thread.Sleep(MOUSE_MOVE_SLEEP);
        }
        
        private bool waitingForDnRUp;
        private bool paused;
        private bool isEditRampPlaceModifierDown;
        private bool triggeredEditRampPlace;
        private void Input_OnKeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (isBroadcastingKeys && e.State == KeyState.Down)
            {
                foreach (InterceptionListener listener in listeners)
                {
                    listener.OnKeyDown(e.Key);
                }
            }

            Properties.Settings defaultSettings = Properties.Settings.Default;
            if (defaultSettings.Key_Pause == e.Key && e.State == KeyState.Down)
            {
                paused = !paused;
            }

            if (paused || !isFortniteActive)
            {
                return;
            }

            if (!isTunneling && Keys.Tilde == e.Key && e.State == KeyState.Down)
            {
                tunnelThread = new Thread(() => Tunnel(TUNNEL_TYPE.FORWARD_SIMPLE));
                tunnelThread.Start();
            } else if (Keys.Tilde == e.Key && e.State == KeyState.Up)
            {
                isTunneling = false;
            }

            if (defaultSettings.Key_EditRampPlaceModifier == e.Key)
            {
                isEditRampPlaceModifierDown = e.State == KeyState.Down;
                if (isEditRampPlaceModifierDown && waitingForDnRUp)
                {
                    triggeredEditRampPlace = true;
                }
            }
            else if (defaultSettings.Key_DnREdit == e.Key)
            {
                if (e.State == KeyState.Down && !waitingForDnRUp)
                {
                    triggeredEditRampPlace = isEditRampPlaceModifierDown;
                    Task.Run(() =>
                    {
                        input.SendKey(defaultSettings.FnKey_Edit);
                        Thread.Sleep(defaultSettings.Delay_DnRClickStart);
                        input.SendMouseEvent(MouseState.LeftDown);
                    });
                    waitingForDnRUp = true;
                }
                else if (e.State == KeyState.Up)
                {
                    Task.Run(() =>
                    {
                        Thread.Sleep(defaultSettings.Delay_DnrClickRelease);
                        // Confirm the edit
                        if (defaultSettings.Check_EditToConfirm)
                        {
                            input.SendKey(defaultSettings.FnKey_Edit);
                        }
                        else
                        {
                            input.SendMouseEvent(MouseState.LeftUp);
                        }
                        // If ramp placement is triggered, build the ramp and select shotgun
                        if (triggeredEditRampPlace || isEditRampPlaceModifierDown)
                        {
                            if (!defaultSettings.Check_EditToConfirm)
                            {
                                input.SendMouseEvent(MouseState.LeftDown);
                            }
                            input.SendKey(defaultSettings.FnKey_Ramp);
                            Thread.Sleep(defaultSettings.Delay_ReleaseEditRampPlaceDelay);
                            input.SendKey(defaultSettings.FnKey_Shotgun);
                        }
                        // Release mouse
                        input.SendMouseEvent(MouseState.LeftUp);
                        triggeredEditRampPlace = false;
                    });
                    waitingForDnRUp = false;
                }
            }
            else if (defaultSettings.Key_Reset == e.Key && e.State == KeyState.Down)
            {
                Task.Run(() =>
                {
                    input.SendKey(defaultSettings.FnKey_Edit);
                    Thread.Sleep(defaultSettings.Delay_ResetPreClick);
                    input.SendRightClick();
                    Thread.Sleep(defaultSettings.Delay_ResetPostClick);
                    input.SendKey(defaultSettings.FnKey_Edit);
                });
            }
        }

        public bool IsDriverInstalled()
        {
            SelectQuery query = new SelectQuery("Win32_SystemDriver");
            query.Condition = "Name = 'keyboard'";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            var drivers = searcher.Get();

            return drivers.Count > 0;
        }

        public Input GetInput()
        {
            return input;
        }

        public void InstallInterception()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
                {
                    throw new InterceptionException("Program must be running as Administrator to install driver.");
                }
            }

            if (!File.Exists(interceptionInstallPath))
            {
                throw new InterceptionException($"Missing installation file '{interceptionInstallPath}'.");
            }

            // Start the installer
            Process p = new Process();

            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = interceptionInstallPath;
            p.StartInfo.Arguments = "/install";
            p.Start();
            
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            if (!output.Contains(interceptionInstallationSuccessNeedle))
            {
                throw new InterceptionException($"Could not determine whether installation was successful.\nOutput:\n\n {output}");
            }
        }

        public void SetMouseId(int id)
        {
            input.setMouseId(id);
        }
    }
}
