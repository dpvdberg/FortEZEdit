namespace FortEZEdit
{
    partial class FortEZEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FortEZEditForm));
            this.btnInstallInterception = new System.Windows.Forms.Button();
            this.lblInterceptionStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numEditRampPlaceReleaseDelay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditRampPlaceModifier = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numMouseId = new System.Windows.Forms.NumericUpDown();
            this.lblMouseId = new System.Windows.Forms.Label();
            this.grpReset = new System.Windows.Forms.GroupBox();
            this.numResetPostClickDelay = new System.Windows.Forms.NumericUpDown();
            this.lblResetPostClickDelay = new System.Windows.Forms.Label();
            this.lblResetPreClickDelay = new System.Windows.Forms.Label();
            this.numResetPreClickDelay = new System.Windows.Forms.NumericUpDown();
            this.btnKeyReset = new System.Windows.Forms.Button();
            this.lblKeyReset = new System.Windows.Forms.Label();
            this.grpDnR = new System.Windows.Forms.GroupBox();
            this.numReleaseDelay = new System.Windows.Forms.NumericUpDown();
            this.lblReleaseDelay = new System.Windows.Forms.Label();
            this.lblHoldDelay = new System.Windows.Forms.Label();
            this.numHoldDelay = new System.Windows.Forms.NumericUpDown();
            this.btnKeyDnR = new System.Windows.Forms.Button();
            this.lblKeyDnR = new System.Windows.Forms.Label();
            this.grpFortniteKeys = new System.Windows.Forms.GroupBox();
            this.btnFnKeyShotgun = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFnKeyRamp = new System.Windows.Forms.Button();
            this.btnFnKeyEdit = new System.Windows.Forms.Button();
            this.lblEditKey = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkEditToConfirm = new System.Windows.Forms.CheckBox();
            this.centerPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditRampPlaceReleaseDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseId)).BeginInit();
            this.grpReset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResetPostClickDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResetPreClickDelay)).BeginInit();
            this.grpDnR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReleaseDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoldDelay)).BeginInit();
            this.grpFortniteKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInstallInterception
            // 
            this.btnInstallInterception.Enabled = false;
            this.btnInstallInterception.Location = new System.Drawing.Point(12, 8);
            this.btnInstallInterception.Name = "btnInstallInterception";
            this.btnInstallInterception.Size = new System.Drawing.Size(116, 23);
            this.btnInstallInterception.TabIndex = 0;
            this.btnInstallInterception.Text = "Install Interception";
            this.btnInstallInterception.UseVisualStyleBackColor = true;
            this.btnInstallInterception.Click += new System.EventHandler(this.btnInstallInterception_Click);
            // 
            // lblInterceptionStatus
            // 
            this.lblInterceptionStatus.AutoSize = true;
            this.lblInterceptionStatus.Location = new System.Drawing.Point(134, 13);
            this.lblInterceptionStatus.Name = "lblInterceptionStatus";
            this.lblInterceptionStatus.Size = new System.Drawing.Size(81, 13);
            this.lblInterceptionStatus.TabIndex = 1;
            this.lblInterceptionStatus.Text = "Getting status...";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 41);
            this.label1.TabIndex = 2;
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.groupBox1);
            this.centerPanel.Controls.Add(this.numMouseId);
            this.centerPanel.Controls.Add(this.lblMouseId);
            this.centerPanel.Controls.Add(this.grpReset);
            this.centerPanel.Controls.Add(this.grpDnR);
            this.centerPanel.Controls.Add(this.grpFortniteKeys);
            this.centerPanel.Location = new System.Drawing.Point(-1, 42);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(332, 375);
            this.centerPanel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numEditRampPlaceReleaseDelay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnEditRampPlaceModifier);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(3, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 58);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit ramp place";
            // 
            // numEditRampPlaceReleaseDelay
            // 
            this.numEditRampPlaceReleaseDelay.Location = new System.Drawing.Point(255, 23);
            this.numEditRampPlaceReleaseDelay.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numEditRampPlaceReleaseDelay.Name = "numEditRampPlaceReleaseDelay";
            this.numEditRampPlaceReleaseDelay.Size = new System.Drawing.Size(64, 20);
            this.numEditRampPlaceReleaseDelay.TabIndex = 7;
            this.numEditRampPlaceReleaseDelay.ValueChanged += new System.EventHandler(this.changeNumEvent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Release delay:";
            // 
            // btnEditRampPlaceModifier
            // 
            this.btnEditRampPlaceModifier.Location = new System.Drawing.Point(83, 20);
            this.btnEditRampPlaceModifier.Name = "btnEditRampPlaceModifier";
            this.btnEditRampPlaceModifier.Size = new System.Drawing.Size(76, 23);
            this.btnEditRampPlaceModifier.TabIndex = 1;
            this.btnEditRampPlaceModifier.UseVisualStyleBackColor = true;
            this.btnEditRampPlaceModifier.Click += new System.EventHandler(this.changeKeyEvent);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Edit modifier:";
            // 
            // numMouseId
            // 
            this.numMouseId.Location = new System.Drawing.Point(65, 10);
            this.numMouseId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMouseId.Name = "numMouseId";
            this.numMouseId.Size = new System.Drawing.Size(81, 20);
            this.numMouseId.TabIndex = 8;
            this.numMouseId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMouseId.ValueChanged += new System.EventHandler(this.changeNumEvent);
            // 
            // lblMouseId
            // 
            this.lblMouseId.AutoSize = true;
            this.lblMouseId.Location = new System.Drawing.Point(10, 12);
            this.lblMouseId.Name = "lblMouseId";
            this.lblMouseId.Size = new System.Drawing.Size(56, 13);
            this.lblMouseId.TabIndex = 7;
            this.lblMouseId.Text = "Mouse ID:";
            // 
            // grpReset
            // 
            this.grpReset.Controls.Add(this.numResetPostClickDelay);
            this.grpReset.Controls.Add(this.lblResetPostClickDelay);
            this.grpReset.Controls.Add(this.lblResetPreClickDelay);
            this.grpReset.Controls.Add(this.numResetPreClickDelay);
            this.grpReset.Controls.Add(this.btnKeyReset);
            this.grpReset.Controls.Add(this.lblKeyReset);
            this.grpReset.Location = new System.Drawing.Point(3, 225);
            this.grpReset.Name = "grpReset";
            this.grpReset.Size = new System.Drawing.Size(326, 82);
            this.grpReset.TabIndex = 6;
            this.grpReset.TabStop = false;
            this.grpReset.Text = "Reset Edit";
            // 
            // numResetPostClickDelay
            // 
            this.numResetPostClickDelay.Location = new System.Drawing.Point(255, 49);
            this.numResetPostClickDelay.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numResetPostClickDelay.Name = "numResetPostClickDelay";
            this.numResetPostClickDelay.Size = new System.Drawing.Size(64, 20);
            this.numResetPostClickDelay.TabIndex = 5;
            this.numResetPostClickDelay.ValueChanged += new System.EventHandler(this.changeNumEvent);
            // 
            // lblResetPostClickDelay
            // 
            this.lblResetPostClickDelay.AutoSize = true;
            this.lblResetPostClickDelay.Location = new System.Drawing.Point(165, 51);
            this.lblResetPostClickDelay.Name = "lblResetPostClickDelay";
            this.lblResetPostClickDelay.Size = new System.Drawing.Size(84, 13);
            this.lblResetPostClickDelay.TabIndex = 4;
            this.lblResetPostClickDelay.Text = "Post-click delay:";
            // 
            // lblResetPreClickDelay
            // 
            this.lblResetPreClickDelay.AutoSize = true;
            this.lblResetPreClickDelay.Location = new System.Drawing.Point(10, 51);
            this.lblResetPreClickDelay.Name = "lblResetPreClickDelay";
            this.lblResetPreClickDelay.Size = new System.Drawing.Size(79, 13);
            this.lblResetPreClickDelay.TabIndex = 3;
            this.lblResetPreClickDelay.Text = "Pre-click delay:";
            // 
            // numResetPreClickDelay
            // 
            this.numResetPreClickDelay.Location = new System.Drawing.Point(95, 49);
            this.numResetPreClickDelay.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numResetPreClickDelay.Name = "numResetPreClickDelay";
            this.numResetPreClickDelay.Size = new System.Drawing.Size(64, 20);
            this.numResetPreClickDelay.TabIndex = 2;
            this.numResetPreClickDelay.ValueChanged += new System.EventHandler(this.changeNumEvent);
            // 
            // btnKeyReset
            // 
            this.btnKeyReset.Location = new System.Drawing.Point(62, 20);
            this.btnKeyReset.Name = "btnKeyReset";
            this.btnKeyReset.Size = new System.Drawing.Size(81, 23);
            this.btnKeyReset.TabIndex = 1;
            this.btnKeyReset.UseVisualStyleBackColor = true;
            this.btnKeyReset.Click += new System.EventHandler(this.changeKeyEvent);
            // 
            // lblKeyReset
            // 
            this.lblKeyReset.AutoSize = true;
            this.lblKeyReset.Location = new System.Drawing.Point(10, 25);
            this.lblKeyReset.Name = "lblKeyReset";
            this.lblKeyReset.Size = new System.Drawing.Size(28, 13);
            this.lblKeyReset.TabIndex = 0;
            this.lblKeyReset.Text = "Key:";
            // 
            // grpDnR
            // 
            this.grpDnR.Controls.Add(this.chkEditToConfirm);
            this.grpDnR.Controls.Add(this.numReleaseDelay);
            this.grpDnR.Controls.Add(this.lblReleaseDelay);
            this.grpDnR.Controls.Add(this.lblHoldDelay);
            this.grpDnR.Controls.Add(this.numHoldDelay);
            this.grpDnR.Controls.Add(this.btnKeyDnR);
            this.grpDnR.Controls.Add(this.lblKeyDnR);
            this.grpDnR.Location = new System.Drawing.Point(3, 137);
            this.grpDnR.Name = "grpDnR";
            this.grpDnR.Size = new System.Drawing.Size(326, 82);
            this.grpDnR.TabIndex = 1;
            this.grpDnR.TabStop = false;
            this.grpDnR.Text = "Drag-n-Release Edit";
            // 
            // numReleaseDelay
            // 
            this.numReleaseDelay.Location = new System.Drawing.Point(255, 49);
            this.numReleaseDelay.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numReleaseDelay.Name = "numReleaseDelay";
            this.numReleaseDelay.Size = new System.Drawing.Size(64, 20);
            this.numReleaseDelay.TabIndex = 5;
            this.numReleaseDelay.ValueChanged += new System.EventHandler(this.changeNumEvent);
            // 
            // lblReleaseDelay
            // 
            this.lblReleaseDelay.AutoSize = true;
            this.lblReleaseDelay.Location = new System.Drawing.Point(165, 51);
            this.lblReleaseDelay.Name = "lblReleaseDelay";
            this.lblReleaseDelay.Size = new System.Drawing.Size(77, 13);
            this.lblReleaseDelay.TabIndex = 4;
            this.lblReleaseDelay.Text = "Release delay:";
            // 
            // lblHoldDelay
            // 
            this.lblHoldDelay.AutoSize = true;
            this.lblHoldDelay.Location = new System.Drawing.Point(10, 51);
            this.lblHoldDelay.Name = "lblHoldDelay";
            this.lblHoldDelay.Size = new System.Drawing.Size(60, 13);
            this.lblHoldDelay.TabIndex = 3;
            this.lblHoldDelay.Text = "Hold delay:";
            // 
            // numHoldDelay
            // 
            this.numHoldDelay.Location = new System.Drawing.Point(95, 49);
            this.numHoldDelay.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numHoldDelay.Name = "numHoldDelay";
            this.numHoldDelay.Size = new System.Drawing.Size(64, 20);
            this.numHoldDelay.TabIndex = 2;
            this.numHoldDelay.ValueChanged += new System.EventHandler(this.changeNumEvent);
            // 
            // btnKeyDnR
            // 
            this.btnKeyDnR.Location = new System.Drawing.Point(62, 20);
            this.btnKeyDnR.Name = "btnKeyDnR";
            this.btnKeyDnR.Size = new System.Drawing.Size(81, 23);
            this.btnKeyDnR.TabIndex = 1;
            this.btnKeyDnR.UseVisualStyleBackColor = true;
            this.btnKeyDnR.Click += new System.EventHandler(this.changeKeyEvent);
            // 
            // lblKeyDnR
            // 
            this.lblKeyDnR.AutoSize = true;
            this.lblKeyDnR.Location = new System.Drawing.Point(10, 25);
            this.lblKeyDnR.Name = "lblKeyDnR";
            this.lblKeyDnR.Size = new System.Drawing.Size(28, 13);
            this.lblKeyDnR.TabIndex = 0;
            this.lblKeyDnR.Text = "Key:";
            // 
            // grpFortniteKeys
            // 
            this.grpFortniteKeys.Controls.Add(this.btnFnKeyShotgun);
            this.grpFortniteKeys.Controls.Add(this.label5);
            this.grpFortniteKeys.Controls.Add(this.btnFnKeyRamp);
            this.grpFortniteKeys.Controls.Add(this.btnFnKeyEdit);
            this.grpFortniteKeys.Controls.Add(this.lblEditKey);
            this.grpFortniteKeys.Controls.Add(this.label2);
            this.grpFortniteKeys.Location = new System.Drawing.Point(3, 36);
            this.grpFortniteKeys.Name = "grpFortniteKeys";
            this.grpFortniteKeys.Size = new System.Drawing.Size(326, 95);
            this.grpFortniteKeys.TabIndex = 0;
            this.grpFortniteKeys.TabStop = false;
            this.grpFortniteKeys.Text = "Fortnite Keys";
            // 
            // btnFnKeyShotgun
            // 
            this.btnFnKeyShotgun.Location = new System.Drawing.Point(78, 57);
            this.btnFnKeyShotgun.Name = "btnFnKeyShotgun";
            this.btnFnKeyShotgun.Size = new System.Drawing.Size(81, 23);
            this.btnFnKeyShotgun.TabIndex = 3;
            this.btnFnKeyShotgun.UseVisualStyleBackColor = true;
            this.btnFnKeyShotgun.Click += new System.EventHandler(this.changeKeyEvent);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Shotgun key:";
            // 
            // btnFnKeyRamp
            // 
            this.btnFnKeyRamp.Location = new System.Drawing.Point(219, 19);
            this.btnFnKeyRamp.Name = "btnFnKeyRamp";
            this.btnFnKeyRamp.Size = new System.Drawing.Size(76, 23);
            this.btnFnKeyRamp.TabIndex = 1;
            this.btnFnKeyRamp.UseVisualStyleBackColor = true;
            this.btnFnKeyRamp.Click += new System.EventHandler(this.changeKeyEvent);
            // 
            // btnFnKeyEdit
            // 
            this.btnFnKeyEdit.Location = new System.Drawing.Point(62, 19);
            this.btnFnKeyEdit.Name = "btnFnKeyEdit";
            this.btnFnKeyEdit.Size = new System.Drawing.Size(81, 23);
            this.btnFnKeyEdit.TabIndex = 1;
            this.btnFnKeyEdit.UseVisualStyleBackColor = true;
            this.btnFnKeyEdit.Click += new System.EventHandler(this.changeKeyEvent);
            // 
            // lblEditKey
            // 
            this.lblEditKey.AutoSize = true;
            this.lblEditKey.Location = new System.Drawing.Point(6, 24);
            this.lblEditKey.Name = "lblEditKey";
            this.lblEditKey.Size = new System.Drawing.Size(48, 13);
            this.lblEditKey.TabIndex = 0;
            this.lblEditKey.Text = "Edit key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ramp key:";
            // 
            // chkEditToConfirm
            // 
            this.chkEditToConfirm.AutoSize = true;
            this.chkEditToConfirm.Location = new System.Drawing.Point(168, 24);
            this.chkEditToConfirm.Name = "chkEditToConfirm";
            this.chkEditToConfirm.Size = new System.Drawing.Size(121, 17);
            this.chkEditToConfirm.TabIndex = 6;
            this.chkEditToConfirm.Text = "Press edit to confirm";
            this.chkEditToConfirm.UseVisualStyleBackColor = true;
            this.chkEditToConfirm.CheckedChanged += new System.EventHandler(this.changeCheckEvent);
            // 
            // FortEZEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 420);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.lblInterceptionStatus);
            this.Controls.Add(this.btnInstallInterception);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FortEZEditForm";
            this.Text = "Fortnite EZ Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FortEZEditForm_FormClosing);
            this.Load += new System.EventHandler(this.FortEZEditForm_Load);
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditRampPlaceReleaseDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseId)).EndInit();
            this.grpReset.ResumeLayout(false);
            this.grpReset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResetPostClickDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResetPreClickDelay)).EndInit();
            this.grpDnR.ResumeLayout(false);
            this.grpDnR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReleaseDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoldDelay)).EndInit();
            this.grpFortniteKeys.ResumeLayout(false);
            this.grpFortniteKeys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstallInterception;
        private System.Windows.Forms.Label lblInterceptionStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.GroupBox grpFortniteKeys;
        private System.Windows.Forms.Button btnFnKeyEdit;
        private System.Windows.Forms.Label lblEditKey;
        private System.Windows.Forms.GroupBox grpDnR;
        private System.Windows.Forms.Button btnKeyDnR;
        private System.Windows.Forms.Label lblKeyDnR;
        private System.Windows.Forms.Label lblHoldDelay;
        private System.Windows.Forms.NumericUpDown numHoldDelay;
        private System.Windows.Forms.Label lblReleaseDelay;
        private System.Windows.Forms.NumericUpDown numReleaseDelay;
        private System.Windows.Forms.GroupBox grpReset;
        private System.Windows.Forms.NumericUpDown numResetPostClickDelay;
        private System.Windows.Forms.Label lblResetPostClickDelay;
        private System.Windows.Forms.Label lblResetPreClickDelay;
        private System.Windows.Forms.NumericUpDown numResetPreClickDelay;
        private System.Windows.Forms.Button btnKeyReset;
        private System.Windows.Forms.Label lblKeyReset;
        private System.Windows.Forms.NumericUpDown numMouseId;
        private System.Windows.Forms.Label lblMouseId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFnKeyRamp;
        private System.Windows.Forms.Button btnEditRampPlaceModifier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numEditRampPlaceReleaseDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFnKeyShotgun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkEditToConfirm;
    }
}

