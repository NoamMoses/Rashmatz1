using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rashmatz1 {
    public partial class viewItem : Form {
        /*
         * TODO Notes to myself
         * startedEditOn:
         *   When the form was first open. Otherwise the *label* will show the right time,
         *     but when you press save, the *current* hour will be saved into DB and not
         *     the hour when you opened the form - better? worse? need to check
        */

        private Dictionary<string, string> data = new Dictionary<string, string>();
        private string title, startedEditOn;
        private char mode;
        bool closeOK;
        mainWin main; // For refreshing the main LV
        handleLog myLog;
        handleDB DB;
        Sys mySys;

        public viewItem() {
            InitializeComponent();
            myLog = new handleLog();
            closeOK = false;
        }

        public viewItem(char mode, Dictionary<string, string> data, mainWin main) {
            /*
             * Init class using pre-set data | for editing an item
            */
            Console.WriteLine("* viewItem constructor | with data *");
            InitializeComponent();
            myLog = new handleLog();
            DB = new handleDB();
            mySys = new Sys();
            closeOK = false;
            this.title = parseTitle(mode);
            this.data = data;
            this.main = main;
        }

        public viewItem(char mode, string ID, mainWin main) {
            /*
             * Init class using just an ID (random generated) | for creating a new item
            */
            Console.WriteLine("* viewItem constructor | without data, with ID *");
            InitializeComponent();
            myLog = new handleLog();
            DB = new handleDB();
            mySys = new Sys();
            this.title = parseTitle(mode);
            this.data = Sys.returnItemObj();

            /* Default values */
            this.data["ID"] = ID;
            this.data["count"] = "0";
            this.data["createdOn"] = Sys.getDateHourNoSec();
            this.data["updatedOn"] = Sys.getDateHourNoSec();
            this.main = main;
        }

        private void viewItem_Load(object sender, EventArgs e) {
            credits.Text = Sys.credits;
            this.Text += this.title;Sys.setVersionLabel(version);
            Sys.setVersionLabel(version);

            this.ActiveControl = editFields_nameInput; // Sets the name-input to be active as default
            mainTitle.Text += title;
            startedEditOn = Sys.getDate();
            if (mode == 'n') {
                /*
                 * New item.
                 * - No need for "delete" option.
                 * - createdOn is the time when you opened the form
                */
                deleteItem.Visible = false;
                updatedOn_Title.Visible = false;
                updatedOn_Value.Visible = false;
                createdOn_Value.Text = startedEditOn;
            }

            /*
             * Prepares the listView and textboxes - set default values.
             * - If it is an edit-item form, it also sets the createdOn and updatedOn values
            */
            initListView(mode);
            loadInputs();
        }

        private void viewItem_Close(object sender, FormClosingEventArgs e) {
            /*
             * Close window event - occurs when:
             * - The X button is pressed
             * - this.Close() is being called
            */

            string msg = "", title = "";

            if (mode == 'e') {
                msg = "האם אתה בטוח שברצונך לסגור את יצירת הפריט? כול השינויים יימחקו!";
                title = "אישור פעולה | סגירת יצירת פריט";
            } else if (mode == 'n') {
                msg = "האם אתה בטוח שברצונך לסגור את עריכת הפריט? כול השינויים יימחקו!";
                title = "אישור פעולה | סגירת עריכת פריט";
            }

            if (!closeOK) { // Otherwise cancel will first ask for itself, and then when it calls this function
                DialogResult confirm = Sys.showRTLConfirmationDialog(title, msg, MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes) {
                    closeOK = true;
                    if (mode == 'e') {
                        myLog.write("DB Closed editing an item");
                    } else if (mode == 'n') {
                        myLog.write("DB Closed creating an item");
                    }
                }
            }

            // Value is set in each function: save, delete, cancel
            if (closeOK) { // Form is allowed to be closed
                e.Cancel = false;
            } else { // Form should stay open
                e.Cancel = true;
            }
        }

        /* Handling the label-input relationship */
        private void editFields_nameTitle_Click(object sender, EventArgs e) { editFields_nameInput.Focus(); }
        private void editFields_makatTitle_Click(object sender, EventArgs e) { editFields_makatInput.Focus(); }
        private void editFields_locationTitle_Click(object sender, EventArgs e) { editFields_locatiomInput.Focus(); }
        private void editFields_descTitle_Click(object sender, EventArgs e) { editFields_descInput.Focus(); }
        private void editFields_makatFactoryTitle_Click(object sender, EventArgs e) { editFields_makatFactoryInput.Focus(); }
        private void editFields_signTitle_Click(object sender, EventArgs e) { editFields_signInput.Focus(); }
        private void editFields_commentsTitle_Click(object sender, EventArgs e) { editFields_commentsInput.Focus(); }
        private void editFields_countTitle_Click(object sender, EventArgs e) { editFields_countInput.Focus(); }

        private void cancelEdit_Click(object sender, EventArgs e) {
            /* Cancel */

            string msg = "האם אתה בטוח שברצונך לבטל את עריכת הפריט? כול השינויים יימחקו",
                title = "אישור פעולה | ביטול עריכת פריט";

            DialogResult confirm = Sys.showRTLConfirmationDialog(title, msg, MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes) {
                closeOK = true;
                if (mode == 'e') {
                    myLog.write("DB Canceled editing an item");
                } else if (mode == 'n') {
                    myLog.write("DB Canceled creating an item");
                }

                this.Close(); // Just closing the form, no need to do anything special
            }
        }

        private void deleteItem_Click(object sender, EventArgs e) {
            /* Delete */

            string msgCONFIRM = "האם אתה בטוח שברצונך למחוק את פריט זה? אין אפשרות לביטול הפעולה!",
                msgDONE = "הפריט נמחק בהצלחה.",
                title = "אישור פעולה | מחיקת פריט";

            DialogResult confirm = Sys.showRTLConfirmationDialog(title, msgCONFIRM, MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes) {
                closeOK = true;
                this.DB.deleteRow(this.data["ID"]);
                DialogResult complete = Sys.showRTLConfirmationDialog(title, msgDONE, MessageBoxButtons.OK);
                closeWinAndRefershMainListView();
            } else if (confirm == DialogResult.No || confirm == DialogResult.Cancel) {
            }
        }

        private void saveItem_Click(object sender, EventArgs e) {
            /* Save */

            string msgOK = "הפריט נשמר בהצלחה!",
                msgERR = "לא הייתה אפשרות לשמור את הפריט." +
                "\nאנא וודא את תקינות הערכים ונסה שוב." +
                "\n\n- שדות המסומנים ב-* הינם שדות חובה, והאורך המינימאלי הינו 2 תווים." +
                "\n- אין אפשרות להשתמש בתו ;",
                title = "אישור פעולה | שמירת עריכת פריט",
                newRow;

            if (validateInputs()) {
                DialogResult confirm = Sys.showRTLConfirmationDialog(title, msgOK, MessageBoxButtons.OK);
                if (confirm == DialogResult.OK) {
                    closeOK = true;
                    if (mode == 'n') { // New-item mode
                        newRow = createNewDBRow(startedEditOn, startedEditOn);
                        this.DB.addNewRow(newRow);
                    } else if (mode == 'e') { // Edit mode
                        newRow = createNewDBRow(DB.getCreatedOnByID(this.data["ID"]), startedEditOn);
                        this.DB.updateRow(this.DB.getIndexByID(this.data["ID"]), newRow); // Updating an existing row
                    }
                    main.refreshMainListView();
                    this.Close();
                }
            } else { // Inputs aren't valid
                DialogResult confirm = Sys.showRTLConfirmationDialog(title, msgERR, MessageBoxButtons.OK);
            }
        }



        /*
         * ----------------
         * | My Functions |
         * ----------------
        */

        private void closeWinAndRefershMainListView() {
            /*
             * Referesh the main listView (in main window)
             * And closes the viewItem dialog
            */

            main.refreshMainListView();
            this.Close();
        }

        private bool validateInputs() {
            /*
             * Checks whether the inputs are valid or not
            */

            string[] inputsToValidate = { // Inputs to check
                editFields_nameInput.Text,
            };

            return Sys.validateData(inputsToValidate);
        }
        private string createNewDBRow(string createdOn, string updatedOn) {
            /*
             * Creates a new CSV-style DB row
            */

            string newLine = "";

            newLine += editFields_IDinput.Text + ";";
            newLine += editFields_nameInput.Text + ";";
            newLine += editFields_descInput.Text + ";";
            newLine += editFields_countInput.Text + ";";
            newLine += editFields_makatInput.Text + ";";
            newLine += editFields_makatFactoryInput.Text + ";";
            newLine += editFields_locatiomInput.Text + ";";
            newLine += editFields_commentsInput.Text + ";";
            newLine += editFields_signInput.Text + ";";
            newLine += createdOn + ";"; // Created on
            newLine += updatedOn; // Updated on

            /* TODO check if possible to remove this hard-coded setup */

            return newLine;
        }

        string parseTitle(char mode) {
            /*
             * Returns title (formated string) according to the desired mode
            */

            this.mode = mode;

            if (mode == 'n') {
                return "יצירת פריט חדש";
            } else if (mode == 'e') {
                return "עריכת פריט";
            } else { // Shouldn't happen since the variable is always hard-coded
                return "";
            }
        }

        private void initListView(char mode) {
            /*
             * Loads the list view, createdOn, and updatedOn
            */

            ListViewItem item = new ListViewItem(this.data["ID"]);
            for (int i = 1; i < Sys.indexesNames.Length; i++) {
                item.SubItems.Add(this.data[Sys.indexesNames[i]]);
            }

            /*
             * Notes to myself:
             * When it is n (new item), I can't access the createdOn and updatedOn - because they don't exist
             *   The updatedOn is invisible
             *   The createdOn is initialised in the constructor
             * When it is e (edit item), I initalise the values of createdOn and updatedOn here - values from DB
            */

            if (mode == 'n') {
            } else if (mode == 'e') {
                createdOn_Value.Text = DB.getCreatedOnByID(this.data["ID"]);
                updatedOn_Value.Text = DB.getUpdatedOnByID(this.data["ID"]);
            }

            mainList.Items.Add(item);
        }

        private void loadInputs() {
            /*
             * Loads the textbox inputs, with default texts
            */

            editFields_IDinput.Text = this.data["ID"];
            editFields_nameInput.Text = this.data["name"];
            editFields_descInput.Text = this.data["data"];
            editFields_countInput.Value = Int32.Parse(this.data["count"]);
            editFields_makatInput.Text = this.data["makat"];
            editFields_makatFactoryInput.Text = this.data["makatFactory"];
            editFields_locatiomInput.Text = this.data["location"];
            editFields_commentsInput.Text = this.data["comments"];
            editFields_signInput.Text = this.data["sign"];

            /* TODO check if possible to remove this hard-coded setup */
        }
    }
}
