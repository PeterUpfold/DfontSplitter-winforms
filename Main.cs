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
using System.Diagnostics;
using System.IO;

namespace DfontSplitter
{
    public partial class Main : Form
    {

        private UpdateChecker updateChecker;
        private UserSettings sets;
        private bool shouldSpawnExplorer;

        public Main()
        {
            InitializeComponent();
            sets = new UserSettings();
            shouldSpawnExplorer = sets.shouldSpawnExplorer;
        }

        private void addFileToListButton_Click(object sender, EventArgs e)
        {
            sourceFileSelector.FileName = ""; // zero out filename
            sourceFileSelector.Filter = ".dfont files (*.dfont)|*.dfont";
            sourceFileSelector.Title = "Select dfont files to convert";
            sourceFileSelector.Multiselect = true;


            if (sourceFileSelector.ShowDialog() == DialogResult.OK)
            {

                // add each file to the list

                foreach (string filename in sourceFileSelector.FileNames)
                {
                    // if file already exists in the list, do nothing
                    if (!sourceList.Items.Contains(filename))
                        sourceList.Items.Add(filename);
                }
            }

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            destinationFolderSelector.ShowNewFolderButton = true;
            destinationFolderSelector.ShowDialog();
            destinationFolderText.Text = destinationFolderSelector.SelectedPath;
        }

        private void removeFileFromListButton_Click(object sender, EventArgs e)
        {
            try
            {
                sourceList.Items.RemoveAt(sourceList.SelectedIndex);
                sourceList.Focus();
            }
            catch (Exception) { }
        }

        private void sourceList_DragEnter(object sender, DragEventArgs e)
        {
            // handle hovering over the list with a file in hand
            // display the right cursor to encourage drop on hover with file
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
                e.Effect = DragDropEffects.Copy;
        }

        private void sourceList_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            bool hasShownError = false; // don't flood with error messages

