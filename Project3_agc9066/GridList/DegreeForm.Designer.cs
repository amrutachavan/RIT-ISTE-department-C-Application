namespace GridList
{
    partial class DegreeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DegreeForm));
            this.minorTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gradLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.undergradLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.minorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mApsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.researchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minorTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // minorTab
            // 
            this.minorTab.Controls.Add(this.tabPage1);
            this.minorTab.Controls.Add(this.tabPage2);
            this.minorTab.Controls.Add(this.tabPage3);
            this.minorTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minorTab.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minorTab.Location = new System.Drawing.Point(67, 136);
            this.minorTab.Margin = new System.Windows.Forms.Padding(0);
            this.minorTab.Multiline = true;
            this.minorTab.Name = "minorTab";
            this.minorTab.SelectedIndex = 0;
            this.minorTab.Size = new System.Drawing.Size(757, 367);
            this.minorTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.gradLabel);
            this.tabPage1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Purple;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(749, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "";
            this.tabPage1.Text = "Graduate Degrees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gradLabel
            // 
            this.gradLabel.AutoSize = true;
            this.gradLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradLabel.Location = new System.Drawing.Point(1, 0);
            this.gradLabel.MaximumSize = new System.Drawing.Size(600, 700);
            this.gradLabel.Name = "gradLabel";
            this.gradLabel.Padding = new System.Windows.Forms.Padding(10);
            this.gradLabel.Size = new System.Drawing.Size(85, 44);
            this.gradLabel.TabIndex = 0;
            this.gradLabel.Text = "label2";
            this.gradLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.undergradLabel);
            this.tabPage2.ForeColor = System.Drawing.Color.Purple;
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(749, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Undergraduate Degrees";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // undergradLabel
            // 
            this.undergradLabel.AutoSize = true;
            this.undergradLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undergradLabel.Location = new System.Drawing.Point(1, 3);
            this.undergradLabel.MaximumSize = new System.Drawing.Size(600, 700);
            this.undergradLabel.Name = "undergradLabel";
            this.undergradLabel.Padding = new System.Windows.Forms.Padding(10);
            this.undergradLabel.Size = new System.Drawing.Size(85, 44);
            this.undergradLabel.TabIndex = 1;
            this.undergradLabel.Text = "label2";
            this.undergradLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Controls.Add(this.minorLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(749, 325);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Minors";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // minorLabel
            // 
            this.minorLabel.AutoSize = true;
            this.minorLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minorLabel.Location = new System.Drawing.Point(3, 3);
            this.minorLabel.MaximumSize = new System.Drawing.Size(600, 700);
            this.minorLabel.Name = "minorLabel";
            this.minorLabel.Padding = new System.Windows.Forms.Padding(10);
            this.minorLabel.Size = new System.Drawing.Size(85, 44);
            this.minorLabel.TabIndex = 1;
            this.minorLabel.Text = "label2";
            this.minorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(193, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Our Graduate/ Undergraduate Degrees";
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
            // DegreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minorTab);
            this.ForeColor = System.Drawing.Color.Purple;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DegreeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.DegreeForm_Load);
            this.minorTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl minorTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label gradLabel;
        private System.Windows.Forms.Label undergradLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label minorLabel;
        private System.Windows.Forms.Label label1;
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