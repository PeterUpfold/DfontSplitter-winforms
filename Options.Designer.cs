namespace DfontSplitter
{
    partial class Options
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.autoUpdateGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkIntervalSpinBox = new System.Windows.Forms.NumericUpDown();
            this.checkNowButton = new System.Windows.Forms.Button();
            this.enableAutoUpdates = new System.Windows.Forms.CheckBox();
            this.showDestFolder = new System.Windows.Forms.CheckBox();
            this.generalGroup = new System.Windows.Forms.GroupBox();
            this.autoUpdateGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkIntervalSpinBox)).BeginInit();
            this.generalGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(352, 196);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(82, 25);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(440, 196);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 25);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // autoUpdateGroup
            // 
            this.autoUpdateGroup.Controls.Add(this.label2);
            this.autoUpdateGroup.Controls.Add(this.label1);
            this.autoUpdateGroup.Controls.Add(this.checkIntervalSpinBox);
            this.autoUpdateGroup.Controls.Add(this.checkNowButton);
            this.autoUpdateGroup.Controls.Add(this.enableAutoUpdates);
            this.autoUpdateGroup.Location = new System.Drawing.Point(27, 83);
            this.autoUpdateGroup.Name = "autoUpdateGroup";
            this.autoUpdateGroup.Size = new System.Drawing.Size(496, 97);
            this.autoUpdateGroup.TabIndex = 2;
            this.autoUpdateGroup.TabStop = false;
            this.autoUpdateGroup.Text = "Automatic Updates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Check every";
            // 
            // checkIntervalSpinBox
            // 
            this.checkIntervalSpinBox.Location = new System.Drawing.Point(127, 63);
            this.checkIntervalSpinBox.Name = "checkIntervalSpinBox";
            this.checkIntervalSpinBox.Size = new System.Drawing.Size(54, 20);
            this.checkIntervalSpinBox.TabIndex = 2;
            this.checkIntervalSpinBox.ValueChanged += new System.EventHandler(this.checkIntervalSpinBox_ValueChanged);
            // 
            // checkNowButton
            // 
            this.checkNowButton.Location = new System.Drawing.Point(389, 24);
            this.checkNowButton.Name = "checkNowButton";
            this.checkNowButton.Size = new System.Drawing.Size(86, 23);
            this.checkNowButton.TabIndex = 1;
            this.checkNowButton.Text = "Check &Now";
            this.checkNowButton.UseVisualStyleBackColor = true;
            this.checkNowButton.Click += new System.EventHandler(this.checkNowButton_Click);
            // 
            // enableAutoUpdates
            // 
            this.enableAutoUpdates.AutoSize = true;
            this.enableAutoUpdates.Location = new System.Drawing.Point(21, 28);
            this.enableAutoUpdates.Name = "enableAutoUpdates";
            this.enableAutoUpdates.Size = new System.Drawing.Size(177, 17);
            this.enableAutoUpdates.TabIndex = 0;
            this.enableAutoUpdates.Text = "Automatically check for &updates";
            this.enableAutoUpdates.UseVisualStyleBackColor = true;
            this.enableAutoUpdates.CheckedChanged += new System.EventHandler(this.enableAutoUpdates_CheckedChanged);
            // 
            // showDestFolder
            // 
            this.showDestFolder.AutoSize = true;
            this.showDestFolder.Location = new System.Drawing.Point(21, 19);
            this.showDestFolder.Name = "showDestFolder";
            this.showDestFolder.Size = new System.Drawing.Size(276, 17);
            this.showDestFolder.TabIndex = 3;
            this.showDestFolder.Text = "Show &destination folder when conversion is complete";
            this.showDestFolder.UseVisualStyleBackColor = true;
            // 
            // generalGroup
            // 
            this.generalGroup.Controls.Add(this.showDestFolder);
            this.generalGroup.Location = new System.Drawing.Point(27, 12);
            this.generalGroup.Name = "generalGroup";
            this.generalGroup.Size = new System.Drawing.Size(496, 49);
            this.generalGroup.TabIndex = 4;
            this.generalGroup.TabStop = false;
            this.generalGroup.Text = "General";
            // 
            // Options
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(535, 233);
            this.Controls.Add(this.generalGroup);
            this.Controls.Add(this.autoUpdateGroup);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowIcon = false;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.autoUpdateGroup.ResumeLayout(false);
            this.autoUpdateGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkIntervalSpinBox)).EndInit();
            this.generalGroup.ResumeLayout(false);
            this.generalGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox autoUpdateGroup;
        private System.Windows.Forms.Button checkNowButton;
        private System.Windows.Forms.CheckBox enableAutoUpdates;
        private System.Windows.Forms.CheckBox showDestFolder;
        private System.Windows.Forms.GroupBox generalGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown checkIntervalSpinBox;
    }
}