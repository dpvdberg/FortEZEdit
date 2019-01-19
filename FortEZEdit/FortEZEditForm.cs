using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortEZEdit
{
    public partial class FortEZEditForm : Form
    {
        private Dictionary<object, Action<object>> settingsSetterMap = new Dictionary<object, Action<object>>();

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
        }

        private void LoadSettings()
        {
            btnFnKeyEdit.Text = Properties.Settings.Default.FnKey_Edit;
            settingsSetterMap[btnFnKeyEdit] = (s) => { Properties.Settings.Default.FnKey_Edit = (string) s; };

            btnKeyDnR.Text = Properties.Settings.Default.Key_DnREdit;
            settingsSetterMap[btnKeyDnR] = (s) => { Properties.Settings.Default.Key_DnREdit = (string) s; };

            btnDoublePump.Text = Properties.Settings.Default.Key_DoublePump;
            settingsSetterMap[btnDoublePump] = (s) => { Properties.Settings.Default.Key_DoublePump = (string)s; };

            numHoldDelay.Value = Properties.Settings.Default.Delay_DnRClickStart;
            settingsSetterMap[numHoldDelay] = (s) => { Properties.Settings.Default.Delay_DnRClickStart = (int) s; };

            numReleaseDelay.Value = Properties.Settings.Default.Delay_DnrClickRelease;
            settingsSetterMap[numReleaseDelay] = (s) => { Properties.Settings.Default.Delay_DnrClickRelease = (int) s; };
            
            btnKeyReset.Text = Properties.Settings.Default.Key_Reset;
            settingsSetterMap[btnKeyReset] = (s) => { Properties.Settings.Default.Key_Reset = (string)s; };

            numResetPreClickDelay.Value = Properties.Settings.Default.Delay_ResetPreClick;
            settingsSetterMap[numResetPreClickDelay] = (s) => { Properties.Settings.Default.Delay_ResetPreClick = (int)s; };

            numResetPostClickDelay.Value = Properties.Settings.Default.Delay_ResetPostClick;
            settingsSetterMap[numResetPostClickDelay] = (s) => { Properties.Settings.Default.Delay_ResetPostClick = (int)s; };

            numPreReloadDelay.Value = Properties.Settings.Default.Delay_DPPreReload;
            settingsSetterMap[numPreReloadDelay] = (s) => { Properties.Settings.Default.Delay_DPPreReload = (int)s; };

            numPostReloadDelay.Value = Properties.Settings.Default.Delay_DPPostReload;
            settingsSetterMap[numPostReloadDelay] = (s) => { Properties.Settings.Default.Delay_DPPostReload = (int)s; };

            numPreSwitchDelay.Value = Properties.Settings.Default.Delay_DPPreSwitch;
            settingsSetterMap[numPreSwitchDelay] = (s) => { Properties.Settings.Default.Delay_DPPreSwitch = (int)s; };

            numPostSwitchDelay.Value = Properties.Settings.Default.Delay_DPPostSwitch;
            settingsSetterMap[numPostSwitchDelay] = (s) => { Properties.Settings.Default.Delay_DPPostSwitch = (int)s; };

            numAfterAll.Value = Properties.Settings.Default.Delay_DPAfter;
            settingsSetterMap[numAfterAll] = (s) => { Properties.Settings.Default.Delay_DPAfter = (int)s; };

            numMod2Delay.Value = Properties.Settings.Default.Delay_DPMod2Delay;
            settingsSetterMap[numMod2Delay] = (s) => { Properties.Settings.Default.Delay_DPMod2Delay = (int)s; };

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

        private void changeKeyEvent(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                changingKey = (Button) sender;
                changingKey.Text = "...";
            }
        }

        Button changingKey = null;
        private void FortEZEditForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (changingKey != null)
            {
                if (settingsSetterMap.ContainsKey(changingKey))
                {
                    settingsSetterMap[changingKey].Invoke(e.KeyChar.ToString().ToUpper());
                    LoadSettings();
                }
                changingKey = null;
            }
        }

        private void FortEZEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void changeDelayEvent(object sender, EventArgs e)
        {
            NumericUpDown changingUpDown = (NumericUpDown)sender;
            Console.WriteLine(Convert.ToInt32(changingUpDown.Value));
            if (settingsSetterMap.ContainsKey(changingUpDown))
            {
                settingsSetterMap[changingUpDown].Invoke(Convert.ToInt32(changingUpDown.Value));
                LoadSettings();
            }
            changingUpDown = null;
        }
    }
}
