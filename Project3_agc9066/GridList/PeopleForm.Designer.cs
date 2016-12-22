namespace GridList
{
    partial class PeopleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleForm));
            this.people_title = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.facultyList = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.staffList = new System.Windows.Forms.ListView();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mApsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.researchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // people_title
            // 
            this.people_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.people_title.AutoSize = true;
            this.people_title.BackColor = System.Drawing.Color.Transparent;
            this.people_title.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.people_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.people_title.Location = new System.Drawing.Point(355, 55);
            this.people_title.Name = "people_title";
            this.people_title.Size = new System.Drawing.Size(93, 35);
            this.people_title.TabIndex = 0;
            this.people_title.Text = "label1";
            this.people_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(56, 104);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 408);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.facultyList);
            this.tabPage1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Purple;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(758, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "";
            this.tabPage1.Text = "Faculty";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // facultyList
            // 
            this.facultyList.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyList.ForeColor = System.Drawing.Color.Purple;
            this.facultyList.GridLines = true;
            this.facultyList.Location = new System.Drawing.Point(17, 14);
            this.facultyList.Name = "facultyList";
            this.facultyList.ShowItemToolTips = true;
            this.facultyList.Size = new System.Drawing.Size(720, 277);
            this.facultyList.TabIndex = 0;
            this.facultyList.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.staffList);
            this.tabPage2.ForeColor = System.Drawing.Color.Purple;
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(758, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Staff";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // staffList
            // 
            this.staffList.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffList.ForeColor = System.Drawing.Color.Purple;
            this.staffList.GridLines = true;
            this.staffList.Location = new System.Drawing.Point(54, 47);
            this.staffList.Name = "staffList";
            this.staffList.ShowItemToolTips = true;
            this.staffList.Size = new System.Drawing.Size(646, 257);
            this.staffList.TabIndex = 1;
            this.staffList.UseCompatibleStateImageBehavior = false;
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
            this.mApsToolStripMenuItem,
            this.researchToolStripMenuItem,
            this.contactFormToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(884, 32);
            this.mainMenuStrip.TabIndex = 25;
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
            // mApsToolStripMenuItem
            // 
            this.mApsToolStripMenuItem.Name = "mApsToolStripMenuItem";
            this.mApsToolStripMenuItem.Size = new System.Drawing.Size(65, 28);
            this.mApsToolStripMenuItem.Text = "Maps";
            this.mApsToolStripMenuItem.Click += new System.EventHandler(this.mApsToolStripMenuItem_Click);
            // 
            // researchToolStripMenuItem
            // 
            this.researchToolStripMenuItem.Name = "researchToolStripMenuItem";
            this.researchToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.researchToolStripMenuItem.Text = "Research";
            this.researchToolStripMenuItem.Click += new System.EventHandler(this.researchToolStripMenuItem_Click);
            // 
            // contactFormToolStripMenuItem
            // 
            this.contactFormToolStripMenuItem.Name = "contactFormToolStripMenuItem";
            this.contactFormToolStripMenuItem.Size = new System.Drawing.Size(143, 28);
            this.contactFormToolStripMenuItem.Text = "Contact Form";
            this.contactFormToolStripMenuItem.Click += new System.EventHandler(this.contactFormToolStripMenuItem_Click);
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.people_title);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Purple;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeopleForm";
            this.Load += new System.EventHandler(this.PeopleForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label people_title;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView facultyList;
        private System.Windows.Forms.ListView staffList;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem degreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mApsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem researchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactFormToolStripMenuItem;
    }
}