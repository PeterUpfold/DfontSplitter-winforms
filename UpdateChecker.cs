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
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Configuration;
using System.ComponentModel;
using System.Xml;

namespace DfontSplitter
{
    class UpdateChecker
    {

        private string updateCheckURL = @"https://apps.upfold.org.uk/appupdate/dfontsplitter_windows.xml";
        private Version appVersion;
        private UserSettings sets;
        private WebClient wc;
        private string latestVersion;
        public string releaseNotes;
        public string downloadURL;

        public bool isNewUpdate;

        const bool UPDATE_CHECKER_AUTOMATIC = false;
        const bool UPDATE_CHECKER_USERINITIATED = true;

        public UpdateChecker()
        {
            appVersion = new Version(Application.ProductVersion);
            isNewUpdate = false;
            sets = new UserSettings();

            if (shouldCheckVersion()) {

                checkForUpdate(UPDATE_CHECKER_AUTOMATIC);

            }


        }

        public UpdateChecker(bool userInitiated)
        {

            appVersion = new Version(Application.ProductVersion);
            isNewUpdate = false;
            sets = new UserSettings();
            
            checkForUpdate(userInitiated);

 
        }

        private bool shouldCheckVersion()
        {
            // determine whether a version check out to the internet should be made.


            // get the user preferences on updates
            bool hasAskedPermissionForUpdateCheck = sets.hasAskedPermissionForUpdateCheck;
            bool shouldCheck = sets.shouldCheckForUpdates;

            if (!hasAskedPermissionForUpdateCheck)
            {
                // ask permission for regular update checking
                DialogResult result = MessageBox.Show(@"Should DfontSplitter automatically check for updates?", @"Automatic Updates", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);


                if (result == DialogResult.Yes)
                {
                    sets.shouldCheckForUpdates = true;
                    shouldCheck = true;
                }
                else {
                    sets.shouldCheckForUpdates = false;
                    shouldCheck = false;
                }
                sets.hasAskedPermissionForUpdateCheck = true;
                sets.Save();
            }


            if (shouldCheck)
            {
                //TODO: what if these settings aren't there? Error handling!

                DateTime lastCheck = sets.lastUpdateCheck.ToUniversalTime();
                int checkInterval = sets.updateCheckFrequency;
                DateTime now = new DateTime();
                now = DateTime.Now.ToUniversalTime();

                if (lastCheck.AddDays((double)checkInterval) < now)
                {

                    Console.WriteLine(@"Update check is due -- checking now.");
                    return true;
                }

                else
                {
                    // no check due
                    Console.WriteLine(@"No update check, since we have checked too recently.");
                    return false;
                }

            }
            else
            {
                Console.WriteLine(@"No update check, since update checking is disabled.");
                return false;
            }
        }

        private void checkForUpdate(bool userInitiated)
        {

            System.Uri uri = new System.Uri(updateCheckURL);

            System.OperatingSystem osInfo = System.Environment.OSVersion;

            wc = new WebClient();
            // add user agent
            wc.Headers.Add("User-Agent", "DfontSplitter/" + appVersion.ToString() + "; " + osInfo.Platform.ToString() + "; Windows/" + osInfo.Version.ToString() + "; Update-Checker");
            //wc.DownloadStringCompleted += (object sender, DownloadStringCompletedEventArgs e) => compareUpdateVersions(userInitiated, e);
            // no longer run download async, as the whole updatechecker is run async
            try
            {
                // run the download and pass the resulting string to compareUpdateVersions()
                string latestVersion = wc.DownloadString(uri);
                compareUpdateVersions(userInitiated, latestVersion);
            }
            catch (WebException we)
            {
                Console.WriteLine(@"Unable to check for updates. Error Type: " + we.Status.ToString() + ", Message: '" + we.Message + "'");
            }
            catch (XmlException xe)
            {
                Console.WriteLine(@"Unable to check for updates. The XML data from the update server is malformed, or is not XML data.");
            }
            catch (Exception e)
            {
                Console.WriteLine(@"Unable to download or parse update check XML file. There could be a network issue, or invalid data from the server.");
            }

        }

        private void compareUpdateVersions(bool userInitiated, string latestVersion)
        {

            string newVersionForCompare = "";
            DateTime updateDate = new DateTime();
             
                XmlTextReader reader = new XmlTextReader(new System.IO.StringReader(latestVersion));

                try
                {
                    while (reader.Read())
                    {

                        reader.ReadStartElement("updateVersions");
                        reader.ReadStartElement("latestVersion");
                        newVersionForCompare = reader.ReadString();
                        reader.ReadEndElement();
                        reader.ReadStartElement("updateDateTime");
                        updateDate = DateTime.Parse(reader.ReadString());
                        reader.ReadEndElement();
                        reader.ReadStartElement("releaseNotes");
                        releaseNotes = reader.ReadString();
                        reader.ReadEndElement();
                        reader.ReadStartElement("downloadURL");
                        downloadURL = reader.ReadString();
                        reader.ReadEndElement();
                        reader.ReadEndElement();
                    }

                    // since we've managed to do the update check, we should set the 'last update check'
                    // time to the current time

                    sets.lastUpdateCheck = new DateTime();
                    sets.lastUpdateCheck = DateTime.Now.ToUniversalTime();
                    sets.Save(); // commit last update check settings update

                    // actually compare the current app version with the declared 'latest'
                    Version latest = new Version(newVersionForCompare);

                    switch (appVersion.CompareTo(latest))
                    {
                        case 0:
                            // same version
                            Console.WriteLine(@"The application is up-to-date.");
                           
                            if (userInitiated)
                            {   
                                //TODO: pretty boxes
                                MessageBox.Show(@"The application is up-to-date.", @"Software Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            break;

                        case 1:

                            // current version is later than available
                            Console.WriteLine(@"The application is up-to-date.");

                            if (userInitiated)
                            {
                                //TODO: pretty boxes
                                MessageBox.Show(@"The application is up-to-date.", @"Software Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;


                        case -1:
                            
                            // current version needs updating
                            Console.WriteLine(@"New update " + newVersionForCompare + " is available.");
                            
                            
                            //MessageBox.Show(@"An update " + newVersionForCompare + " is available. Let's go to the site.", @"Software Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                            isNewUpdate = true;

                            break;

                    }


                }
                catch (Exception e2)
                {
                    Console.WriteLine(@"Unable to parse update XML file. There could be a network issue, or invalid data from the server. Update check failed.");
                }

               

           
        }


    }
}
