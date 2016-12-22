using RESTUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GridList.Properties;
using Newtonsoft.Json.Linq;

/**
 PeopleForm is used to display the people staff/faculty details
    */
namespace GridList
{
    public partial class PeopleForm : Form
    {
        Rest rj = new Rest("http://ist.rit.edu/api");
        People ppl;
        public PeopleForm()
        {
            InitializeComponent();
        }

        private void PeopleForm_Load(object sender, EventArgs e)
        {
            string p = rj.getRestData("/people/");
            //parse the json object
            ppl = JToken.Parse(p).ToObject<People>();
            people_title.Text = ppl.title;
            //add data to the faculty list
            facultyList.View = View.Details;
            facultyList.FullRowSelect = true;
            facultyList.Columns.Add("Name", 150);
            facultyList.Columns.Add("Title", 100);
            facultyList.Columns.Add("Interest Area", 100);
            facultyList.Columns.Add("Website", 100);
            facultyList.Columns.Add("Email", 100);
            facultyList.Columns.Add("Phone", 100);
            ListViewItem item;
            for (var i = 0; i < ppl.faculty.Count; i++)
            {
                item = new ListViewItem(new String[]
                {
                    ppl.faculty[i].name,
                    ppl.faculty[i].title,
                    ppl.faculty[i].interestArea,
                    ppl.faculty[i].website,
                    ppl.faculty[i].email,
                    ppl.faculty[i].phone
                });

                // append the new row to the ListView
                facultyList.Items.Add(item);
            }

            staffList.View = View.Details;
            staffList.FullRowSelect = true;
            staffList.Columns.Add("Name", 150);
            staffList.Columns.Add("Title", 100);
            staffList.Columns.Add("Interest Area", 100);
            staffList.Columns.Add("Website", 100);
            staffList.Columns.Add("Email", 100);
            staffList.Columns.Add("Phone", 100);
            ListViewItem staffitem;
            for (var i = 0; i < ppl.staff.Count; i++)
            {
                staffitem = new ListViewItem(new String[]
                {
                    ppl.staff[i].name,
                    ppl.staff[i].title,
                    ppl.staff[i].interestArea,
                    ppl.staff[i].website,
                    ppl.staff[i].email,
                    ppl.staff[i].phone
                });

                // append the new row to the ListView
                staffList.Items.Add(staffitem);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm f1 = new MainForm();
            f1.Show();
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
