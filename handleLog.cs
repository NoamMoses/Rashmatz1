using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rashmatz1 {
    class handleLog {
        private string logPath;
        handleSettings mySettings;
        private void createLogIfNotExist() {
            /* Checks if a db.txt file exists - and creating one if not */
            if (!File.Exists(logPath)) {
                using (FileStream logFile = File.Create(logPath)) {
                }
                write("Log file created");
            }
        }

        public handleLog() {
            Console.WriteLine("* handleLog constructor *");
            mySettings = new handleSettings();
            logPath = mySettings.getSettingsDir() + "/" + Sys.LOG_NAME; // Parsing the path
            createLogIfNotExist();
        }

        public void write(string line) {
            /*
             * Writes data to the log.txt file.
             * Format is: 03/07/2021 18:06:47 | text
            */
            File.AppendAllText(logPath, Sys.getDate() + " | " + line + "\n");
        }
    }
}
