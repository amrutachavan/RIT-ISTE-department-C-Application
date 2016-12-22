using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using RESTUtil;

/// <summary>
///Employment form is used to display employment details 
/// </summary>
namespace GridList
{
    public partial class EmploymentForm : Form
    {
        Employment empl;
        Rest rj = new Rest("http://ist.rit.edu/api");
        public EmploymentForm()
        {
            InitializeComponent();
        }

        private void Employemnt_Load(object sender, EventArgs e)
        {
            string em = rj.getRestData("/employment/");
            //parse the json object
            empl = JToken.Parse(em).ToObject<Employment>();
            employmentTitle.Text = empl.introduction.title;
            subTitle.Text = empl.introduction.content[0].title;
            titleContent.MaximumSize = new Size(710, 100);
            titleContent.AutoSize = true;
            //display data
            titleContent.Text = empl.introduction.content[0].description;
            statTextBox1.Text = empl.degreeStatistics.statistics[0].value + "\r\n" + empl.degreeStatistics.statistics[0].description;
            statTextBox2.Text = empl.degreeStatistics.statistics[1].value + "\r\n" + empl.degreeStatistics.statistics[1].description;
            statTextBox3.Text = empl.degreeStatistics.statistics[2].value + "\r\n" + empl.degreeStatistics.statistics[2].description;
            statTextBox4.Text = empl.degreeStatistics.statistics[3].value + "\r\n" + empl.degreeStatistics.statistics[3].description;
            subTitle2.Text = empl.introduction.content[1].title;
            titleContent2.MaximumSize = new Size(710, 100);
            titleContent2.AutoSize = true;
            titleContent2.Text = empl.introduction.content[1].description;

        }
        /*show new form*/
        private void coopTable_Click(object sender, EventArgs e)
        {
            CoopTableForm cp = new CoopTableForm(empl);
            cp.Show();
            this.Hide();
        }
        /*show new form*/
        private void button1_Click(object sender, EventArgs e)
        {
            EmploymentTableForm ef = new EmploymentTableForm(empl);
            ef.Show();
            this.Hide();
        }
        /*show new form*/
        private void button2_Click(object sender, EventArgs e)
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
