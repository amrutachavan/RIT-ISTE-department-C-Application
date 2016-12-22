using GridList.Properties;
using Newtonsoft.Json.Linq;
using RESTUtil;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

/**
 * @author Amruta Chavan agc9066
 * This is the main form of the application.
 */
namespace GridList
{
    public partial class MainForm : Form
    {
        //this is the main website to consume data
        Rest rj = new Rest("http://ist.rit.edu/api");
        Employment emp;
        About abt;
        // create a stopwatch for timing different activities
        Stopwatch sw = new Stopwatch();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //get about message and cast it
            string aboutMessage = rj.getRestData("/about");
            abt = JToken.Parse(aboutMessage).ToObject<About>();
            aboutLabel.MaximumSize = new Size(800, 50);
            aboutLabel.AutoSize = true;
            aboutLabel2.MaximumSize = new Size(800, 200);
            aboutLabel2.AutoSize = true;

            aboutLabel.Text = abt.title;
            aboutLabel2.Text = abt.description + "\r\n"+ abt.quote + "\r\n--" + abt.quoteAuthor;
         
            // get employment data for data grid and list view
            string jsonEmp = rj.getRestData("/employment/");
            // cast it to the object Employment
            emp = JToken.Parse(jsonEmp).ToObject<Employment>();

            }
        

        /**
         button click operation for degree form
            */
        private void degreeBtn_Click(object sender, EventArgs e)
        {
            DegreeForm df = new DegreeForm();
            //show degree form 
            df.Show();
            //hide the current form
            this.Hide();
        }

        /**
         * button click operation for people form
        */
        private void people_btn_Click(object sender, EventArgs e)
        {
            PeopleForm pf = new PeopleForm();
            pf.Show();
            this.Hide();
        }

        /**
         * button click operation for Employment form
        */
        private void button1_Click(object sender, EventArgs e)
        {
            EmploymentForm ef = new EmploymentForm();
            ef.Show();
            this.Hide();
        }

        /**
         * button click operation for Research form
        */
        private void button2_Click(object sender, EventArgs e)
        {
            ResearchForm rf = new ResearchForm();
            rf.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.rit.edu/admission.html");
        }

        private void abouthisLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://ist.rit.edu/assets/includes/calls/calls.php?area=aboutSite");
        }

        private void supportISTLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://ist.rit.edu/assets/includes/calls/calls.php?area=supportIST");
        }

        private void labHoursLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://ist.rit.edu/assets/includes/resources/calls.php?area=tutors");
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.rit.edu/");
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
