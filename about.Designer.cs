namespace Rashmatz1 {
    partial class about {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
            this.mainTitle = new System.Windows.Forms.Label();
            this.credits = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.bottomText = new System.Windows.Forms.PictureBox();
            this.mainText = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bottomText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainText)).BeginInit();
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
            this.mainTitle.TabIndex = 1;
            this.mainTitle.Text = "רשמ\"צ1";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits.Location = new System.Drawing.Point(535, 574);
            this.credits.Name = "credits";
            this.credits.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.credits.Size = new System.Drawing.Size(72, 28);
            this.credits.TabIndex = 12;
            this.credits.Text = "credits";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(3, 585);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(47, 17);
            this.version.TabIndex = 17;
            this.version.Text = "verion";
            // 
            // bottomText
            // 
            this.bottomText.Image = global::Rashmatz1.Properties.Resources.help_noBG;
            this.bottomText.Location = new System.Drawing.Point(12, 502);
            this.bottomText.Name = "bottomText";
            this.bottomText.Size = new System.Drawing.Size(774, 69);
            this.bottomText.TabIndex = 3;
            this.bottomText.TabStop = false;
            // 
            // mainText
            // 
            this.mainText.Image = ((System.Drawing.Image)(resources.GetObject("mainText.Image")));
            this.mainText.Location = new System.Drawing.Point(12, 74);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(960, 393);
            this.mainText.TabIndex = 2;
            this.mainText.TabStop = false;
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.version);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.bottomText);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.mainTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "about";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = " רשמצ1 - נעם מערכות\"ש - חתומוזס 2021 © | גרסה 1.1 | על החברה והתוכנה";
            this.Load += new System.EventHandler(this.about_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bottomText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.PictureBox bottomText;
        private System.Windows.Forms.Label credits;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.PictureBox mainText;
    }
}