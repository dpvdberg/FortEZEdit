using Interceptor;
using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace FortEZEdit
{
    public sealed class InterceptorFacade
    {
        private static readonly Lazy<InterceptorFacade> lazy = new Lazy<InterceptorFacade>(() => new InterceptorFacade());

        public static InterceptorFacade Instance { get { return lazy.Value; } }

        private readonly Input input;
        private readonly string interceptionInstallPath = "install-interception.exe";
        private readonly string interceptionInstallationSuccessNeedle = "successfully installed";

        private InterceptorFacade()
        {
            input = new Input();
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
        }

        private bool waitingForDnRUp;
        private bool isDnRDown;
        private void Input_OnKeyPressed(object sender, KeyPressedEventArgs e)
        {
            Properties.Settings defaultSettings = Properties.Settings.Default;
            if (ConvertToInterceptorKey(defaultSettings.Key_DnREdit) == e.Key)
            {
                if (e.State == KeyState.Down && !waitingForDnRUp && !isDnRDown)
                {
                    Task.Run(() =>
                    {
                        input.SendKey(ConvertToInterceptorKey(defaultSettings.FnKey_Edit));
                        Thread.Sleep(defaultSettings.Delay_DnRClickStart);
                        input.SendMouseEvent(MouseState.LeftDown);
                        isDnRDown = true;
                    });
                    waitingForDnRUp = true;
                } else if (e.State == KeyState.Up)
                {
                    Task.Run(() =>
                    {
                        while (!isDnRDown)
                        {
                            // Spin wait
                        }
                        Thread.Sleep(defaultSettings.Delay_DnrClickRelease);
                        input.SendKey(ConvertToInterceptorKey(defaultSettings.FnKey_Edit));
                        input.SendMouseEvent(MouseState.LeftUp);
                        isDnRDown = false;
                    });
                    waitingForDnRUp = false;
                }
            } else if (ConvertToInterceptorKey(defaultSettings.Key_Reset) == e.Key && e.State == KeyState.Down)
            {
                Task.Run(() =>
                {
                    input.SendKey(ConvertToInterceptorKey(defaultSettings.FnKey_Edit));
                    Thread.Sleep(defaultSettings.Delay_ResetPreClick);
                    input.SendRightClick();
                    Thread.Sleep(defaultSettings.Delay_ResetPostClick);
                    input.SendKey(ConvertToInterceptorKey(defaultSettings.FnKey_Edit));
                });
            }
        }

        public Keys ConvertToInterceptorKey(string key)
        {
            Keys outKey;
            Enum.TryParse(key, out outKey);

            return outKey;
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
    }
}
