namespace DfontSplitter
{
    partial class UpdateInformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.remindButton = new System.Windows.Forms.Button();
            this.continueAutoUpdating = new System.Windows.Forms.CheckBox();
            this.releaseNotesPane = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A new version of DfontSplitter is available. Would you like to download it now?";
            // 
            // downloadButton
            // 
            this.downloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadButton.AutoSize = true;
            this.downloadButton.Location = new System.Drawing.Point(386, 302);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(110, 28);
            this.downloadButton.TabIndex = 3;
            this.downloadButton.Text = "&Download...";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // remindButton
            // 
            this.remindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remindButton.AutoSize = true;
            this.remindButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.remindButton.Location = new System.Drawing.Point(513, 302);
            this.remindButton.Name = "remindButton";
            this.remindButton.Size = new System.Drawing.Size(109, 28);
            this.remindButton.TabIndex = 4;
            this.remindButton.Text = "Remind Me &Later";
            this.remindButton.UseVisualStyleBackColor = true;
            // 
            // continueAutoUpdating
            // 
            this.continueAutoUpdating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.continueAutoUpdating.AutoSize = true;
            this.continueAutoUpdating.Location = new System.Drawing.Point(15, 309);
            this.continueAutoUpdating.Name = "continueAutoUpdating";
            this.continueAutoUpdating.Size = new System.Drawing.Size(236, 17);
            this.continueAutoUpdating.TabIndex = 2;
            this.continueAutoUpdating.Text = "Check for updates automatically in the &future";
            this.continueAutoUpdating.UseVisualStyleBackColor = true;
            this.continueAutoUpdating.CheckedChanged += new System.EventHandler(this.continueAutoUpdating_CheckedChanged);
            // 
            // releaseNotesPane
            // 
            this.releaseNotesPane.Location = new System.Drawing.Point(15, 42);
            this.releaseNotesPane.MinimumSize = new System.Drawing.Size(20, 20);
            this.releaseNotesPane.Name = "releaseNotesPane";
            this.releaseNotesPane.Size = new System.Drawing.Size(607, 238);
            this.releaseNotesPane.TabIndex = 1;
            // 
            // UpdateInformation
            // 
            this.AcceptButton = this.downloadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.remindButton;
            this.ClientSize = new System.Drawing.Size(634, 342);
            this.Controls.Add(this.releaseNotesPane);
            this.Controls.Add(this.continueAutoUpdating);
            this.Controls.Add(this.remindButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateInformation";
            this.ShowIcon = false;
            this.Text = "Software Update Available";
            this.Load += new System.EventHandler(this.UpdateInformation_Load);
            this.Shown += new System.EventHandler(this.UpdateInformation_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateInformation_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button remindButton;
        private System.Windows.Forms.CheckBox continueAutoUpdating;
        private System.Windows.Forms.WebBrowser releaseNotesPane;
    }
}