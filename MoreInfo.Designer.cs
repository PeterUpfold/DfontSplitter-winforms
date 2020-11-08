namespace DfontSplitter
{
    partial class MoreInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreInfo));
            this.dfontsplitterWebsite = new System.Windows.Forms.LinkLabel();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbxIcon = new System.Windows.Forms.GroupBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.gbxFondu = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.imageWell = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxFontforge = new System.Windows.Forms.GroupBox();
            this.fontforgeBuild = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.getSource = new System.Windows.Forms.Button();
            this.gbxIcon.SuspendLayout();
            this.gbxFondu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageWell)).BeginInit();
            this.gbxFontforge.SuspendLayout();
            this.SuspendLayout();
            // 
            // dfontsplitterWebsite
            // 
            this.dfontsplitterWebsite.AutoSize = true;
            this.dfontsplitterWebsite.Location = new System.Drawing.Point(200, 8);
            this.dfontsplitterWebsite.Name = "dfontsplitterWebsite";
            this.dfontsplitterWebsite.Size = new System.Drawing.Size(233, 13);
            this.dfontsplitterWebsite.TabIndex = 7;
            this.dfontsplitterWebsite.TabStop = true;
            this.dfontsplitterWebsite.Text = "https://peter.upfold.org.uk/projects/dfontsplitter";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 8);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(193, 13);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "DfontSplitter is created by Peter Upfold:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(10, 30);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(385, 13);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "This program is free software and open source, under the GNU GPL version 3.0.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(355, 185);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // gbxIcon
            // 
            this.gbxIcon.Controls.Add(this.Label6);
            this.gbxIcon.Location = new System.Drawing.Point(362, 246);
            this.gbxIcon.Name = "gbxIcon";
            this.gbxIcon.Size = new System.Drawing.Size(251, 158);
            this.gbxIcon.TabIndex = 14;
            this.gbxIcon.TabStop = false;
            this.gbxIcon.Text = "Icon";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(9, 15);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(237, 130);
            this.Label6.TabIndex = 0;
            this.Label6.Text = resources.GetString("Label6.Text");
            // 
            // gbxFondu
            // 
            this.gbxFondu.Controls.Add(this.Label1);
            this.gbxFondu.Controls.Add(this.Label2);
            this.gbxFondu.Controls.Add(this.LinkLabel1);
            this.gbxFondu.Location = new System.Drawing.Point(12, 261);
            this.gbxFondu.Name = "gbxFondu";
            this.gbxFondu.Size = new System.Drawing.Size(330, 98);
            this.gbxFondu.TabIndex = 11;
            this.gbxFondu.TabStop = false;
            this.gbxFondu.Text = "Fondu";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(5, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(325, 26);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "DfontSplitter is a GUI wrapper around the tools fondu and fontforge.\r\nMore inform" +
    "ation on fondu is available at:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(5, 74);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(298, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Fondu is released under a BSD-style licence. See Readme.rtf.";
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Location = new System.Drawing.Point(5, 49);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(147, 13);
            this.LinkLabel1.TabIndex = 1;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "http://fondu.sourceforge.net/";
            this.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageWell
            // 
            this.imageWell.Image = global::DfontSplitter.Properties.Resources.dfontsplitter_128;
            this.imageWell.Location = new System.Drawing.Point(463, 30);
            this.imageWell.Name = "imageWell";
            this.imageWell.Size = new System.Drawing.Size(128, 128);
            this.imageWell.TabIndex = 15;
            this.imageWell.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(442, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Version: 0.4.1 for Windows";
            // 
            // gbxFontforge
            // 
            this.gbxFontforge.Controls.Add(this.fontforgeBuild);
            this.gbxFontforge.Controls.Add(this.linkLabel2);
            this.gbxFontforge.Controls.Add(this.label5);
            this.gbxFontforge.Location = new System.Drawing.Point(13, 365);
            this.gbxFontforge.Name = "gbxFontforge";
            this.gbxFontforge.Size = new System.Drawing.Size(339, 154);
            this.gbxFontforge.TabIndex = 17;
            this.gbxFontforge.TabStop = false;
            this.gbxFontforge.Text = "FontForge";
            // 
            // fontforgeBuild
            // 
            this.fontforgeBuild.AutoSize = true;
            this.fontforgeBuild.Location = new System.Drawing.Point(6, 99);
            this.fontforgeBuild.Name = "fontforgeBuild";
            this.fontforgeBuild.Size = new System.Drawing.Size(323, 52);
            this.fontforgeBuild.TabIndex = 5;
            this.fontforgeBuild.Text = "FontForge Windows build (32-bit)\r\nMon, Apr  6, 2020 11:04:29 AM +0000\r\ne5275eb60f" +
    "a1c2de76157cf8c0ccc89909f4ce69 [HEAD]\r\nBased on master: 1cd85a0e621352f81aca07bf" +
    "9eb42467ee078f38\r\n";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(6, 65);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(238, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://sourceforge.net/projects/fontforgebuilds/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "DfontSplitter uses FontForge to produce Windows-compatible\r\nTTF files. The FontFo" +
    "rge distribution is licensed under the GNU GPL\r\nv3 as above.";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(538, 504);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // getSource
            // 
            this.getSource.Location = new System.Drawing.Point(513, 410);
            this.getSource.Name = "getSource";
            this.getSource.Size = new System.Drawing.Size(100, 23);
            this.getSource.TabIndex = 19;
            this.getSource.Text = "Get Source Code";
            this.getSource.UseVisualStyleBackColor = true;
            this.getSource.Click += new System.EventHandler(this.getSource_Click);
            // 
            // MoreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 539);
            this.Controls.Add(this.getSource);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.gbxFontforge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.imageWell);
            this.Controls.Add(this.gbxIcon);
            this.Controls.Add(this.gbxFondu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.dfontsplitterWebsite);
            this.Controls.Add(this.Label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoreInfo";
            this.ShowIcon = false;
            this.Text = "More Info";
            this.gbxIcon.ResumeLayout(false);
            this.gbxIcon.PerformLayout();
            this.gbxFondu.ResumeLayout(false);
            this.gbxFondu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageWell)).EndInit();
            this.gbxFontforge.ResumeLayout(false);
            this.gbxFontforge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.LinkLabel dfontsplitterWebsite;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.GroupBox gbxIcon;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox gbxFondu;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.LinkLabel LinkLabel1;
        private System.Windows.Forms.PictureBox imageWell;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbxFontforge;
        private System.Windows.Forms.Label fontforgeBuild;
        private System.Windows.Forms.LinkLabel linkLabel2;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button getSource;
    }
}