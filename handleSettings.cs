using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rashmatz1 {
    class handleSettings {

        private string settingsPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath); // Default path is the current path
        
        // handleLog myLog;
        public string[] SETTINGS_CONTENT;
        public int SETTINGS_ROWS_LEN;
        private void createSettingsIfNotExist() {
            /*
             * Checks if a settings.txt file exists - and creates one if not
             * The paths is ironically always the same - the path of the exe file
             * Because the settings file must be in the same folder, so the software can read it -
             *   Because just this way, it can know where to look for -
             *   Because I don't want to use registery or things like that
            */

            string fullPath = settingsPath + "\\" + Sys.SETTINGS_NAME; // Path to settings.txt

            // Checks if the file exists, and creates one of not
            if (!File.Exists(fullPath)) {
                using (FileStream settingsFile = File.Create(fullPath)) {
                }
                // File.Create(fullPath).Close(); // Just a different way for creating and closing a file

                // Ironically keeping the path the same
                this.settingsPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                setSettingsDir(this.settingsPath);

                handleLog myLog = new handleLog();
                myLog.write("Settings file created");
            } else { // Already exists, and again, ironically, keeping the path the same
                this.settingsPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath); // getProperty() hasn't been set yet??? returns empty
            }
        }

        public handleSettings() {
            Console.WriteLine("* handleSettings constructor *");
            createSettingsIfNotExist();
            SETTINGS_CONTENT = File.ReadAllLines(settingsPath + "\\" + Sys.SETTINGS_NAME);
            SETTINGS_ROWS_LEN = SETTINGS_CONTENT.Length;
        }

        private bool checkIfSettingsExists(string property) {
            /*
             * 
             * TODO VERSION 1.2
             * 
             * Checks if a property exists in settings file.
             * Shouldn't happen, since I always hard-code the values to look for
            */

            return Sys.isExist_stringArray(Sys.possibleSettings, property);
        }

        public void setSettingsDir(string path) {
            /*
             * Sets the data directiory path.
             * The path is given via parameter
            */

            string[] content = { // New content to be written to file, in case there was no previous data
                "data;" + path
            };
            string currentDir = getSettingsDir();

            if (currentDir == "") { // No previous data, need to hard-code one
                File.AppendAllLines(path + "\\" + Sys.SETTINGS_NAME, content);
            } else { // There is a previous data, just need to update it
                updateSettings("data", path);
            }
        }

        public string getSettingsDir() {
            /*
             * Returns the current data directory path
            */

            return getProperty("data");
        }

        public int getIndexByProperty(string index) {
            /*
             * Returns the index (line number) of a settings' field, by its property (e.g. "data")
            */

            int i,
                foundAt = -1; // Default value is -1, means the item was not found

            string[] lineSplit;
            string currentID;

            for (i = 0; i < SETTINGS_ROWS_LEN; i++) {
                lineSplit = SETTINGS_CONTENT[i].Split(';');
                currentID = lineSplit[0];
                if (currentID == index) { // Item found
                    foundAt = i;
                    break; // Just in case
                }
            }

            return foundAt;
        }

        public string getProperty(string property) {
            /*
             * Returns a settings' property.
             * Example:
             *   Settings line: "data;C:\\.."
             *   Input: "data"
             *   Returns: "C:\\.."
            */

            string[] content = File.ReadAllLines(settingsPath + "\\" + Sys.SETTINGS_NAME),
                    newContent = new string[content.Length];
            int i;
            string[] lineSplit;
            string propertyValue = "";

            for (i = 0; i < content.Length; i++) {
                lineSplit = content[i].Split(';');
                if (lineSplit[0] == property) { // Desired property
                    propertyValue = lineSplit[1];
                    break; // Just in case
                }
            }

            return propertyValue;
        }

        public int updateSettings(string property, string newValue) {
            /*
             * Gets a settings-property via parameter (property)
             * And updates it to a new value, provided via parameter (newValue).
             * The updating proccess works as follows:
             *   - Reading the file into a new array
             *   - Lopping through it
             *   - When the desired line is found - updating it in the copied-content array
             *   - Re-writing the file, using the new array
             * 
             * Returns 0 in case the settings weren't changed - new value is same as old value
             * Returns 1 in case the settings were changed
             * Old style was with void - no control on whether the value was updated or not,
             *   And the user wasn't informed about whether the settings were actually updated or not
             *   - Just the log file was updated correctly, but no matching message to the user
            */

            handleLog myLog = new handleLog();
            string settingsFilePath = settingsPath + "\\" + Sys.SETTINGS_NAME,
                newLine,
                lastValue = ""; // Saves the last value just so I can write it into the log file
            string[] content = File.ReadAllLines(settingsFilePath),
                    newContent = new string[content.Length],
                    lineSplit;
            int i, state;

            for (i = 0; i < content.Length; i++) {
                // Copies the file
                newContent[i] = content[i];
            }
            for (i = 0; i < newContent.Length; i++) {
                lineSplit = newContent[i].Split(';');
                if (lineSplit[0] == property) { // Desired line
                    newLine = property + ";" + newValue;
                    lastValue = lineSplit[1]; // Saves the last data, for the log file
                    newContent[i] = newLine; // Updates the line
                    break; // Just in case
                }
            }

            File.WriteAllLines(settingsFilePath, newContent); // Writes the new data

            if (lastValue == newValue) { // Values are the same, settings file wasn't changed
                myLog.write("Data folder hasn't been changed, since the last, and current paths, are both the same: " + lastValue + " => " + newValue);
                state = 0;
            } else { // Values aren't thr same, settings file was changed
                myLog.write("Data folder has been changed. " + lastValue + " => " + newValue);
                state = 1;
            }

            return state;
        }
    }
}
