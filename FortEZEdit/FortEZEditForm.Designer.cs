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
            this.grpDoublePump = new System.Windows.Forms.GroupBox();
            this.lblPostSwitchDelay = new System.Windows.Forms.Label();
            this.numPostSwitchDelay = new System.Windows.Forms.NumericUpDown();
            this.numPostReloadDelay = new System.Windows.Forms.NumericUpDown();
            this.lblPostReloadDelay = new System.Windows.Forms.Label();
            this.lblPreReloadDelay = new System.Windows.Forms.Label();
            this.numPreReloadDelay = new System.Windows.Forms.NumericUpDown();
            this.btnDoublePump = new System.Windows.Forms.Button();
            this.lblDoublePump = new System.Windows.Forms.Label();
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
            this.btnFnKeyEdit = new System.Windows.Forms.Button();
            this.lblEditKey = new System.Windows.Forms.Label();
            this.lblPreSwitchDelay = new System.Windows.Forms.Label();
            this.numPreSwitchDelay = new System.Windows.Forms.NumericUpDown();
            this.lblAfterAll = new System.Windows.Forms.Label();
            this.numAfterAll = new System.Windows.Forms.NumericUpDown();
            this.lblMod2Delay = new System.Windows.Forms.Label();
            this.numMod2Delay = new System.Windows.Forms.NumericUpDown();
            this.centerPanel.SuspendLayout();
            this.grpDoublePump.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPostSwitchDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPostReloadDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreReloadDelay)).BeginInit();
            this.grpReset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResetPostClickDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResetPreClickDelay)).BeginInit();
            this.grpDnR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReleaseDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoldDelay)).BeginInit();
            this.grpFortniteKeys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPreSwitchDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAfterAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMod2Delay)).BeginInit();
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
            this.centerPanel.Controls.Add(this.grpDoublePump);
            this.centerPanel.Controls.Add(this.grpReset);
            this.centerPanel.Controls.Add(this.grpDnR);
            this.centerPanel.Controls.Add(this.grpFortniteKeys);
            this.centerPanel.Location = new System.Drawing.Point(-1, 42);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(332, 370);
            this.centerPanel.TabIndex = 3;
            // 
            // grpDoublePump
            // 
            this.grpDoublePump.Controls.Add(this.lblMod2Delay);
            this.grpDoublePump.Controls.Add(this.numMod2Delay);
            this.grpDoublePump.Controls.Add(this.lblAfterAll);
            this.grpDoublePump.Controls.Add(this.numAfterAll);
            this.grpDoublePump.Controls.Add(this.lblPreSwitchDelay);
            this.grpDoublePump.Controls.Add(this.numPreSwitchDelay);
            this.grpDoublePump.Controls.Add(this.lblPostSwitchDelay);
            this.grpDoublePump.Controls.Add(this.numPostSwitchDelay);
            this.grpDoublePump.Controls.Add(this.numPostReloadDelay);
            this.grpDoublePump.Controls.Add(this.lblPostReloadDelay);
            this.grpDoublePump.Controls.Add(this.lblPreReloadDelay);
            this.grpDoublePump.Controls.Add(this.numPreReloadDelay);
            this.grpDoublePump.Controls.Add(this.btnDoublePump);
            this.grpDoublePump.Controls.Add(this.lblDoublePump);
            this.grpDoublePump.Location = new System.Drawing.Point(3, 241);
            this.grpDoublePump.Name = "grpDoublePump";
            this.grpDoublePump.Size = new System.Drawing.Size(326, 125);
            this.grpDoublePump.TabIndex = 7;
            this.grpDoublePump.TabStop = false;
            this.grpDoublePump.Text = "Double pump";
            // 
            // lblPostSwitchDelay
            // 
            this.lblPostSwitchDelay.AutoSize = true;
            this.lblPostSwitchDelay.Location = new System.Drawing.Point(165, 75);
            this.lblPostSwitchDelay.Name = "lblPostSwitchDelay";
            this.lblPostSwitchDelay.Size = new System.Drawing.Size(92, 13);
            this.lblPostSwitchDelay.TabIndex = 7;
            this.lblPostSwitchDelay.Text = "Post-switch delay:";
            // 
            // numPostSwitchDelay
            // 
            this.numPostSwitchDelay.Location = new System.Drawing.Point(257, 73);
            this.numPostSwitchDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPostSwitchDelay.Name = "numPostSwitchDelay";
            this.numPostSwitchDelay.Size = new System.Drawing.Size(64, 20);
            this.numPostSwitchDelay.TabIndex = 6;
            this.numPostSwitchDelay.ValueChanged += new System.EventHandler(this.changeDelayEvent);
            // 
            // numPostReloadDelay
            // 
            this.numPostReloadDelay.Location = new System.Drawing.Point(257, 49);
            this.numPostReloadDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPostReloadDelay.Name = "numPostReloadDelay";
            this.numPostReloadDelay.Size = new System.Drawing.Size(64, 20);
            this.numPostReloadDelay.TabIndex = 5;
            this.numPostReloadDelay.ValueChanged += new System.EventHandler(this.changeDelayEvent);
            // 
            // lblPostReloadDelay
            // 
            this.lblPostReloadDelay.AutoSize = true;
            this.lblPostReloadDelay.Location = new System.Drawing.Point(165, 51);
            this.lblPostReloadDelay.Name = "lblPostReloadDelay";
            this.lblPostReloadDelay.Size = new System.Drawing.Size(91, 13);
            this.lblPostReloadDelay.TabIndex = 4;
            this.lblPostReloadDelay.Text = "Post-reload delay:";
            // 
            // lblPreReloadDelay
            // 
            this.lblPreReloadDelay.AutoSize = true;
            this.lblPreReloadDelay.Location = new System.Drawing.Point(10, 51);
            this.lblPreReloadDelay.Name = "lblPreReloadDelay";
            this.lblPreReloadDelay.Size = new System.Drawing.Size(86, 13);
            this.lblPreReloadDelay.TabIndex = 3;
            this.lblPreReloadDelay.Text = "Pre-reload delay:";
            // 
            // numPreReloadDelay
            // 
            this.numPreReloadDelay.Location = new System.Drawing.Point(97, 49);
            this.numPreReloadDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPreReloadDelay.Name = "numPreReloadDelay";
            this.numPreReloadDelay.Size = new System.Drawing.Size(64, 20);
            this.numPreReloadDelay.TabIndex = 2;
            this.numPreReloadDelay.ValueChanged += new System.EventHandler(this.changeDelayEvent);
            // 
            // btnDoublePump
            // 
            this.btnDoublePump.Location = new System.Drawing.Point(62, 20);
            this.btnDoublePump.Name = "btnDoublePump";
            this.btnDoublePump.Size = new System.Drawing.Size(81, 23);
            this.btnDoublePump.TabIndex = 1;
            this.btnDoublePump.UseVisualStyleBackColor = true;
            this.btnDoublePump.Click += new System.EventHandler(this.changeKeyEvent);
            // 
            // lblDoublePump
            // 
            this.lblDoublePump.AutoSize = true;
            this.lblDoublePump.Location = new System.Drawing.Point(10, 25);
            this.lblDoublePump.Name = "lblDoublePump";
            this.lblDoublePump.Size = new System.Drawing.Size(28, 13);
            this.lblDoublePump.TabIndex = 0;
            this.lblDoublePump.Text = "Key:";
            // 
            // grpReset
            // 
            this.grpReset.Controls.Add(this.numResetPostClickDelay);
            this.grpReset.Controls.Add(this.lblResetPostClickDelay);
            this.grpReset.Controls.Add(this.lblResetPreClickDelay);
            this.grpReset.Controls.Add(this.numResetPreClickDelay);
            this.grpReset.Controls.Add(this.btnKeyReset);
            this.grpReset.Controls.Add(this.lblKeyReset);
            this.grpReset.Location = new System.Drawing.Point(3, 153);
            this.grpReset.Name = "grpReset";
            this.grpReset.Size = new System.Drawing.Size(326, 82);
            this.grpReset.TabIndex = 6;
            this.grpReset.TabStop = false;
            this.grpReset.Text = "Reset Edit";
            // 
            // numResetPostClickDelay
            // 
            this.numResetPostClickDelay.Location = new System.Drawing.Point(257, 49);
            this.numResetPostClickDelay.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numResetPostClickDelay.Name = "numResetPostClickDelay";
            this.numResetPostClickDelay.Size = new System.Drawing.Size(64, 20);
            this.numResetPostClickDelay.TabIndex = 5;
            this.numResetPostClickDelay.ValueChanged += new System.EventHandler(this.changeDelayEvent);
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
            this.numResetPreClickDelay.Location = new System.Drawing.Point(97, 49);
            this.numResetPreClickDelay.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numResetPreClickDelay.Name = "numResetPreClickDelay";
            this.numResetPreClickDelay.Size = new System.Drawing.Size(64, 20);
            this.numResetPreClickDelay.TabIndex = 2;
            this.numResetPreClickDelay.ValueChanged += new System.EventHandler(this.changeDelayEvent);
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
            this.grpDnR.Controls.Add(this.numReleaseDelay);
            this.grpDnR.Controls.Add(this.lblReleaseDelay);
            this.grpDnR.Controls.Add(this.lblHoldDelay);
            this.grpDnR.Controls.Add(this.numHoldDelay);
            this.grpDnR.Controls.Add(this.btnKeyDnR);
            this.grpDnR.Controls.Add(this.lblKeyDnR);
            this.grpDnR.Location = new System.Drawing.Point(3, 65);
            this.grpDnR.Name = "grpDnR";
            this.grpDnR.Size = new System.Drawing.Size(326, 82);
            this.grpDnR.TabIndex = 1;
            this.grpDnR.TabStop = false;
            this.grpDnR.Text = "Drag-n-Release Edit";
            // 
            // numReleaseDelay
            // 
            this.numReleaseDelay.Location = new System.Drawing.Point(257, 49);
            this.numReleaseDelay.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numReleaseDelay.Name = "numReleaseDelay";
            this.numReleaseDelay.Size = new System.Drawing.Size(64, 20);
            this.numReleaseDelay.TabIndex = 5;
            this.numReleaseDelay.ValueChanged += new System.EventHandler(this.changeDelayEvent);
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
            this.numHoldDelay.Location = new System.Drawing.Point(97, 49);
            this.numHoldDelay.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numHoldDelay.Name = "numHoldDelay";
            this.numHoldDelay.Size = new System.Drawing.Size(64, 20);
            this.numHoldDelay.TabIndex = 2;
            this.numHoldDelay.ValueChanged += new System.EventHandler(this.changeDelayEvent);
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
            this.grpFortniteKeys.Controls.Add(this.btnFnKeyEdit);
            this.grpFortniteKeys.Controls.Add(this.lblEditKey);
            this.grpFortniteKeys.Location = new System.Drawing.Point(3, 3);
            this.grpFortniteKeys.Name = "grpFortniteKeys";
            this.grpFortniteKeys.Size = new System.Drawing.Size(326, 56);
            this.grpFortniteKeys.TabIndex = 0;
            this.grpFortniteKeys.TabStop = false;
            this.grpFortniteKeys.Text = "Fortnite Keys";
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
            this.lblEditKey.Size = new System.Drawing.Size(49, 13);
            this.lblEditKey.TabIndex = 0;
            this.lblEditKey.Text = "Edit Key:";
            // 
            // lblPreSwitchDelay
            // 
            this.lblPreSwitchDelay.AutoSize = true;
            this.lblPreSwitchDelay.Location = new System.Drawing.Point(10, 75);
            this.lblPreSwitchDelay.Name = "lblPreSwitchDelay";
            this.lblPreSwitchDelay.Size = new System.Drawing.Size(87, 13);
            this.lblPreSwitchDelay.TabIndex = 9;
            this.lblPreSwitchDelay.Text = "Pre-switch delay:";
            // 
            // numPreSwitchDelay
            // 
            this.numPreSwitchDelay.Location = new System.Drawing.Point(97, 73);
            this.numPreSwitchDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPreSwitchDelay.Name = "numPreSwitchDelay";
            this.numPreSwitchDelay.Size = new System.Drawing.Size(64, 20);
            this.numPreSwitchDelay.TabIndex = 8;
            this.numPreSwitchDelay.ValueChanged += new System.EventHandler(this.changeDelayEvent);
            // 
            // lblAfterAll
            // 
            this.lblAfterAll.AutoSize = true;
            this.lblAfterAll.Location = new System.Drawing.Point(10, 101);
            this.lblAfterAll.Name = "lblAfterAll";
            this.lblAfterAll.Size = new System.Drawing.Size(45, 13);
            this.lblAfterAll.TabIndex = 11;
            this.lblAfterAll.Text = "After all:";
            // 
            // numAfterAll
            // 
            this.numAfterAll.Location = new System.Drawing.Point(97, 99);
            this.numAfterAll.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAfterAll.Name = "numAfterAll";
            this.numAfterAll.Size = new System.Drawing.Size(64, 20);
            this.numAfterAll.TabIndex = 10;
            this.numAfterAll.ValueChanged += new System.EventHandler(this.changeDelayEvent);
            // 
            // lblMod2Delay
            // 
            this.lblMod2Delay.AutoSize = true;
            this.lblMod2Delay.Location = new System.Drawing.Point(165, 101);
            this.lblMod2Delay.Name = "lblMod2Delay";
            this.lblMod2Delay.Size = new System.Drawing.Size(68, 13);
            this.lblMod2Delay.TabIndex = 13;
            this.lblMod2Delay.Text = "Mod 2 delay:";
            // 
            // numMod2Delay
            // 
            this.numMod2Delay.Location = new System.Drawing.Point(257, 99);
            this.numMod2Delay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMod2Delay.Name = "numMod2Delay";
            this.numMod2Delay.Size = new System.Drawing.Size(64, 20);
            this.numMod2Delay.TabIndex = 12;
            this.numMod2Delay.ValueChanged += new System.EventHandler(this.changeDelayEvent);
            // 
            // FortEZEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 410);
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
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FortEZEditForm_KeyPress);
            this.centerPanel.ResumeLayout(false);
            this.grpDoublePump.ResumeLayout(false);
            this.grpDoublePump.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPostSwitchDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPostReloadDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreReloadDelay)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.numPreSwitchDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAfterAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMod2Delay)).EndInit();
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
        private System.Windows.Forms.GroupBox grpDoublePump;
        private System.Windows.Forms.NumericUpDown numPostReloadDelay;
        private System.Windows.Forms.Label lblPostReloadDelay;
        private System.Windows.Forms.Label lblPreReloadDelay;
        private System.Windows.Forms.NumericUpDown numPreReloadDelay;
        private System.Windows.Forms.Button btnDoublePump;
        private System.Windows.Forms.Label lblDoublePump;
        private System.Windows.Forms.Label lblPostSwitchDelay;
        private System.Windows.Forms.NumericUpDown numPostSwitchDelay;
        private System.Windows.Forms.Label lblPreSwitchDelay;
        private System.Windows.Forms.NumericUpDown numPreSwitchDelay;
        private System.Windows.Forms.Label lblAfterAll;
        private System.Windows.Forms.NumericUpDown numAfterAll;
        private System.Windows.Forms.Label lblMod2Delay;
        private System.Windows.Forms.NumericUpDown numMod2Delay;
    }
}

