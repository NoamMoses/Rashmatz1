using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rashmatz1 {
    public partial class Settings : Form {

        handleSettings mySettings;
        mainWin main; // For refreshing the main listView
        string currentDir, chosenPath;
        bool closeOK;

        public Settings(mainWin main) {
            InitializeComponent();
            closeOK = false;
            Sys.setVersionLabel(version);
            credits.Text = Sys.credits;
            mySettings = new handleSettings();
            this.main = main;
            currentDir = mySettings.getSettingsDir();
            chosenPath = currentDir; // Just to have a default value, and not empty ""
        }

        private void Settings_Load(object sender, EventArgs e) {
            folderLocation.Text = currentDir;
        }
        private void Settings_Close(object sender, FormClosingEventArgs e) {
            /*
             * Close window event - occurs when:
             * - The X button is pressed
             * - this.Close() is being called
            */

            string msg = "האם אתה בטוח שברצונך לסגור את עריכת ההגדרות? כול השינויים יימחקו",
                title = "אישור פעולה | ביטול סגירת הגדרות";

            if (!closeOK) {
                DialogResult confirm = Sys.showRTLConfirmationDialog(title, msg, MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes) {
                    closeOK = true;
                }
            }

            // Value is set in each function: save, cancel
            if (closeOK) { // Form is allowed to be closed
                e.Cancel = false;
            } else { // Form should stay open
                e.Cancel = true;
            }
        }

        private void chooseFolder_Click(object sender, EventArgs e) {
            /* Folder-chose button */

            chosenPath = selectFolderDialog(currentDir);
            folderLocation.Text = chosenPath;
        }

        private void cancelEdit_Click(object sender, EventArgs e) {
            /* Cancel */

            string msg = "האם אתה בטוח שברצונך לבטל את עריכת ההגדרות? כול השינויים יימחקו",
                title = "אישור פעולה | ביטול עריכת הגדרות";

            DialogResult confirm = Sys.showRTLConfirmationDialog(title, msg, MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes) {
                closeOK = true;
                this.Close(); // Just closing the form, no need to do anything special
            }
        }

        private void saveItem_Click(object sender, EventArgs e) {
            /* Save */

            string msgOK = "",
                title = "אישור פעולה | שמירת עריכת הגדרות";
            int state;

            state = mySettings.updateSettings("data", chosenPath);
            File.Move(currentDir + "\\" + Sys.DB_NAME, chosenPath + "\\" + Sys.DB_NAME);
            File.Move(currentDir + "\\" + Sys.LOG_NAME, chosenPath + "\\" + Sys.LOG_NAME);
            if (state == 0) {
                msgOK = "ההגדרות נותרו ללא שינוי.";
            } else if (state == 1) {
                msgOK = "ההגדרות נשמרו בהצלחה!";
            }

            DialogResult confirm = Sys.showRTLConfirmationDialog(title, msgOK, MessageBoxButtons.OK);
            if (confirm == DialogResult.OK) {
                closeOK = true;
                main.refreshMainListView();
                this.Close();
            }

            /*
             * TODO Add try-catch, and handle possible exceptions - in case it can even happen
            */
        }





        /*
         * ----------------
         * | My Functions |
         * ----------------
        */

        private string selectFolderDialog(string defaultPath) {
            /*
             * Opens dialog for chosing a folder
            */

            FolderBrowserDialog chooseFolder = new FolderBrowserDialog();
            chooseFolder.SelectedPath = defaultPath;
            string selectedPath = defaultPath;

            if (chooseFolder.ShowDialog() == DialogResult.OK) {
                selectedPath = chooseFolder.SelectedPath;
            }

            return selectedPath;
        }
    }
}
