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
using System.Configuration;
using System.Drawing;

namespace DfontSplitter
{
    class UserSettings : ApplicationSettingsBase
    {

        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool shouldCheckForUpdates
        {

            get
            {
                return ((bool)this["shouldCheckForUpdates"]);
            }

            set
            {
                this["shouldCheckForUpdates"] = (bool)value;
            }

        }

        [UserScopedSetting()]
        [DefaultSettingValue("1970-01-01 00:00:00")]
        public System.DateTime lastUpdateCheck
        {

            get
            {
                return ((System.DateTime)this["lastUpdateCheck"]);
            }

            set {
                this["lastUpdateCheck"] = (System.DateTime)value;
            }

        }

        [UserScopedSetting()]
        [DefaultSettingValue("3")]
        public int updateCheckFrequency
        {

            get
            {
                return (int)this["updateCheckFrequency"];
            }

            set
            {
                this["updateCheckFrequency"] = (int)value;
            }

        }

        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool hasAskedPermissionForUpdateCheck
        {
            get
            {
                return (bool)this["hasAskedPermissionForUpdateCheck"];
            }
            set
            {
                this["hasAskedPermissionForUpdateCheck"] = (bool)value;
            }

        }

        [UserScopedSetting()]
        [DefaultSettingValue("true")]
        public bool shouldSpawnExplorer
        {
            get
            {
                return (bool)this["shouldSpawnExplorer"];
            }
            set
            {
                this["shouldSpawnExplorer"] = (bool)value;
            }

        }

    }
}
