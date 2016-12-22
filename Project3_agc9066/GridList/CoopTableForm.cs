using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 This form is used to display the co-op table*/
namespace GridList
{
    public partial class CoopTableForm : Form
    {
        Employment empl;
        public CoopTableForm(Employment emp)
        {
            empl = emp;
            InitializeComponent();
        }

        private void CoopTable_Load(object sender, EventArgs e)
        {
            coopList.View = View.Details;
            coopList.FullRowSelect = true;
            coopList.Columns.Add("Employer",200);
            coopList.Columns.Add("Degree",200);
            coopList.Columns.Add("City",200);
            coopList.Columns.Add("Term",100);
            ListViewItem item;
            for (var i = 0; i < empl.coopTable.coopInformation.Count; i++)
            {
                item = new ListViewItem(new String[]
                {
                    empl.coopTable.coopInformation[i].employer,
                    empl.coopTable.coopInformation[i].degree,
                    empl.coopTable.coopInformation[i].city,
                    empl.coopTable.coopInformation[i].term,
                });

                // append the new row to the ListView
                coopList.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void mApsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapForm mf = new MapForm();
            mf.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainf = new MainForm();
            mainf.Show();
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
