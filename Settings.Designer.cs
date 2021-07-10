namespace Rashmatz1 {
    partial class Settings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.mainTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chooseFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderLocation = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelEdit = new System.Windows.Forms.Button();
            this.saveItem = new System.Windows.Forms.Button();
            this.credits = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.filesExplainedTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.filesExplainedText_settings = new System.Windows.Forms.Label();
            this.filesExplainedTitle_settings = new System.Windows.Forms.Label();
            this.filesExplainedTitle_db = new System.Windows.Forms.Label();
            this.filesExplainedTitle_log = new System.Windows.Forms.Label();
            this.filesExplainedText_log = new System.Windows.Forms.Label();
            this.filesExplainedText_db = new System.Windows.Forms.Label();
            this.filesExplainedText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(0, 0);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.mainTitle.Size = new System.Drawing.Size(984, 50);
            this.mainTitle.TabIndex = 2;
            this.mainTitle.Text = "הגדרות";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.Controls.Add(this.chooseFolder, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.folderLocation, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(960, 49);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // chooseFolder
            // 
            this.chooseFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chooseFolder.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseFolder.Location = new System.Drawing.Point(546, 4);
            this.chooseFolder.Name = "chooseFolder";
            this.chooseFolder.Size = new System.Drawing.Size(109, 41);
            this.chooseFolder.TabIndex = 1;
            this.chooseFolder.Text = "בחר תיקייה";
            this.chooseFolder.UseVisualStyleBackColor = true;
            this.chooseFolder.Click += new System.EventHandler(this.chooseFolder_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(714, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "תיקייה לשמירת קבצים";
            // 
            // folderLocation
            // 
            this.folderLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.folderLocation.AutoSize = true;
            this.folderLocation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.folderLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderLocation.Location = new System.Drawing.Point(210, 11);
            this.folderLocation.Name = "folderLocation";
            this.folderLocation.Padding = new System.Windows.Forms.Padding(5);
            this.folderLocation.Size = new System.Drawing.Size(108, 27);
            this.folderLocation.TabIndex = 5;
            this.folderLocation.Text = "currentLocation";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cancelEdit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.saveItem, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(627, 314);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(345, 100);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // cancelEdit
            // 
            this.cancelEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelEdit.BackColor = System.Drawing.Color.DarkSalmon;
            this.cancelEdit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelEdit.ForeColor = System.Drawing.Color.White;
            this.cancelEdit.Location = new System.Drawing.Point(184, 3);
            this.cancelEdit.Name = "cancelEdit";
            this.cancelEdit.Size = new System.Drawing.Size(150, 74);
            this.cancelEdit.TabIndex = 2;
            this.cancelEdit.Text = "בטל";
            this.cancelEdit.UseVisualStyleBackColor = false;
            this.cancelEdit.Click += new System.EventHandler(this.cancelEdit_Click);
            // 
            // saveItem
            // 
            this.saveItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.saveItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveItem.ForeColor = System.Drawing.Color.White;
            this.saveItem.Location = new System.Drawing.Point(12, 3);
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(150, 74);
            this.saveItem.TabIndex = 3;
            this.saveItem.Text = "שמור";
            this.saveItem.UseVisualStyleBackColor = false;
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits.Location = new System.Drawing.Point(660, 440);
            this.credits.Name = "credits";
            this.credits.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.credits.Size = new System.Drawing.Size(51, 19);
            this.credits.TabIndex = 12;
            this.credits.Text = "credits";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(3, 440);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(47, 19);
            this.version.TabIndex = 17;
            this.version.Text = "verion";
            // 
            // filesExplainedTitle
            // 
            this.filesExplainedTitle.AutoSize = true;
            this.filesExplainedTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesExplainedTitle.Location = new System.Drawing.Point(16, 150);
            this.filesExplainedTitle.Name = "filesExplainedTitle";
            this.filesExplainedTitle.Size = new System.Drawing.Size(168, 28);
            this.filesExplainedTitle.TabIndex = 18;
            this.filesExplainedTitle.Text = "הסבר על הקבצים:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Controls.Add(this.filesExplainedText_settings, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.filesExplainedTitle_settings, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.filesExplainedTitle_db, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.filesExplainedTitle_log, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.filesExplainedText_log, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.filesExplainedText_db, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(19, 208);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(620, 153);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // filesExplainedText_settings
            // 
            this.filesExplainedText_settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filesExplainedText_settings.AutoSize = true;
            this.filesExplainedText_settings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesExplainedText_settings.Location = new System.Drawing.Point(17, 6);
            this.filesExplainedText_settings.Name = "filesExplainedText_settings";
            this.filesExplainedText_settings.Size = new System.Drawing.Size(462, 38);
            this.filesExplainedText_settings.TabIndex = 23;
            this.filesExplainedText_settings.Text = "קובץ ההגדרות של התוכנה. חייב להימצא באותה תיקייה של התוכנה. *במידה ונמחק, כול הגד" +
    "רות התוכנה יאופסו בחזרה לברירת מחדל.";
            // 
            // filesExplainedTitle_settings
            // 
            this.filesExplainedTitle_settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filesExplainedTitle_settings.AutoSize = true;
            this.filesExplainedTitle_settings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesExplainedTitle_settings.Location = new System.Drawing.Point(517, 16);
            this.filesExplainedTitle_settings.Name = "filesExplainedTitle_settings";
            this.filesExplainedTitle_settings.Size = new System.Drawing.Size(82, 19);
            this.filesExplainedTitle_settings.TabIndex = 20;
            this.filesExplainedTitle_settings.Text = "settings.txt";
            // 
            // filesExplainedTitle_db
            // 
            this.filesExplainedTitle_db.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filesExplainedTitle_db.AutoSize = true;
            this.filesExplainedTitle_db.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesExplainedTitle_db.Location = new System.Drawing.Point(534, 67);
            this.filesExplainedTitle_db.Name = "filesExplainedTitle_db";
            this.filesExplainedTitle_db.Size = new System.Drawing.Size(49, 19);
            this.filesExplainedTitle_db.TabIndex = 21;
            this.filesExplainedTitle_db.Text = "db.txt";
            // 
            // filesExplainedTitle_log
            // 
            this.filesExplainedTitle_log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filesExplainedTitle_log.AutoSize = true;
            this.filesExplainedTitle_log.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesExplainedTitle_log.Location = new System.Drawing.Point(532, 118);
            this.filesExplainedTitle_log.Name = "filesExplainedTitle_log";
            this.filesExplainedTitle_log.Size = new System.Drawing.Size(53, 19);
            this.filesExplainedTitle_log.TabIndex = 22;
            this.filesExplainedTitle_log.Text = "log.txt";
            // 
            // filesExplainedText_log
            // 
            this.filesExplainedText_log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filesExplainedText_log.AutoSize = true;
            this.filesExplainedText_log.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesExplainedText_log.Location = new System.Drawing.Point(15, 108);
            this.filesExplainedText_log.Name = "filesExplainedText_log";
            this.filesExplainedText_log.Size = new System.Drawing.Size(467, 38);
            this.filesExplainedText_log.TabIndex = 25;
            this.filesExplainedText_log.Text = "קובץ ה\"לוג\" של התוכנה. ניתן לשנות את מיקום הקובץ בהגדרות *ניתן למחוק, יווצר כול פ" +
    "עם מחדש. מכיל נתונים סטטיסטים על המערכת, לניטור בעיות.";
            // 
            // filesExplainedText_db
            // 
            this.filesExplainedText_db.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filesExplainedText_db.AutoSize = true;
            this.filesExplainedText_db.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesExplainedText_db.Location = new System.Drawing.Point(12, 57);
            this.filesExplainedText_db.Name = "filesExplainedText_db";
            this.filesExplainedText_db.Size = new System.Drawing.Size(473, 38);
            this.filesExplainedText_db.TabIndex = 24;
            this.filesExplainedText_db.Text = "מסד-הנתונים של התוכנה. ניתן לשנות את מיקום הקובץ בהגדרות. *אין למחוק, מכיל את כול" +
    " המידע.";
            // 
            // filesExplainedText
            // 
            this.filesExplainedText.AutoSize = true;
            this.filesExplainedText.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesExplainedText.Location = new System.Drawing.Point(18, 178);
            this.filesExplainedText.Name = "filesExplainedText";
            this.filesExplainedText.Size = new System.Drawing.Size(280, 28);
            this.filesExplainedText.TabIndex = 20;
            this.filesExplainedText.Text = "המערכת משתמשת ב-3 קבצים:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.filesExplainedText);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.filesExplainedTitle);
            this.Controls.Add(this.version);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mainTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = " רשמצ1 - נעם מערכות\"ש - חתומוזס 2021 © | גרסה 1.1 | הגדרות";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(Settings_Close);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button chooseFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label folderLocation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button saveItem;
        private System.Windows.Forms.Button cancelEdit;
        private System.Windows.Forms.Label credits;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label filesExplainedTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label filesExplainedTitle_settings;
        private System.Windows.Forms.Label filesExplainedText_log;
        private System.Windows.Forms.Label filesExplainedText_db;
        private System.Windows.Forms.Label filesExplainedText_settings;
        private System.Windows.Forms.Label filesExplainedTitle_db;
        private System.Windows.Forms.Label filesExplainedTitle_log;
        private System.Windows.Forms.Label filesExplainedText;
    }
}