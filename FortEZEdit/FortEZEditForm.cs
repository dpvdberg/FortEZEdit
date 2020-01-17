using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interceptor;

namespace FortEZEdit
{
    public partial class FortEZEditForm : Form
    {
        private static Dictionary<object, Action<object>> settingsSetterMap = new Dictionary<object, Action<object>>();

        public FortEZEditForm()
        {
            InitializeComponent();
        }

        private void FortEZEditForm_Load(object sender, EventArgs e)
        {
            if (!InterceptorFacade.Instance.IsDriverInstalled())
            {
                SetInterceptionStatusError("Driver not installed.");
                btnInstallInterception.Enabled = true;

                centerPanel.Enabled = false;
                return;
            }

            try
            {
                InterceptorFacade.Instance.Load();
            } catch (InterceptionException ex)
            {
                SetInterceptionStatusError(ex.Message);

                centerPanel.Enabled = false;
                return;
            }

            btnInstallInterception.Enabled = false;
            lblInterceptionStatus.Text = "Interception ready!";
            lblInterceptionStatus.ForeColor = Color.DarkGreen;

            LoadSettings();

            InterceptorFacade.Instance.addListener(new ButtonListener(this));
            InterceptorFacade.Instance.setBroadcasting(false);
        }

        private void LoadSettings()
        {
            this.Invoke(new Action(() =>
            {
                btnFnKeyEdit.Text = Properties.Settings.Default.FnKey_Edit.ToString();
                settingsSetterMap[btnFnKeyEdit] = (s) => { Properties.Settings.Default.FnKey_Edit = (Interceptor.Keys)s; };

                btnKeyDnR.Text = Properties.Settings.Default.Key_DnREdit.ToString();
                settingsSetterMap[btnKeyDnR] = (s) => { Properties.Settings.Default.Key_DnREdit = (Interceptor.Keys)s; };

                numHoldDelay.Value = Properties.Settings.Default.Delay_DnRClickStart;
                settingsSetterMap[numHoldDelay] = (s) => { Properties.Settings.Default.Delay_DnRClickStart = (int)s; };

                numReleaseDelay.Value = Properties.Settings.Default.Delay_DnrClickRelease;
                settingsSetterMap[numReleaseDelay] = (s) => { Properties.Settings.Default.Delay_DnrClickRelease = (int)s; };

                btnKeyReset.Text = Properties.Settings.Default.Key_Reset.ToString();
                settingsSetterMap[btnKeyReset] = (s) => { Properties.Settings.Default.Key_Reset = (Interceptor.Keys)s; };

                numResetPreClickDelay.Value = Properties.Settings.Default.Delay_ResetPreClick;
                settingsSetterMap[numResetPreClickDelay] = (s) => { Properties.Settings.Default.Delay_ResetPreClick = (int)s; };

                numResetPostClickDelay.Value = Properties.Settings.Default.Delay_ResetPostClick;
                settingsSetterMap[numResetPostClickDelay] = (s) => { Properties.Settings.Default.Delay_ResetPostClick = (int)s; };

                btnEditRampPlaceModifier.Text = Properties.Settings.Default.Key_EditRampPlaceModifier.ToString();
                settingsSetterMap[btnEditRampPlaceModifier] = (s) => { Properties.Settings.Default.Key_EditRampPlaceModifier = (Interceptor.Keys)s; };

                btnFnKeyRamp.Text = Properties.Settings.Default.FnKey_Ramp.ToString();
                settingsSetterMap[btnFnKeyRamp] = (s) => { Properties.Settings.Default.FnKey_Ramp = (Interceptor.Keys)s; };

                btnFnKeyCone.Text = Properties.Settings.Default.FnKey_Cone.ToString();
                settingsSetterMap[btnFnKeyCone] = (s) => { Properties.Settings.Default.FnKey_Cone = (Interceptor.Keys)s; };

                btnFnKeyFloor.Text = Properties.Settings.Default.FnKey_Floor.ToString();
                settingsSetterMap[btnFnKeyFloor] = (s) => { Properties.Settings.Default.FnKey_Floor = (Interceptor.Keys)s; };

                btnFnKeyWall.Text = Properties.Settings.Default.FnKey_Wall.ToString();
                settingsSetterMap[btnFnKeyWall] = (s) => { Properties.Settings.Default.FnKey_Wall = (Interceptor.Keys)s; };

                numEditRampPlaceReleaseDelay.Value = Properties.Settings.Default.Delay_ReleaseEditRampPlaceDelay;
                settingsSetterMap[numEditRampPlaceReleaseDelay] = (s) => { Properties.Settings.Default.Delay_ReleaseEditRampPlaceDelay = (int)s; };

                btnFnKeyShotgun.Text = Properties.Settings.Default.FnKey_Shotgun.ToString();
                settingsSetterMap[btnFnKeyShotgun] = (s) => { Properties.Settings.Default.FnKey_Shotgun = (Interceptor.Keys)s; };

                chkEditToConfirm.Checked = Properties.Settings.Default.Check_EditToConfirm;
                settingsSetterMap[chkEditToConfirm] = (s) => { Properties.Settings.Default.Check_EditToConfirm = (bool)s; };

                numMouseId.Value = Properties.Settings.Default.id_Mouse;
                settingsSetterMap[numMouseId] = (s) =>
                {
                    int value = (int)s;
                    Properties.Settings.Default.id_Mouse = value;
                    InterceptorFacade.Instance.SetMouseId(value);
                };
            }));
        }

        private void SetInterceptionStatusError(string message)
        {
            lblInterceptionStatus.Text = message;
            lblInterceptionStatus.ForeColor = Color.DarkRed;
        }

        private void btnInstallInterception_Click(object sender, EventArgs e)
        {
            try
            {
                InterceptorFacade.Instance.InstallInterception();
            }
            catch (InterceptionException ex)
            {
                MessageBox.Show(ex.Message,
                    "Interception installation error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Installation successful, you MUST restart your pc for changes to take effect!", "Interception installation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static Button changingKey = null;
        public class ButtonListener : InterceptionListener
        {
            private FortEZEditForm form;

            public ButtonListener(FortEZEditForm form)
            {
                this.form = form;
            }

            public override void OnKeyDown(Interceptor.Keys key)
            {
                if (changingKey != null)
                {
                    if (settingsSetterMap.ContainsKey(changingKey))
                    {
                        settingsSetterMap[changingKey].Invoke(key);
                        form.LoadSettings();
                    }
                    changingKey = null;

                    InterceptorFacade.Instance.setBroadcasting(false);
                }
            }
        }

        private void changeKeyEvent(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                changingKey = (Button) sender;
                changingKey.Text = "...";

                InterceptorFacade.Instance.setBroadcasting(true);
            }
        }

        private void FortEZEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void changeNumEvent(object sender, EventArgs e)
        {
            NumericUpDown changingUpDown = (NumericUpDown)sender;
            if (settingsSetterMap.ContainsKey(changingUpDown))
            {
                settingsSetterMap[changingUpDown].Invoke(Convert.ToInt32(changingUpDown.Value));
                LoadSettings();
            }
        }

        private void changeCheckEvent(object sender, EventArgs e)
        {
            CheckBox changingCheckBox = (CheckBox)sender;
            if (settingsSetterMap.ContainsKey(changingCheckBox))
            {
                settingsSetterMap[changingCheckBox].Invoke(changingCheckBox.Checked);
                LoadSettings();
            }
        }
    }
}
