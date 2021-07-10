namespace Rashmatz1 {
    partial class mainWin {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWin));
            this.mainTitle = new System.Windows.Forms.Label();
            this.mainListView = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMakat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMakatFactory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSign = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelDebug = new System.Windows.Forms.Label();
            this.debugButton = new System.Windows.Forms.Button();
            this.newItemButton = new System.Windows.Forms.Button();
            this.infoInstruction = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.whatsNew = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(0, 0);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.mainTitle.Size = new System.Drawing.Size(1184, 50);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "רשמ\"צ1";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainListView
            // 
            this.mainListView.AllowColumnReorder = true;
            this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnName,
            this.columnDesc,
            this.columnCount,
            this.columnMakat,
            this.columnMakatFactory,
            this.columnLocation,
            this.columnComments,
            this.columnSign});
            this.mainListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.mainListView.FullRowSelect = true;
            this.mainListView.HideSelection = false;
            this.mainListView.Location = new System.Drawing.Point(12, 131);
            this.mainListView.MultiSelect = false;
            this.mainListView.Name = "mainListView";
            this.mainListView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainListView.RightToLeftLayout = true;
            this.mainListView.Size = new System.Drawing.Size(1160, 616);
            this.mainListView.TabIndex = 4;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.View = System.Windows.Forms.View.Details;
            this.mainListView.DoubleClick += new System.EventHandler(this.mainList_DoubleClick);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 100;
            // 
            // columnName
            // 
            this.columnName.Text = "שם";
            this.columnName.Width = 120;
            // 
            // columnDesc
            // 
            this.columnDesc.Text = "תיאור";
            this.columnDesc.Width = 300;
            // 
            // columnCount
            // 
            this.columnCount.Text = "מלאי";
            this.columnCount.Width = 80;
            // 
            // columnMakat
            // 
            this.columnMakat.Text = "מק\"ט";
            this.columnMakat.Width = 100;
            // 
            // columnMakatFactory
            // 
            this.columnMakatFactory.Text = "מק\"ט יצרן";
            this.columnMakatFactory.Width = 100;
            // 
            // columnLocation
            // 
            this.columnLocation.Text = "מיקום";
            this.columnLocation.Width = 100;
            // 
            // columnComments
            // 
            this.columnComments.Text = "הערות";
            this.columnComments.Width = 150;
            // 
            // columnSign
            // 
            this.columnSign.Text = "מי חתום";
            this.columnSign.Width = 100;
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDebug.Location = new System.Drawing.Point(92, 63);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(59, 13);
            this.labelDebug.TabIndex = 2;
            this.labelDebug.Text = "Debugging";
            this.labelDebug.Visible = false;
            // 
            // debugButton
            // 
            this.debugButton.Location = new System.Drawing.Point(157, 53);
            this.debugButton.Name = "debugButton";
            this.debugButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.debugButton.Size = new System.Drawing.Size(104, 23);
            this.debugButton.TabIndex = 3;
            this.debugButton.Text = "Debugging button";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Visible = false;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // newItemButton
            // 
            this.newItemButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.newItemButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newItemButton.ForeColor = System.Drawing.Color.White;
            this.newItemButton.Location = new System.Drawing.Point(784, 23);
            this.newItemButton.Name = "newItemButton";
            this.newItemButton.Size = new System.Drawing.Size(150, 80);
            this.newItemButton.TabIndex = 1;
            this.newItemButton.Text = "פריט חדש";
            this.newItemButton.UseVisualStyleBackColor = false;
            this.newItemButton.Click += new System.EventHandler(this.newItem_Click);
            // 
            // infoInstruction
            // 
            this.infoInstruction.AutoSize = true;
            this.infoInstruction.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoInstruction.Location = new System.Drawing.Point(12, 115);
            this.infoInstruction.Name = "infoInstruction";
            this.infoInstruction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.infoInstruction.Size = new System.Drawing.Size(244, 13);
            this.infoInstruction.TabIndex = 11;
            this.infoInstruction.Text = "* לחיצה כפולה על פריט על מנת לפתוח חלון עריכה";
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.RoyalBlue;
            this.about.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.ForeColor = System.Drawing.Color.White;
            this.about.Location = new System.Drawing.Point(542, 754);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(100, 50);
            this.about.TabIndex = 3;
            this.about.Text = "על החברה והתוכנה";
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(9, 786);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(47, 19);
            this.version.TabIndex = 15;
            this.version.Text = "verion";
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.CadetBlue;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(960, 23);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(150, 80);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.Text = "הגדרות";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // whatsNew
            // 
            this.whatsNew.AutoSize = true;
            this.whatsNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.whatsNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatsNew.ForeColor = System.Drawing.Color.Blue;
            this.whatsNew.Location = new System.Drawing.Point(192, 786);
            this.whatsNew.Name = "whatsNew";
            this.whatsNew.Size = new System.Drawing.Size(64, 19);
            this.whatsNew.TabIndex = 18;
            this.whatsNew.Text = "מה חדש?";
            this.whatsNew.Click += new System.EventHandler(this.whatsNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rashmatz1.Properties.Resources.credits_noBG;
            this.pictureBox1.Location = new System.Drawing.Point(586, 765);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 43);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // subTitle
            // 
            this.subTitle.AutoSize = true;
            this.subTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitle.Location = new System.Drawing.Point(522, 59);
            this.subTitle.Name = "subTitle";
            this.subTitle.Size = new System.Drawing.Size(143, 19);
            this.subTitle.TabIndex = 19;
            this.subTitle.Text = "מערכת לניהול רשמ\"צ";
            // 
            // mainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 811);
            this.Controls.Add(this.subTitle);
            this.Controls.Add(this.whatsNew);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.version);
            this.Controls.Add(this.about);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.infoInstruction);
            this.Controls.Add(this.newItemButton);
            this.Controls.Add(this.debugButton);
            this.Controls.Add(this.labelDebug);
            this.Controls.Add(this.mainListView);
            this.Controls.Add(this.mainTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainWin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "רשמצ1 | נעם מערכות\"ש | חתומוזס 2021 © | גרסה 1.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainWin_Close);
            this.Load += new System.EventHandler(this.mainWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.ListView mainListView;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDesc;
        private System.Windows.Forms.ColumnHeader columnMakat;
        private System.Windows.Forms.ColumnHeader columnCount;
        private System.Windows.Forms.ColumnHeader columnComments;
        private System.Windows.Forms.ColumnHeader columnLocation;
        private System.Windows.Forms.ColumnHeader columnSign;
        private System.Windows.Forms.ColumnHeader columnMakatFactory;
        private System.Windows.Forms.Label labelDebug;
        private System.Windows.Forms.Button debugButton;
        private System.Windows.Forms.Button newItemButton;
        private System.Windows.Forms.Label infoInstruction;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label whatsNew;
        private System.Windows.Forms.Label subTitle;
    }
}

