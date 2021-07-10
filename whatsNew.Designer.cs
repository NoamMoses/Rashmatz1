namespace Rashmatz1 {
    partial class whatsNew {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(whatsNew));
            this.mainTitle = new System.Windows.Forms.Label();
            this.version1_0 = new System.Windows.Forms.RadioButton();
            this.versionsTitle = new System.Windows.Forms.Label();
            this.version1_1 = new System.Windows.Forms.RadioButton();
            this.versionsButtonsGroup = new System.Windows.Forms.Panel();
            this.whatsNewText = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.credits = new System.Windows.Forms.Label();
            this.versionsButtonsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(0, 0);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.mainTitle.Size = new System.Drawing.Size(834, 50);
            this.mainTitle.TabIndex = 2;
            this.mainTitle.Text = "מה חדש?";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // version1_0
            // 
            this.version1_0.AutoSize = true;
            this.version1_0.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version1_0.Location = new System.Drawing.Point(157, 5);
            this.version1_0.Name = "version1_0";
            this.version1_0.Size = new System.Drawing.Size(46, 23);
            this.version1_0.TabIndex = 3;
            this.version1_0.Text = "1.0";
            this.version1_0.UseVisualStyleBackColor = true;
            this.version1_0.CheckedChanged += new System.EventHandler(this.versions_CheckedChanged);
            // 
            // versionsTitle
            // 
            this.versionsTitle.AutoSize = true;
            this.versionsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionsTitle.Location = new System.Drawing.Point(2, 44);
            this.versionsTitle.Name = "versionsTitle";
            this.versionsTitle.Size = new System.Drawing.Size(100, 21);
            this.versionsTitle.TabIndex = 4;
            this.versionsTitle.Text = "בחירת גרסה:";
            // 
            // version1_1
            // 
            this.version1_1.AutoSize = true;
            this.version1_1.Checked = true;
            this.version1_1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version1_1.Location = new System.Drawing.Point(157, 28);
            this.version1_1.Name = "version1_1";
            this.version1_1.Size = new System.Drawing.Size(46, 23);
            this.version1_1.TabIndex = 5;
            this.version1_1.TabStop = true;
            this.version1_1.Text = "1.1";
            this.version1_1.UseVisualStyleBackColor = true;
            this.version1_1.CheckedChanged += new System.EventHandler(this.versions_CheckedChanged);
            // 
            // versionsButtonsGroup
            // 
            this.versionsButtonsGroup.Controls.Add(this.version1_0);
            this.versionsButtonsGroup.Controls.Add(this.version1_1);
            this.versionsButtonsGroup.Location = new System.Drawing.Point(6, 68);
            this.versionsButtonsGroup.Name = "versionsButtonsGroup";
            this.versionsButtonsGroup.Size = new System.Drawing.Size(209, 52);
            this.versionsButtonsGroup.TabIndex = 7;
            // 
            // whatsNewText
            // 
            this.whatsNewText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatsNewText.Location = new System.Drawing.Point(205, 127);
            this.whatsNewText.Name = "whatsNewText";
            this.whatsNewText.Size = new System.Drawing.Size(425, 230);
            this.whatsNewText.TabIndex = 8;
            this.whatsNewText.Text = "מה חדש";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(4, 390);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(47, 19);
            this.version.TabIndex = 19;
            this.version.Text = "verion";
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits.Location = new System.Drawing.Point(526, 390);
            this.credits.Name = "credits";
            this.credits.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.credits.Size = new System.Drawing.Size(300, 19);
            this.credits.TabIndex = 18;
            this.credits.Text = "פותח על-ידי נעם מערכות\"ש.    חתומוזס 2021 ©";
            // 
            // whatsNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.version);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.whatsNewText);
            this.Controls.Add(this.versionsButtonsGroup);
            this.Controls.Add(this.versionsTitle);
            this.Controls.Add(this.mainTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "whatsNew";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = " רשמצ1 - נעם מערכות\"ש - חתומוזס 2021 © | גרסה 1.1 | מה חדש?";
            this.Load += new System.EventHandler(this.whatsNew_Load);
            this.versionsButtonsGroup.ResumeLayout(false);
            this.versionsButtonsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.RadioButton version1_0;
        private System.Windows.Forms.Label versionsTitle;
        private System.Windows.Forms.RadioButton version1_1;
        private System.Windows.Forms.Panel versionsButtonsGroup;
        private System.Windows.Forms.Label whatsNewText;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label credits;
    }
}