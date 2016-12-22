namespace GridList
{
    partial class ContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.researchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mApsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.employmentTitle = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackgroundImage = global::GridList.Properties.Resources.orangeDark;
            this.mainMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainMenuStrip.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.degreeToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.employmentToolStripMenuItem,
            this.researchToolStripMenuItem,
            this.mApsToolStripMenuItem,
            this.contactFormToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(884, 32);
            this.mainMenuStrip.TabIndex = 23;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(73, 28);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // degreeToolStripMenuItem
            // 
            this.degreeToolStripMenuItem.Name = "degreeToolStripMenuItem";
            this.degreeToolStripMenuItem.Size = new System.Drawing.Size(85, 28);
            this.degreeToolStripMenuItem.Text = "Degree";
            this.degreeToolStripMenuItem.Click += new System.EventHandler(this.degreeToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(82, 28);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // employmentToolStripMenuItem
            // 
            this.employmentToolStripMenuItem.Name = "employmentToolStripMenuItem";
            this.employmentToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.employmentToolStripMenuItem.Text = "Employment";
            this.employmentToolStripMenuItem.Click += new System.EventHandler(this.employmentToolStripMenuItem_Click);
            // 
            // researchToolStripMenuItem
            // 
            this.researchToolStripMenuItem.Name = "researchToolStripMenuItem";
            this.researchToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.researchToolStripMenuItem.Text = "Research";
            this.researchToolStripMenuItem.Click += new System.EventHandler(this.researchToolStripMenuItem_Click);
            // 
            // mApsToolStripMenuItem
            // 
            this.mApsToolStripMenuItem.Name = "mApsToolStripMenuItem";
            this.mApsToolStripMenuItem.Size = new System.Drawing.Size(65, 28);
            this.mApsToolStripMenuItem.Text = "Maps";
            this.mApsToolStripMenuItem.Click += new System.EventHandler(this.mApsToolStripMenuItem_Click);
            // 
            // contactFormToolStripMenuItem
            // 
            this.contactFormToolStripMenuItem.Name = "contactFormToolStripMenuItem";
            this.contactFormToolStripMenuItem.Size = new System.Drawing.Size(143, 28);
            this.contactFormToolStripMenuItem.Text = "Contact Form";
            this.contactFormToolStripMenuItem.Click += new System.EventHandler(this.contactFormToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser2);
            this.panel1.Location = new System.Drawing.Point(54, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 399);
            this.panel1.TabIndex = 24;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(0, 0);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScriptErrorsSuppressed = true;
            this.webBrowser2.Size = new System.Drawing.Size(778, 399);
            this.webBrowser2.TabIndex = 0;
            // 
            // employmentTitle
            // 
            this.employmentTitle.AutoSize = true;
            this.employmentTitle.BackColor = System.Drawing.Color.Transparent;
            this.employmentTitle.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employmentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.employmentTitle.Location = new System.Drawing.Point(326, 59);
            this.employmentTitle.Name = "employmentTitle";
            this.employmentTitle.Size = new System.Drawing.Size(151, 35);
            this.employmentTitle.TabIndex = 27;
            this.employmentTitle.Text = "Contact Us";
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GridList.Properties.Resources.mainBackImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.employmentTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactForm";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem degreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem researchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mApsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactFormToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label employmentTitle;
        private System.Windows.Forms.WebBrowser webBrowser2;
    }
}