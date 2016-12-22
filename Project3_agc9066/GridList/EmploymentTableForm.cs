using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
///EmploymentTableForm is used to display the employment details 
/// </summary>
namespace GridList
{
    public partial class EmploymentTableForm : Form
    {
        Employment empl;
        public EmploymentTableForm(Employment emp)
        {
            empl = emp;
            InitializeComponent();
        }

        private void EmploymentTableForm_Load(object sender, EventArgs e)
        {
            employmentTableTitle.Text = empl.employers.title;
            emptabelList.View = View.Details;
            emptabelList.FullRowSelect = true;
            //add columns to the list
            emptabelList.Columns.Add("Employer",200);
            emptabelList.Columns.Add("Degree",200);
            emptabelList.Columns.Add("City",100);
            emptabelList.Columns.Add("Title",100);
            emptabelList.Columns.Add("Start Date",100);
            ListViewItem item;
            for (var i = 0; i < empl.employmentTable.professionalEmploymentInformation.Count; i++)
            {
                item = new ListViewItem(new String[]
                {
                    empl.employmentTable.professionalEmploymentInformation[i].employer,
                    empl.employmentTable.professionalEmploymentInformation[i].degree,
                    empl.employmentTable.professionalEmploymentInformation[i].city,
                    empl.employmentTable.professionalEmploymentInformation[i].title,
                    empl.employmentTable.professionalEmploymentInformation[i].startDate,
                });

                // append the new row to the ListView
                emptabelList.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmploymentForm ef = new EmploymentForm();
            ef.Show();
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

        private void researchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResearchForm rf = new ResearchForm();
            rf.Show();
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
