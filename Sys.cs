using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rashmatz1 {
    class Sys {

        // General system variables
        public const string DB_NAME = "db.txt",
            LOG_NAME = "log.txt",
            SETTINGS_NAME = "settings.txt",
            credits = "פותח על-ידי נעם מערכות\"ש.    חתומוזס 2021 ©",
            version = "1.1",
            lastUpdated = "10/07/2021";
        public const int ID_MIN = 0, ID_MAX = 1000, // IDs range
            INPUT_MIN_LEN = 2; // Minimum valid input length

        // Keys to go through the data dictionary
        public static string[] indexesNames = {
            "ID", "name", "data", "count", "makat", "makatFactory", "location", "comments", "sign",
            "createdOn", "updatedOn"
        };

        /*
         * Possible settings parameters - to know if a desired setting exists or not.
         * Should always exist though, since it's always hard-coded
         * 
         * TODO VERSION 1.2
        */
        public static string[] possibleSettings = {
            "data"
        };

        public static Dictionary<string, string> returnItemObj() {
            /*
             * Returns a dictionary object, to be used as an item
            */

            Dictionary<string, string> data = new Dictionary<string, string>();
            int i;
            for (i = 0; i < indexesNames.Length; i++) {
                data.Add(indexesNames[i], "");
            }

            return data;
        }


        public static DialogResult showRTLConfirmationDialog(string title, string msg, MessageBoxButtons buttons) {
            /*
             * Shows a confirmation dialog, in RTL
            */

            DialogResult confirm = MessageBox.Show(msg, title, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            
            return confirm;
        }

        public static bool validateData(string[] data) {
            /*
             * Checks whether the data provided is valid or not
             * Right now, the only condition is that the input is at least INPUT_MIN_LEN charachters long
            */

            int i;
            bool valid = true;
            for (i = 0; i < data.Length; i++) {
                if (!valid) {
                    break;
                }
                // Checks for ';' - won't work, since it damages the CSV
                foreach (char ch in data[i]) {
                    if (ch == ';') {
                        valid = false;
                        break;
                    }
                }
                if (data[i].Length < INPUT_MIN_LEN) {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        public static void setVersionLabel(Label label) {
            /*
             * Sets the version-last updated label
             * Gets the label via parameter, since the function can't access controls.
            */

            label.Text = "גרסה: " + version + " | " + lastUpdated;
        }

        public static string getDate(string format) {
            /*
             * Returns the date and hour - with an option to use a specific format
             * Default format is en-GB: 03/07 00:27:11
            */

            return DateTime.Now.ToString(new CultureInfo(format));
        }

        public static string getDate() {
            /*
             * Returns the date and hour in en-GB format: 03/07 00:27:11
            */

            return DateTime.Now.ToString(new CultureInfo("en-GB"));
        }

        public static string getDateHourNoSec() {
            /*
             * Returns the date and hour, but unlike getDate(), it returns without the seconds
            */

            string time = DateTime.Now.ToString(new CultureInfo("en-GB"));

            return time.Substring(0, time.Length-3);
        }

        public static bool isExist_stringArray(string[] arr, string value) {
            /*
             * Checks if a string exists in n array
             * TODO Use this feature for checking before accessing the settings file
             *   In case the desired settings doesn't exist
             *     - even though it shouldn't happen, since I always hard-code the values
            */

            bool found = false;
            int i = 0;
            for (i = 0; i < arr.Length; i++) {
                if (arr[i] == value) {
                    found = true;
                    break; // Just in case
                }
            }

            return found;
        }
    }
}
