namespace GridList
{
    partial class EmploymentTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmploymentTableForm));
            this.emptabelList = new System.Windows.Forms.ListView();
            this.employmentTableTitle = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mApsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.researchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // emptabelList
            // 
            this.emptabelList.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptabelList.ForeColor = System.Drawing.Color.Purple;
            this.emptabelList.GridLines = true;
            this.emptabelList.Location = new System.Drawing.Point(70, 106);
            this.emptabelList.Name = "emptabelList";
            this.emptabelList.ShowItemToolTips = true;
            this.emptabelList.Size = new System.Drawing.Size(750, 380);
            this.emptabelList.TabIndex = 5;
            this.emptabelList.UseCompatibleStateImageBehavior = false;
            // 
            // employmentTableTitle
            // 
            this.employmentTableTitle.AutoSize = true;
            this.employmentTableTitle.BackColor = System.Drawing.Color.Transparent;
            this.employmentTableTitle.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employmentTableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.employmentTableTitle.Location = new System.Drawing.Point(408, 55);
            this.employmentTableTitle.Name = "employmentTableTitle";
            this.employmentTableTitle.Size = new System.Drawing.Size(69, 35);
            this.employmentTableTitle.TabIndex = 6;
            this.employmentTableTitle.Text = "title";
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
            // EmploymentTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.employmentTableTitle);
            this.Controls.Add(this.emptabelList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EmploymentTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmploymentTableForm";
            this.Load += new System.EventHandler(this.EmploymentTableForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView emptabelList;
        private System.Windows.Forms.Label employmentTableTitle;
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