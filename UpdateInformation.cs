/*
 DfontSplitter 0.3 for Windows - GUI frontend to fondu, converts .dfont to .ttf
 Copyright (C) 2008-2011 Peter Upfold.

 This program is free software: you can redistribute it and/or modify
 it under the terms of the GNU General Public License as published by
 the Free Software Foundation, either version 3 of the License, or
 (at your option) any later version.
  
 This program is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU General Public License for more details.

 You should have received a copy of the GNU General Public License
 along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DfontSplitter
{

    public partial class UpdateInformation : Form
    {

        private UserSettings sets;
        private string releaseNotes;
        private string download;

        public UpdateInformation(string releaseNotesURL, string downloadURL)
        {
            InitializeComponent();
            sets = new UserSettings();
            releaseNotes = releaseNotesURL;
            download = downloadURL;
        }

        private void UpdateInformation_Load(object sender, EventArgs e)
        {
            // set tickbox to update state
            continueAutoUpdating.Checked = (bool)sets.shouldCheckForUpdates;

            releaseNotesPane.Url = new System.Uri(releaseNotes);

            if (!sets.shouldCheckForUpdates)
            {
                remindButton.Text = @"Ignore Update";
            }

        }

        private void UpdateInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            sets.Save();
        }

        private void continueAutoUpdating_CheckedChanged(object sender, EventArgs e)
        {
            if (continueAutoUpdating.Checked)
            {
                sets.shouldCheckForUpdates = true;
                remindButton.Text = "Remind Me &Later";
            }
            else
            {
                sets.shouldCheckForUpdates = false;
                remindButton.Text = "Ignore Update";
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            downloadButton.Text = "Loading...";
            downloadButton.Enabled = false;
            System.Diagnostics.Process.Start(download);
            downloadButton.Text = "&Download...";
            downloadButton.Enabled = true;

            // quit form
            //this.DialogResult = DialogResult.OK;

            // quit the app so the install won't fail
            Application.Exit();

        }

        private void UpdateInformation_Shown(object sender, EventArgs e)
        {
            // reload checkbox incase it changed a moment ago
            sets.Reload();
            continueAutoUpdating.Checked = (bool)sets.shouldCheckForUpdates;
        }


    }
}
