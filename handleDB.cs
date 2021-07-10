using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rashmatz1 {
    class handleDB {
        public string[] DB_CONTENT; // Should be private?
        public int DB_ROWS_LEN;
        private string fullDBPath;
        List<Item> dbData;
        handleLog myLog;
        handleSettings mySettings;

        private void createDBIfNotExist() {
            /*
             * Checks if a db.txt file exists - and creates one if not
            */

            if (!File.Exists(fullDBPath)) {
                using (FileStream DBFile = File.Create(fullDBPath)) {
                    myLog.write("DB File created");
                    Console.WriteLine("DB File created in: " + fullDBPath);
                }
            } else {
                Console.WriteLine("DB File was already exist in: " + fullDBPath);
            }
        }

        public handleDB() {
            string line;
            string[] lineSplitted;

            Console.WriteLine("* handleDB constructor *");
            dbData = new List<Item>();
            myLog = new handleLog();
            mySettings = new handleSettings();
            fullDBPath = mySettings.getSettingsDir() + "\\" + Sys.DB_NAME;
            Console.WriteLine("fullDBPath = " + fullDBPath);

            createDBIfNotExist();
            DB_CONTENT = File.ReadAllLines(fullDBPath);
            DB_ROWS_LEN = DB_CONTENT.Length;

            // Init the data list, with values from db.txt
            using (StreamReader DBFile = new StreamReader(fullDBPath)) {
                while ((line = DBFile.ReadLine()) != null) {
                    lineSplitted = line.Split(';');
                    if (line == "") { // Empty line, IGNORED
                        continue;
                    }

                    dbData.Add(new Item {
                        itemID = lineSplitted[0],
                        itemName = lineSplitted[1],
                        itemData = lineSplitted[2],
                        itemCount = lineSplitted[3],
                        itemMakat = lineSplitted[4],
                        itemMakatFactory = lineSplitted[5],
                        itemLocation = lineSplitted[6],
                        itemComments = lineSplitted[7],
                        itemSign = lineSplitted[8]
                    });
                    /* TODO check if possible to remove this hard-coded setup */
                }
            }
        }

        public List<Item> getData() {
            /*
             * Returns the DB data as follow:
             * List of "Item" - each object is a row in DB.
             * Values are provided using get - set
            */

            return this.dbData;
        }

        public List<int> getUsedIDs() {
            /*
             * Returns a list (int), of all used IDs
             * Used to generate new IDs - to know which IDs are already taken.
            */
            
            List<Item> dbData = getData();
            List<int> used = new List<int>();
            int i = 0;

            for (i = 0; i < dbData.Count; i++) {
                used.Add(Int32.Parse(dbData[i].itemID));
            }

            return used;
        }

        public int genNewID() {
            /*
             * Generates a new ID
             * A good ID is:
             *   In range: ID_MIN - ID_MAX
             *   Doesn't exist (determined by getUsedIDs function)
            */

            Random rand = new Random();
            List<int> usedID = getUsedIDs(); // All used IDs
            int newID = rand.Next(Sys.ID_MIN, Sys.ID_MAX);

            for (int i = 0; i < usedID.Count; i++) {
                while (newID == usedID[i]) {
                    // Generates a new ID as long as the new generated ID is in the list of already used IDs
                    newID = rand.Next(Sys.ID_MIN, Sys.ID_MAX);
                }
            }

            return newID;
        }

        public int getIndexByID(string ID) {
            /*
             * Returns the index (line number) of a db-row, by its ID property
            */

            int i,
                foundAt = -1; // Default value. Means the item was not found
            string[] lineSplit;
            string currentID;

            for (i = 0; i < DB_ROWS_LEN; i++) {
                lineSplit = DB_CONTENT[i].Split(';');
                currentID = lineSplit[0];
                if (currentID == ID) { // Item found
                    foundAt = i;
                    // TODO break?
                }
            }

            return foundAt;
        }

        public string getCreatedOnByID(string ID) {
            /*
             * Returns the createdOn (date and hour) value of a DB row, by its ID
            */

            string createdOn = "", currentID;
            int i;
            string[] lineSplit;

            for (i = 0; i < DB_ROWS_LEN; i++) {
                lineSplit = DB_CONTENT[i].Split(';');
                currentID = lineSplit[0]; // 0 = ID index
                if (currentID == ID) { // Item found
                    createdOn = lineSplit[9]; // 9 = createdOn index
                    break;
                }
            }

            return createdOn;
        }

        public string getUpdatedOnByID(string ID) {
            /*
             * Returns the updatedOn (date and hour) value of a DB row, by its ID
            */

            string createdOn = "default updatedOn";
            int i;
            string[] lineSplit;
            string currentID;

            for (i = 0; i < DB_ROWS_LEN; i++) {
                lineSplit = DB_CONTENT[i].Split(';');
                currentID = lineSplit[0]; // 0 = ID index
                if (currentID == ID) { // Item found
                    createdOn = lineSplit[10]; // 10 = updatedOn index
                    break;
                }
            }

            return createdOn;
        }

        public void addNewRow(string newRow) {
            /*
             * Adds a now row to DB.
             * Value is provided by the parameter.
            */

            File.AppendAllText(fullDBPath, "\n" + newRow);
            myLog.write("DB Added a new row: " + newRow);
        }

        public void deleteRow(string ID) {
            /*
             * Delets a row from DB.
             * Index is provided by the parameter, as ID.
            */

            int index = getIndexByID(ID);

            Console.WriteLine("* deleting a row - index= " + index  + " * ");
            List<string> allRows = File.ReadAllLines(fullDBPath).ToList(); // Copies the DB
            myLog.write("DB Deleted a row: " + allRows[index]);
            allRows.RemoveAt(index); // removes the desired line
            File.WriteAllLines(fullDBPath, allRows.ToArray()); // Re-writes the DB
        }

        public void updateRow(int lineIndex, string newValue) {
            /*
             * Upades an existing row in DB.
             * Gets the line index (line number) and the new value to write, by the parameters.
            */

            string[] content = File.ReadAllLines(fullDBPath),
                    newContent = new string[content.Length];
            int i;

            for (i = 0; i < content.Length; i++) {
                // Copies the DB
                newContent[i] = content[i];
            }
            for (i = 0; i < content.Length; i++) {
                // Checks for the row to be edited, and writes the new value
                if (i == lineIndex) {
                    myLog.write("DB Updated a row: " + newContent[i] + " => " + newValue);
                    newContent[i] = newValue;
                    break; // Just in case there is more than just one matching row, somehow
                }
            }

            File.WriteAllLines(fullDBPath, newContent); // Re-writes the DB.
        }

        public void removeBlankLines() {
            /*
             * Removes all blank lines from db.txt
             * The software knows to work also with blank lines, but better to get rid of them.
             * Also looks a bit better when opening and reading the db file.
            */

            string[] content = File.ReadAllLines(fullDBPath);
            List<string> newContent = new List<string>();
            int i;

            // Saves the data, as long as the line isn't empty
            for (i = 0; i < content.Length; i++) {
                if (content[i] == "") {
                    Console.WriteLine("* handleDB => removeEmptyLines() | Removed empty line *");
                    myLog.write("DB Removed an empty line");
                    continue;
                }
                newContent.Add(content[i]);
            }

            File.WriteAllLines(fullDBPath, newContent.ToArray()); // Re-writes the DB.
        }
    }
}
