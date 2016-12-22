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
/**
 *Degree Form is used to display degree details
 */
namespace GridList
{
    public partial class DegreeForm : Form
    {
        //website to consume data from
        Rest rj = new Rest("http://ist.rit.edu/api");
        Degree deg;
        Minors minors;
        public DegreeForm()
        {
            InitializeComponent();
        }

        private void DegreeForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(MainMenuStrip);
            String gradDeg = rj.getRestData("/degrees");
            //parse the json object 
            deg = JToken.Parse(gradDeg).ToObject<Degree>();
            String degDetails = "", underDegDetails = "", ugminors = "";

            for (var i = 0; i < deg.graduate.Count; i++)
            {
                //iterate over the list to get details
                degDetails = degDetails + "\r\n>>" + deg.graduate[i].title + "\r\n" + deg.graduate[i].description + "\r\n";
                Console.WriteLine(deg.graduate[i].title + "\r\n" + deg.graduate[i].description);
            }
            gradLabel.Text = degDetails;

            for (var i = 0; i < deg.undergraduate.Count; i++)
            {
                //iterate over the list to get details
                underDegDetails = underDegDetails + "\r\n>>" + deg.undergraduate[i].title + "\r\n" + deg.undergraduate[i].description + "\r\n";
                Console.WriteLine(deg.graduate[i].title + "\r\n" + deg.graduate[i].description);
            }
            undergradLabel.Text = underDegDetails;
            String gradMinors = rj.getRestData("/minors");
            minors = JToken.Parse(gradMinors).ToObject<Minors>();

            for (var i = 0; i < minors.UgMinors.Count; i++)
            {
                //iterate over the list to get details
                ugminors = ugminors + "\r\n>>" + minors.UgMinors[i].title + "\r\n" + minors.UgMinors[i].description + "\r\n";
            }
            minorLabel.Text = ugminors;
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