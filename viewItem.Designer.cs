namespace Rashmatz1 {
    partial class viewItem {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewItem));
            this.mainTitle = new System.Windows.Forms.Label();
            this.mainList = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMakat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMakatFactory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSign = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteItem = new System.Windows.Forms.Button();
            this.editFields_IDTitle = new System.Windows.Forms.Label();
            this.editFields_nameTitle = new System.Windows.Forms.Label();
            this.editFields_descTitle = new System.Windows.Forms.Label();
            this.editFields_countTitle = new System.Windows.Forms.Label();
            this.editFields_nameInput = new System.Windows.Forms.TextBox();
            this.editFields_descInput = new System.Windows.Forms.TextBox();
            this.editFields_countInput = new System.Windows.Forms.NumericUpDown();
            this.editFields_makatTitle = new System.Windows.Forms.Label();
            this.editFields_makatFactoryTitle = new System.Windows.Forms.Label();
            this.editFields_locationTitle = new System.Windows.Forms.Label();
            this.editFields_makatFactoryInput = new System.Windows.Forms.TextBox();
            this.editFields_locatiomInput = new System.Windows.Forms.TextBox();
            this.editFields_makatInput = new System.Windows.Forms.TextBox();
            this.editFields_commentsInput = new System.Windows.Forms.TextBox();
            this.editFields_commentsTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.editFields_IDinput = new System.Windows.Forms.TextBox();
            this.saveItem = new System.Windows.Forms.Button();
            this.editFields_signTitle = new System.Windows.Forms.Label();
            this.editFields_signInput = new System.Windows.Forms.TextBox();
            this.inputsTable = new System.Windows.Forms.TableLayoutPanel();
            this.cancelEdit = new System.Windows.Forms.Button();
            this.credits = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.version = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.createdOn_Title = new System.Windows.Forms.Label();
            this.updatedOn_Title = new System.Windows.Forms.Label();
            this.createdOn_Value = new System.Windows.Forms.Label();
            this.updatedOn_Value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.editFields_countInput)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.inputsTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "רשמ\"צ1 | ";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainList
            // 
            this.mainList.AllowColumnReorder = true;
            this.mainList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnName,
            this.columnDesc,
            this.columnCount,
            this.columnMakat,
            this.columnMakatFactory,
            this.columnLocation,
            this.columnComments,
            this.columnSign});
            this.mainList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.mainList.FullRowSelect = true;
            this.mainList.HideSelection = false;
            this.mainList.Location = new System.Drawing.Point(9, 53);
            this.mainList.MultiSelect = false;
            this.mainList.Name = "mainList";
            this.mainList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainList.RightToLeftLayout = true;
            this.mainList.Size = new System.Drawing.Size(966, 93);
            this.mainList.TabIndex = 2;
            this.mainList.TabStop = false;
            this.mainList.UseCompatibleStateImageBehavior = false;
            this.mainList.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 100;
            // 
            // columnName
            // 
            this.columnName.Text = "שם";
            this.columnName.Width = 110;
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
            this.columnSign.Width = 150;
            // 
            // deleteItem
            // 
            this.deleteItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteItem.BackColor = System.Drawing.Color.Crimson;
            this.deleteItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItem.ForeColor = System.Drawing.Color.White;
            this.deleteItem.Location = new System.Drawing.Point(17, 10);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(150, 80);
            this.deleteItem.TabIndex = 0;
            this.deleteItem.TabStop = false;
            this.deleteItem.Text = "מחק";
            this.deleteItem.UseVisualStyleBackColor = false;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // editFields_IDTitle
            // 
            this.editFields_IDTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_IDTitle.AutoSize = true;
            this.editFields_IDTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_IDTitle.Location = new System.Drawing.Point(847, 20);
            this.editFields_IDTitle.Name = "editFields_IDTitle";
            this.editFields_IDTitle.Size = new System.Drawing.Size(31, 28);
            this.editFields_IDTitle.TabIndex = 0;
            this.editFields_IDTitle.Text = "ID";
            // 
            // editFields_nameTitle
            // 
            this.editFields_nameTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_nameTitle.AutoSize = true;
            this.editFields_nameTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_nameTitle.Location = new System.Drawing.Point(893, 16);
            this.editFields_nameTitle.Name = "editFields_nameTitle";
            this.editFields_nameTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editFields_nameTitle.Size = new System.Drawing.Size(50, 28);
            this.editFields_nameTitle.TabIndex = 1;
            this.editFields_nameTitle.Text = "שם*";
            this.editFields_nameTitle.Click += new System.EventHandler(this.editFields_nameTitle_Click);
            // 
            // editFields_descTitle
            // 
            this.editFields_descTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_descTitle.AutoSize = true;
            this.editFields_descTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_descTitle.Location = new System.Drawing.Point(888, 78);
            this.editFields_descTitle.Name = "editFields_descTitle";
            this.editFields_descTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editFields_descTitle.Size = new System.Drawing.Size(61, 28);
            this.editFields_descTitle.TabIndex = 2;
            this.editFields_descTitle.Text = "תיאור";
            this.editFields_descTitle.Click += new System.EventHandler(this.editFields_descTitle_Click);
            // 
            // editFields_countTitle
            // 
            this.editFields_countTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_countTitle.AutoSize = true;
            this.editFields_countTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_countTitle.Location = new System.Drawing.Point(28, 314);
            this.editFields_countTitle.Name = "editFields_countTitle";
            this.editFields_countTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editFields_countTitle.Size = new System.Drawing.Size(54, 28);
            this.editFields_countTitle.TabIndex = 3;
            this.editFields_countTitle.Text = "מלאי";
            this.editFields_countTitle.Click += new System.EventHandler(this.editFields_countTitle_Click);
            // 
            // editFields_nameInput
            // 
            this.editFields_nameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_nameInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_nameInput.Location = new System.Drawing.Point(640, 13);
            this.editFields_nameInput.Name = "editFields_nameInput";
            this.editFields_nameInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editFields_nameInput.Size = new System.Drawing.Size(220, 34);
            this.editFields_nameInput.TabIndex = 0;
            // 
            // editFields_descInput
            // 
            this.editFields_descInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_descInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_descInput.Location = new System.Drawing.Point(640, 75);
            this.editFields_descInput.Name = "editFields_descInput";
            this.editFields_descInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editFields_descInput.Size = new System.Drawing.Size(220, 34);
            this.editFields_descInput.TabIndex = 1;
            // 
            // editFields_countInput
            // 
            this.editFields_countInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_countInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_countInput.Location = new System.Drawing.Point(84, 312);
            this.editFields_countInput.Name = "editFields_countInput";
            this.editFields_countInput.Size = new System.Drawing.Size(39, 30);
            this.editFields_countInput.TabIndex = 6;
            // 
            // editFields_makatTitle
            // 
            this.editFields_makatTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_makatTitle.AutoSize = true;
            this.editFields_makatTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_makatTitle.Location = new System.Drawing.Point(546, 16);
            this.editFields_makatTitle.Name = "editFields_makatTitle";
            this.editFields_makatTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editFields_makatTitle.Size = new System.Drawing.Size(60, 28);
            this.editFields_makatTitle.TabIndex = 0;
            this.editFields_makatTitle.Text = "מק\"ט";
            this.editFields_makatTitle.Click += new System.EventHandler(this.editFields_makatTitle_Click);
            // 
            // editFields_makatFactoryTitle
            // 
            this.editFields_makatFactoryTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_makatFactoryTitle.AutoSize = true;
            this.editFields_makatFactoryTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_makatFactoryTitle.Location = new System.Drawing.Point(527, 78);
            this.editFields_makatFactoryTitle.Name = "editFields_makatFactoryTitle";
            this.editFields_makatFactoryTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editFields_makatFactoryTitle.Size = new System.Drawing.Size(98, 28);
            this.editFields_makatFactoryTitle.TabIndex = 1;
            this.editFields_makatFactoryTitle.Text = "מק\"ט יצרן";
            this.editFields_makatFactoryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editFields_makatFactoryTitle.Click += new System.EventHandler(this.editFields_makatFactoryTitle_Click);
            // 
            // editFields_locationTitle
            // 
            this.editFields_locationTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_locationTitle.AutoSize = true;
            this.editFields_locationTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_locationTitle.Location = new System.Drawing.Point(261, 16);
            this.editFields_locationTitle.Name = "editFields_locationTitle";
            this.editFields_locationTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editFields_locationTitle.Size = new System.Drawing.Size(62, 28);
            this.editFields_locationTitle.TabIndex = 2;
            this.editFields_locationTitle.Text = "מיקום";
            this.editFields_locationTitle.Click += new System.EventHandler(this.editFields_locationTitle_Click);
            // 
            // editFields_makatFactoryInput
            // 
            this.editFields_makatFactoryInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_makatFactoryInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_makatFactoryInput.Location = new System.Drawing.Point(343, 75);
            this.editFields_makatFactoryInput.Name = "editFields_makatFactoryInput";
            this.editFields_makatFactoryInput.Size = new System.Drawing.Size(177, 34);
            this.editFields_makatFactoryInput.TabIndex = 3;
            this.editFields_makatFactoryInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editFields_locatiomInput
            // 
            this.editFields_locatiomInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_locatiomInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_locatiomInput.Location = new System.Drawing.Point(12, 13);
            this.editFields_locatiomInput.Name = "editFields_locatiomInput";
            this.editFields_locatiomInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editFields_locatiomInput.Size = new System.Drawing.Size(220, 34);
            this.editFields_locatiomInput.TabIndex = 4;
            // 
            // editFields_makatInput
            // 
            this.editFields_makatInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_makatInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_makatInput.Location = new System.Drawing.Point(343, 13);
            this.editFields_makatInput.Name = "editFields_makatInput";
            this.editFields_makatInput.Size = new System.Drawing.Size(177, 34);
            this.editFields_makatInput.TabIndex = 2;
            this.editFields_makatInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editFields_commentsInput
            // 
            this.editFields_commentsInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_commentsInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_commentsInput.Location = new System.Drawing.Point(10, 48);
            this.editFields_commentsInput.Multiline = true;
            this.editFields_commentsInput.Name = "editFields_commentsInput";
            this.editFields_commentsInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editFields_commentsInput.Size = new System.Drawing.Size(283, 151);
            this.editFields_commentsInput.TabIndex = 7;
            this.editFields_commentsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // editFields_commentsTitle
            // 
            this.editFields_commentsTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_commentsTitle.AutoSize = true;
            this.editFields_commentsTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_commentsTitle.Location = new System.Drawing.Point(117, 6);
            this.editFields_commentsTitle.Name = "editFields_commentsTitle";
            this.editFields_commentsTitle.Size = new System.Drawing.Size(69, 28);
            this.editFields_commentsTitle.TabIndex = 7;
            this.editFields_commentsTitle.Text = "הערות";
            this.editFields_commentsTitle.Click += new System.EventHandler(this.editFields_commentsTitle_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.editFields_commentsTitle, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.editFields_commentsInput, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 341);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(303, 207);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // editFields_IDinput
            // 
            this.editFields_IDinput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_IDinput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.editFields_IDinput.Enabled = false;
            this.editFields_IDinput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_IDinput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.editFields_IDinput.Location = new System.Drawing.Point(884, 17);
            this.editFields_IDinput.Name = "editFields_IDinput";
            this.editFields_IDinput.Size = new System.Drawing.Size(88, 34);
            this.editFields_IDinput.TabIndex = 0;
            this.editFields_IDinput.TabStop = false;
            this.editFields_IDinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveItem
            // 
            this.saveItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.saveItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveItem.ForeColor = System.Drawing.Color.White;
            this.saveItem.Location = new System.Drawing.Point(200, 10);
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(150, 80);
            this.saveItem.TabIndex = 0;
            this.saveItem.TabStop = false;
            this.saveItem.Text = "שמור";
            this.saveItem.UseVisualStyleBackColor = false;
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // editFields_signTitle
            // 
            this.editFields_signTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_signTitle.AutoSize = true;
            this.editFields_signTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_signTitle.Location = new System.Drawing.Point(251, 78);
            this.editFields_signTitle.Name = "editFields_signTitle";
            this.editFields_signTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editFields_signTitle.Size = new System.Drawing.Size(82, 28);
            this.editFields_signTitle.TabIndex = 6;
            this.editFields_signTitle.Text = "מי חתום";
            this.editFields_signTitle.Click += new System.EventHandler(this.editFields_signTitle_Click);
            // 
            // editFields_signInput
            // 
            this.editFields_signInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFields_signInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFields_signInput.Location = new System.Drawing.Point(12, 75);
            this.editFields_signInput.Name = "editFields_signInput";
            this.editFields_signInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editFields_signInput.Size = new System.Drawing.Size(220, 34);
            this.editFields_signInput.TabIndex = 5;
            // 
            // inputsTable
            // 
            this.inputsTable.ColumnCount = 6;
            this.inputsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inputsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inputsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.inputsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.inputsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inputsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inputsTable.Controls.Add(this.editFields_locatiomInput, 5, 0);
            this.inputsTable.Controls.Add(this.editFields_locationTitle, 4, 0);
            this.inputsTable.Controls.Add(this.editFields_nameTitle, 0, 0);
            this.inputsTable.Controls.Add(this.editFields_descTitle, 0, 1);
            this.inputsTable.Controls.Add(this.editFields_signTitle, 4, 1);
            this.inputsTable.Controls.Add(this.editFields_makatFactoryInput, 3, 1);
            this.inputsTable.Controls.Add(this.editFields_signInput, 5, 1);
            this.inputsTable.Controls.Add(this.editFields_nameInput, 1, 0);
            this.inputsTable.Controls.Add(this.editFields_descInput, 1, 1);
            this.inputsTable.Controls.Add(this.editFields_makatTitle, 2, 0);
            this.inputsTable.Controls.Add(this.editFields_makatInput, 3, 0);
            this.inputsTable.Controls.Add(this.editFields_makatFactoryTitle, 2, 1);
            this.inputsTable.Location = new System.Drawing.Point(9, 152);
            this.inputsTable.Name = "inputsTable";
            this.inputsTable.RowCount = 2;
            this.inputsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inputsTable.Size = new System.Drawing.Size(966, 123);
            this.inputsTable.TabIndex = 10;
            // 
            // cancelEdit
            // 
            this.cancelEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelEdit.BackColor = System.Drawing.Color.DarkSalmon;
            this.cancelEdit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelEdit.ForeColor = System.Drawing.Color.White;
            this.cancelEdit.Location = new System.Drawing.Point(382, 10);
            this.cancelEdit.Name = "cancelEdit";
            this.cancelEdit.Size = new System.Drawing.Size(150, 80);
            this.cancelEdit.TabIndex = 0;
            this.cancelEdit.TabStop = false;
            this.cancelEdit.Text = "בטל";
            this.cancelEdit.UseVisualStyleBackColor = false;
            this.cancelEdit.Click += new System.EventHandler(this.cancelEdit_Click);
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits.Location = new System.Drawing.Point(672, 540);
            this.credits.Name = "credits";
            this.credits.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.credits.Size = new System.Drawing.Size(51, 19);
            this.credits.TabIndex = 11;
            this.credits.Text = "credits";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.deleteItem, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveItem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelEdit, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(424, 414);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(548, 100);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(6, 540);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(47, 19);
            this.version.TabIndex = 16;
            this.version.Text = "verion";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel2.Controls.Add(this.createdOn_Title, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.createdOn_Value, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.updatedOn_Value, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.updatedOn_Title, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(696, 281);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(279, 61);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // createdOn_Title
            // 
            this.createdOn_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createdOn_Title.AutoSize = true;
            this.createdOn_Title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdOn_Title.Location = new System.Drawing.Point(215, 1);
            this.createdOn_Title.Name = "createdOn_Title";
            this.createdOn_Title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.createdOn_Title.Size = new System.Drawing.Size(52, 28);
            this.createdOn_Title.TabIndex = 18;
            this.createdOn_Title.Text = "נוצר:";
            // 
            // updatedOn_Title
            // 
            this.updatedOn_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updatedOn_Title.AutoSize = true;
            this.updatedOn_Title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedOn_Title.Location = new System.Drawing.Point(212, 31);
            this.updatedOn_Title.Name = "updatedOn_Title";
            this.updatedOn_Title.Size = new System.Drawing.Size(59, 28);
            this.updatedOn_Title.TabIndex = 19;
            this.updatedOn_Title.Text = "עודכן:";
            // 
            // createdOn_Value
            // 
            this.createdOn_Value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createdOn_Value.AutoSize = true;
            this.createdOn_Value.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdOn_Value.Location = new System.Drawing.Point(48, 1);
            this.createdOn_Value.Name = "createdOn_Value";
            this.createdOn_Value.Size = new System.Drawing.Size(108, 28);
            this.createdOn_Value.TabIndex = 20;
            this.createdOn_Value.Text = "טקסט נוצר";
            // 
            // updatedOn_Value
            // 
            this.updatedOn_Value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updatedOn_Value.AutoSize = true;
            this.updatedOn_Value.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedOn_Value.Location = new System.Drawing.Point(102, 31);
            this.updatedOn_Value.Name = "updatedOn_Value";
            this.updatedOn_Value.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.updatedOn_Value.Size = new System.Drawing.Size(0, 28);
            this.updatedOn_Value.TabIndex = 21;
            // 
            // viewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.version);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.inputsTable);
            this.Controls.Add(this.editFields_countTitle);
            this.Controls.Add(this.editFields_IDinput);
            this.Controls.Add(this.editFields_countInput);
            this.Controls.Add(this.editFields_IDTitle);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.mainList);
            this.Controls.Add(this.mainTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "viewItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "רשמצ1 - נעם מערכות\"ש - חתומוזס 2021 © | ";
            this.Load += new System.EventHandler(this.viewItem_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(viewItem_Close);
            ((System.ComponentModel.ISupportInitialize)(this.editFields_countInput)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.inputsTable.ResumeLayout(false);
            this.inputsTable.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.ListView mainList;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDesc;
        private System.Windows.Forms.ColumnHeader columnCount;
        private System.Windows.Forms.ColumnHeader columnMakat;
        private System.Windows.Forms.ColumnHeader columnMakatFactory;
        private System.Windows.Forms.ColumnHeader columnLocation;
        private System.Windows.Forms.ColumnHeader columnComments;
        private System.Windows.Forms.ColumnHeader columnSign;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.Label editFields_IDTitle;
        private System.Windows.Forms.Label editFields_nameTitle;
        private System.Windows.Forms.Label editFields_descTitle;
        private System.Windows.Forms.Label editFields_countTitle;
        private System.Windows.Forms.TextBox editFields_nameInput;
        private System.Windows.Forms.TextBox editFields_descInput;
        private System.Windows.Forms.NumericUpDown editFields_countInput;
        private System.Windows.Forms.Label editFields_makatTitle;
        private System.Windows.Forms.Label editFields_makatFactoryTitle;
        private System.Windows.Forms.Label editFields_locationTitle;
        private System.Windows.Forms.TextBox editFields_locatiomInput;
        private System.Windows.Forms.TextBox editFields_makatFactoryInput;
        private System.Windows.Forms.TextBox editFields_makatInput;
        private System.Windows.Forms.TextBox editFields_commentsInput;
        private System.Windows.Forms.Label editFields_commentsTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox editFields_IDinput;
        private System.Windows.Forms.Button saveItem;
        private System.Windows.Forms.Label editFields_signTitle;
        private System.Windows.Forms.TextBox editFields_signInput;
        private System.Windows.Forms.TableLayoutPanel inputsTable;
        private System.Windows.Forms.Button cancelEdit;
        private System.Windows.Forms.Label credits;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label createdOn_Title;
        private System.Windows.Forms.Label updatedOn_Title;
        private System.Windows.Forms.Label createdOn_Value;
        private System.Windows.Forms.Label updatedOn_Value;
    }
}