            foreach (string filename in droppedFiles)
            {
                
                // check file extension (yuck) to check format
                string extension = System.IO.Path.GetExtension(filename);

                if (extension != ".dfont") {
                    if (!hasShownError)
                    {
                        MessageBox.Show("File '" + filename + "' is not a .dfont file.",
                            "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hasShownError = true;
                    }
                }
                else
                    sourceList.Items.Add(filename);
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {
//            if (!fileExists(System.AppDomain.CurrentDomain.BaseDirectory + "fondu.exe") || !fileExists(System.AppDomain.CurrentDomain.BaseDirectory + "cygwin1.dll"))
//            {
//                MessageBox.Show(@"The required files fondu.exe and cygwin1.dll were not found.
//These files must be in the same folder as DfontSplitter.exe.
//Please try reinstalling the program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
//                Application.Exit();
//            }

            updateCheckWorker.RunWorkerAsync();

        }


        private bool fileExists(string filename)
        {
            System.IO.FileInfo handle;
            handle = new System.IO.FileInfo(filename);

            return handle.Exists;            
        }

        private bool directoryExists(string dirname)
        {
            System.IO.DirectoryInfo handle;
            handle = new System.IO.DirectoryInfo(dirname);

            return handle.Exists;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {

            // we must have >0 items in list box of source
            if (sourceList.Items.Count <= 0)
            {
                MessageBox.Show(@"You must choose at least one source file to convert.

Use the 'Add Files' button to choose one or more .dfont files and try again.", "No Source Files", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // we must have a destination folder set
            if (destinationFolderText.Text.Length <= 0)
            {
                MessageBox.Show(@"You must choose a destination folder.

Use the 'Browse' button to choose a location to save the files and try again.", "No Destination Folder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // is destintation folder valid?
            if (!directoryExists(destinationFolderText.Text))
            {
                MessageBox.Show(@"That destination folder does not exist. You must choose a valid destination folder.

Use the 'Browse' button to choose a valid location to save the files and try again.", "No Destination Folder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // check that all the source files still exist (the user didn't delete/move them)

            foreach(string filename in sourceList.Items)
            {
                if (!fileExists(filename))                {
                    MessageBox.Show(@"The source file '" + filename + @"' can no longer be found. Has it been moved or deleted?

Please remove it from the list, add it again if necessary and try again.", "File Has Gone", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                }
            }

            if (checkDirForTTF(destinationFolderText.Text))
            {
                if (MessageBox.Show(@"There are fonts already in your destination folder.

If the extracted TTF files have the same names as these existing fonts, they may be overwritten.

Do you want to overwrite any original files?", "Overwrite Originals", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                
            }

            progress.Visible = true;
            convertButton.Enabled = false;
            convertButton.Text = "Converting...";

            fonduWorker.RunWorkerAsync(); // run fondu in BackgroundWorker

        }

        private void fonduWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // ****** CALLING FONDU **********

            // we must loop through and do a fondu for each item in the source list

            string tempPath = Path.Combine(Path.GetTempPath(), "dfontsplitter-" + Process.GetCurrentProcess().Id);

            foreach (string filename in sourceList.Items)
            {
                string thisFileTempPath = tempPath + "-" + Path.GetFileNameWithoutExtension(filename);
                Directory.CreateDirectory(thisFileTempPath);
                Directory.SetCurrentDirectory(thisFileTempPath);
                
                FonduWrapper.fondu_simple_main(filename);

                // copy results to destination folder
                foreach(string file in Directory.GetFiles(Directory.GetCurrentDirectory()))
                {
                    string normalisedFilePath = "";
                    int exitCode = -1;
                    // normalise all TTFs
                    if (file.EndsWith(".ttf"))
                    {
                        
                        try
                        {
                            exitCode = FontForgeWrapper.NormaliseTTF(Path.GetFileName(file), Directory.GetCurrentDirectory(), out normalisedFilePath);
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.ToString());
                            //TODO handle this 
                        }
                    }

                    string pathToUse = file;
                    if (normalisedFilePath.Length > 0 && exitCode == 0)
                    {
                        pathToUse = normalisedFilePath;
                    }

                    File.Copy(pathToUse, Path.Combine(destinationFolderText.Text, Path.GetFileName(file)), true);
                }
               

                Directory.SetCurrentDirectory(Path.GetTempPath());

                foreach(string file in Directory.GetFiles(thisFileTempPath))
                {
                    File.Delete(file);
                }
                Directory.Delete(thisFileTempPath);
            }

            
        }

        private void fonduWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            // put the UI back how we found it
            progress.Visible = false;
            convertButton.Enabled = true;
            convertButton.Text = "Convert";


            // all tied up, so throw Explorer if desired


            if (shouldSpawnExplorer == true) { 
                Process.Start(destinationFolderText.Text); // spawn Explorer window
            }

            // do other stuff when done
        }

        private bool checkDirForTTF(string dirName)
        {
            /* if we detect TTFs already in the source dir, then don't hide the fondu
             window, in case overwrite input is needed from the user */

            // ugly, and hacky, but ah well

            DirectoryInfo dirHandle = new DirectoryInfo(dirName);

            FileInfo[] fileList = dirHandle.GetFiles();

            foreach (FileInfo file in fileList)
            {

                if (file.Extension == ".ttf" || file.Extension == ".bdf")
                    return true;

            }

            return false;           
        }

        private void moreInfoButton_Click(object sender, EventArgs e)
        {
            Form moreInfoFormRef = new MoreInfo();
            moreInfoFormRef.ShowDialog();
        }

        private void updateCheckWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            updateChecker = new UpdateChecker();
        }

        private void updateCheckWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (updateChecker.isNewUpdate)
            {
                UpdateInformation updateInfoWindow = new UpdateInformation(updateChecker.releaseNotes, updateChecker.downloadURL);
                updateInfoWindow.ShowDialog();
            }
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            Options optionsWindow = new Options();
            optionsWindow.ShowDialog();

            // reload Main's settings in case they changed
            sets.Reload();
            shouldSpawnExplorer = sets.shouldSpawnExplorer;
        }


    }
}
