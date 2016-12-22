using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridList
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
            webBrowser2.Navigate("http://ist.rit.edu/api/contactForm/");
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainf = new MainForm();
            mainf.Show();
            this.Hide();
        }

        private void degreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DegreeForm df = new DegreeForm();
            //show degree form 
            df.Show();
            //hide the current form
            this.Hide();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeopleForm pf = new PeopleForm();
            pf.Show();
            this.Hide();
        }

        private void employmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmploymentForm ef = new EmploymentForm();
            ef.Show();
            this.Hide();
        }

        private void researchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResearchForm rf = new ResearchForm();
            rf.Show();
            this.Hide();
        }

        private void mApsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapForm mf = new MapForm();
            mf.Show();
            this.Hide();
        }

        private void contactFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactForm cf = new ContactForm();
            cf.Show();
            this.Hide();
        }
    }
}
