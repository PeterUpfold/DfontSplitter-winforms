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
    public partial class Options : Form
    {

        private UserSettings sets;
        private UpdateChecker uc;
        private bool hasChangedSpinBox = false;

        const bool UPDATE_CHECKER_AUTOMATIC = false;
        const bool UPDATE_CHECKER_USERINITIATED = true;


        public Options()
        {
            InitializeComponent();
            sets = new UserSettings();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            showDestFolder.Checked = sets.shouldSpawnExplorer;
            enableAutoUpdates.Checked = sets.shouldCheckForUpdates;
            checkIntervalSpinBox.Value = sets.updateCheckFrequency;

            if (sets.shouldCheckForUpdates == false)
            {
                checkIntervalSpinBox.Enabled = false;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // set and save the options

            sets.shouldSpawnExplorer = showDestFolder.Checked;
            sets.shouldCheckForUpdates = enableAutoUpdates.Checked;
            
            if (enableAutoUpdates.Checked)
            {
                sets.updateCheckFrequency = (int) checkIntervalSpinBox.Value;
            }

            sets.Save();
            this.DialogResult = DialogResult.OK;

        }

        private void enableAutoUpdates_CheckedChanged(object sender, EventArgs e)
        {
            if (!enableAutoUpdates.Checked)
            {
                checkIntervalSpinBox.Enabled = false;
            }
            else
            {
                checkIntervalSpinBox.Enabled = true;
            }
        }

        private void checkNowButton_Click(object sender, EventArgs e)
        {
            uc = new UpdateChecker(UPDATE_CHECKER_USERINITIATED);

            if (uc.isNewUpdate)
            {
                sets.shouldCheckForUpdates = enableAutoUpdates.Checked;
                sets.Save(); // save in case the user changed the update setting before clicking Check Now
                             // so that their setting is preserved in the popup

                UpdateInformation updateInfoWindow = new UpdateInformation(uc.releaseNotes, uc.downloadURL);
                updateInfoWindow.ShowDialog();
            }

            // reload options in case they changed in that dialogue

            sets.Reload();
            enableAutoUpdates.Checked = sets.shouldCheckForUpdates;
            if (!hasChangedSpinBox) // but not if the user was editing here a moment ago
            {
                checkIntervalSpinBox.Value = sets.updateCheckFrequency;
            }

            if (sets.shouldCheckForUpdates == false)
            {
                checkIntervalSpinBox.Enabled = false;
            }

        }

        private void checkIntervalSpinBox_ValueChanged(object sender, EventArgs e)
        {
            hasChangedSpinBox = true;
        }

    }
}
