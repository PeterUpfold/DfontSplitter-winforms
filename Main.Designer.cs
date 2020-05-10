namespace DfontSplitter
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sourceGroup = new System.Windows.Forms.GroupBox();
            this.sourceInstructionsLabel = new System.Windows.Forms.Label();
            this.removeFileFromListButton = new System.Windows.Forms.Button();
            this.addFileToListButton = new System.Windows.Forms.Button();
            this.sourceList = new System.Windows.Forms.ListBox();
            this.lblProgDescription = new System.Windows.Forms.Label();
            this.destGroup = new System.Windows.Forms.GroupBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.destinationFolderText = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.destinationFolderSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.sourceFileSelector = new System.Windows.Forms.OpenFileDialog();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.moreInfoButton = new System.Windows.Forms.Button();
            this.fonduWorker = new System.ComponentModel.BackgroundWorker();
            this.optionsButton = new System.Windows.Forms.Button();
            this.updateCheckWorker = new System.ComponentModel.BackgroundWorker();
            this.sourceGroup.SuspendLayout();
            this.destGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceGroup
            // 
            this.sourceGroup.BackColor = System.Drawing.SystemColors.Control;
            this.sourceGroup.Controls.Add(this.sourceInstructionsLabel);
            this.sourceGroup.Controls.Add(this.removeFileFromListButton);
            this.sourceGroup.Controls.Add(this.addFileToListButton);
            this.sourceGroup.Controls.Add(this.sourceList);
            this.sourceGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sourceGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceGroup.Location = new System.Drawing.Point(27, 40);
            this.sourceGroup.Name = "sourceGroup";
            this.sourceGroup.Size = new System.Drawing.Size(539, 195);
            this.sourceGroup.TabIndex = 0;
            this.sourceGroup.TabStop = false;
            this.sourceGroup.Text = "Source Fonts";
            // 
            // sourceInstructionsLabel
            // 
            this.sourceInstructionsLabel.AutoSize = true;
            this.sourceInstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceInstructionsLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.sourceInstructionsLabel.Location = new System.Drawing.Point(11, 22);
            this.sourceInstructionsLabel.Name = "sourceInstructionsLabel";
            this.sourceInstructionsLabel.Size = new System.Drawing.Size(318, 13);
            this.sourceInstructionsLabel.TabIndex = 3;
            this.sourceInstructionsLabel.Text = "Click Add Files and browse for the .dfont files you want to convert.\r\n";
            // 
            // removeFileFromListButton
            // 
            this.removeFileFromListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFileFromListButton.Location = new System.Drawing.Point(93, 162);
            this.removeFileFromListButton.Name = "removeFileFromListButton";
            this.removeFileFromListButton.Size = new System.Drawing.Size(74, 19);
            this.removeFileFromListButton.TabIndex = 2;
            this.removeFileFromListButton.Text = "&Remove";
            this.removeFileFromListButton.UseVisualStyleBackColor = true;
            this.removeFileFromListButton.Click += new System.EventHandler(this.removeFileFromListButton_Click);
            // 
            // addFileToListButton
            // 
            this.addFileToListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFileToListButton.Location = new System.Drawing.Point(14, 161);
            this.addFileToListButton.Name = "addFileToListButton";
            this.addFileToListButton.Size = new System.Drawing.Size(75, 20);
            this.addFileToListButton.TabIndex = 1;
            this.addFileToListButton.Text = "&Add Files...";
            this.addFileToListButton.UseVisualStyleBackColor = true;
            this.addFileToListButton.Click += new System.EventHandler(this.addFileToListButton_Click);
            // 
            // sourceList
            // 
            this.sourceList.AllowDrop = true;
            this.sourceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceList.FormattingEnabled = true;
            this.sourceList.Location = new System.Drawing.Point(14, 36);
            this.sourceList.Name = "sourceList";
            this.sourceList.Size = new System.Drawing.Size(494, 121);
            this.sourceList.TabIndex = 0;
            this.sourceList.DragDrop += new System.Windows.Forms.DragEventHandler(this.sourceList_DragDrop);
            this.sourceList.DragEnter += new System.Windows.Forms.DragEventHandler(this.sourceList_DragEnter);
            // 
            // lblProgDescription
            // 
            this.lblProgDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgDescription.Location = new System.Drawing.Point(12, 9);
            this.lblProgDescription.Name = "lblProgDescription";
            this.lblProgDescription.Size = new System.Drawing.Size(555, 20);
            this.lblProgDescription.TabIndex = 1;
            this.lblProgDescription.Text = "DfontSplitter allows you to convert a Mac OS X .dfont font file into a TrueType (" +
                ".ttf) font file.";
            this.lblProgDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // destGroup
            // 
            this.destGroup.Controls.Add(this.browseButton);
            this.destGroup.Controls.Add(this.destinationFolderText);
            this.destGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destGroup.Location = new System.Drawing.Point(27, 255);
            this.destGroup.Name = "destGroup";
            this.destGroup.Size = new System.Drawing.Size(539, 69);
            this.destGroup.TabIndex = 2;
            this.destGroup.TabStop = false;
            this.destGroup.Text = "Destination Folder";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(372, 29);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(64, 20);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "&Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // destinationFolderText
            // 
            this.destinationFolderText.Location = new System.Drawing.Point(24, 29);
            this.destinationFolderText.Name = "destinationFolderText";
            this.destinationFolderText.Size = new System.Drawing.Size(343, 20);
            this.destinationFolderText.TabIndex = 0;
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(27, 344);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(117, 39);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "&Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // sourceFileSelector
            // 
            this.sourceFileSelector.FileName = "openFileDialog1";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(186, 353);
            this.progress.MarqueeAnimationSpeed = 7;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(277, 20);
            this.progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progress.TabIndex = 4;
            this.progress.UseWaitCursor = true;
            this.progress.Visible = false;
            // 
            // moreInfoButton
            // 
            this.moreInfoButton.Location = new System.Drawing.Point(500, 362);
            this.moreInfoButton.Name = "moreInfoButton";
            this.moreInfoButton.Size = new System.Drawing.Size(80, 23);
            this.moreInfoButton.TabIndex = 6;
            this.moreInfoButton.Text = "More Info...";
            this.moreInfoButton.UseVisualStyleBackColor = true;
            this.moreInfoButton.Click += new System.EventHandler(this.moreInfoButton_Click);
            // 
            // fonduWorker
            // 
            this.fonduWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.fonduWorker_DoWork);
            this.fonduWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.fonduWorker_RunWorkerCompleted);
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(500, 333);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(80, 23);
            this.optionsButton.TabIndex = 5;
            this.optionsButton.Text = "&Options...";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // updateCheckWorker
            // 
            this.updateCheckWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.updateCheckWorker_DoWork);
            this.updateCheckWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.updateCheckWorker_RunWorkerCompleted);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(592, 402);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.moreInfoButton);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.destGroup);
            this.Controls.Add(this.lblProgDescription);
            this.Controls.Add(this.sourceGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "DfontSplitter";
            this.Load += new System.EventHandler(this.Main_Load);
            this.sourceGroup.ResumeLayout(false);
            this.sourceGroup.PerformLayout();
            this.destGroup.ResumeLayout(false);
            this.destGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sourceGroup;
        private System.Windows.Forms.ListBox sourceList;
        private System.Windows.Forms.Label lblProgDescription;
        private System.Windows.Forms.Button addFileToListButton;
        private System.Windows.Forms.Button removeFileFromListButton;
        private System.Windows.Forms.Label sourceInstructionsLabel;
        private System.Windows.Forms.GroupBox destGroup;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox destinationFolderText;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.FolderBrowserDialog destinationFolderSelector;
        private System.Windows.Forms.OpenFileDialog sourceFileSelector;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button moreInfoButton;
        private System.ComponentModel.BackgroundWorker fonduWorker;
        private System.Windows.Forms.Button optionsButton;
        private System.ComponentModel.BackgroundWorker updateCheckWorker;
    }
}

