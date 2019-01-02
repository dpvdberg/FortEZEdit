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
            this.btnInstallInterception = new System.Windows.Forms.Button();
            this.lblInterceptionStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.centerPanel = new System.Windows.Forms.Panel();
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
            this.grpReset = new System.Windows.Forms.GroupBox();
            this.numResetPostClickDelay = new System.Windows.Forms.NumericUpDown();
            this.lblResetPostClickDelay = new System.Windows.Forms.Label();
            this.lblResetPreClickDelay = new System.Windows.Forms.Label();
            this.numResetPreClickDelay = new System.Windows.Forms.NumericUpDown();
            this.btnKeyReset = new System.Windows.Forms.Button();
            this.lblKeyReset = new System.Windows.Forms.Label();
            this.centerPanel.SuspendLayout();
            this.grpDnR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReleaseDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoldDelay)).BeginInit();
            this.grpFortniteKeys.SuspendLayout();
            this.grpReset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResetPostClickDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResetPreClickDelay)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(508, 41);
            this.label1.TabIndex = 2;
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.grpReset);
            this.centerPanel.Controls.Add(this.grpDnR);
            this.centerPanel.Controls.Add(this.grpFortniteKeys);
            this.centerPanel.Location = new System.Drawing.Point(-1, 42);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(332, 240);
            this.centerPanel.TabIndex = 3;
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
            this.numReleaseDelay.Location = new System.Drawing.Point(255, 49);
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
            this.numHoldDelay.Location = new System.Drawing.Point(95, 49);
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
            this.numResetPostClickDelay.Location = new System.Drawing.Point(255, 49);
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
            this.numResetPreClickDelay.Location = new System.Drawing.Point(95, 49);
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
            // FortEZEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 283);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.lblInterceptionStatus);
            this.Controls.Add(this.btnInstallInterception);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FortEZEditForm";
            this.Text = "Fortnite EZ Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FortEZEditForm_FormClosing);
            this.Load += new System.EventHandler(this.FortEZEditForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FortEZEditForm_KeyPress);
            this.centerPanel.ResumeLayout(false);
            this.grpDnR.ResumeLayout(false);
            this.grpDnR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReleaseDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoldDelay)).EndInit();
            this.grpFortniteKeys.ResumeLayout(false);
            this.grpFortniteKeys.PerformLayout();
            this.grpReset.ResumeLayout(false);
            this.grpReset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResetPostClickDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResetPreClickDelay)).EndInit();
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
    }
}

