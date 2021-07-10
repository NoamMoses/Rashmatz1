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
    public partial class whatsNew : Form {
        private const string v1_0 = "עודכן בתאריך: 03/07/2021." + "\n" +
            "גרסה ראשונה. המערכת כוללת אפשרות להוספת פריט, עריכה ומחיקה. בנוסף, יש אפשרות לשינוי מיקום הקבצים דרך ההגדרות.",
            
            v1_1 = "עודכן בתאריך: 09/07/2021." + "\n" +
            "- שיפור וייעול קוד." + "\n" +
            "- שיפור  ה GUI (ממשק משתמש)." + "\n" +
            "- הוספת \"נוצר ב\" ו \"עודכן ב\" לפריטים." + "\n" +
            "- הוספת עמוד זה.";

        public whatsNew() {
            InitializeComponent();
        }
        private void whatsNew_Load(object sender, EventArgs e) {
            credits.Text = Sys.credits;
            Sys.setVersionLabel(version);
            handleText();
        }

        private void versions_CheckedChanged(object sender, EventArgs e) {
            handleText();
        }

        private void handleText() {
            /*
             * Handles the text represented
            */
            if (version1_0.Checked) {
                whatsNewText.Text = v1_0;
            } else if (version1_1.Checked) {
                whatsNewText.Text = v1_1;
            }
        }
    }

}
