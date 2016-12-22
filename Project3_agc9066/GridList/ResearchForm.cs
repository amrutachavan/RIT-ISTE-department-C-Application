using Newtonsoft.Json.Linq;
using RESTUtil;
using System;
using System.Drawing;
using System.Windows.Forms;

/**
 * ResearchForm is used to display the Research details*/
namespace GridList
{
    public partial class ResearchForm : Form
    {
        Research rsrch;
        Rest rj = new Rest("http://ist.rit.edu/api");
        public ResearchForm()
        {
            InitializeComponent();
        }

        private void ResearchForm_Paint(object sender, PaintEventArgs e)
        {
        //    Graphics g = e.Graphics;
          //  Pen p = new Pen(Color.Gold, 80);
            //g.DrawEllipse(p, 150, 150, 80, 80);
            //g.Dispose();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Draw circle using the Graphics library
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Gold, 60);
            g.DrawEllipse(p, 40, 40, 60, 60);
            g.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //Draw circle using the Graphics library
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.Gold, 60);
            g.DrawEllipse(p, 40, 40, 60, 60);
            g.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //Draw circle using the Graphics library
            Graphics g = panel3.CreateGraphics();
            Pen p = new Pen(Color.Gold, 60);
            g.DrawEllipse(p, 40, 40, 60, 60);
            g.Dispose();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            //Draw circle using the Graphics library
            Graphics g = panel4.CreateGraphics();
            Pen p = new Pen(Color.Gold, 60);
            g.DrawEllipse(p, 40, 40, 60, 60);
            g.Dispose();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            //Draw circle using the Graphics library
            Graphics g = panel5.CreateGraphics();
            Pen p = new Pen(Color.Gold, 60);
            g.DrawEllipse(p, 40, 40, 60, 60);
            g.Dispose();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            //Draw circle using the Graphics library
            Graphics g = panel6.CreateGraphics();
            Pen p = new Pen(Color.Gold, 60);
            g.DrawEllipse(p, 40, 40, 60, 60);
            g.Dispose();
        }

        private void ResearchForm_Load(object sender, EventArgs e)
        {
            //get the json message in string format
            string researchMsg = rj.getRestData("/research");
            //parse the json data
            rsrch = JToken.Parse(researchMsg).ToObject<Research>();
            //display the data on forms
            label2.Text = rsrch.byInterestArea[0].areaName;
            label3.Text = rsrch.byInterestArea[1].areaName;
            label4.Text = rsrch.byInterestArea[2].areaName;
            label5.Text = rsrch.byInterestArea[3].areaName;
            label6.Text = rsrch.byInterestArea[4].areaName;
            label7.Text = rsrch.byInterestArea[5].areaName;
            //label8.Text = rsrch.byInterestArea[6].areaName;
            label9.Text = rsrch.byInterestArea[7].areaName;
            label10.Text = rsrch.byInterestArea[8].areaName;
            label11.Text = rsrch.byInterestArea[9].areaName;
            label12.Text = rsrch.byInterestArea[10].areaName;
            label1.Text = rsrch.byInterestArea[11].areaName;
            label13.Text = rsrch.byInterestArea[6].areaName;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            //Draw circle using the Graphics library
            Graphics g = panel7.CreateGraphics();
            Pen p = new Pen(Color.Gold, 60);
            g.DrawEllipse(p, 40, 40, 60, 60);
            g.Dispose();
        }


        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            //Draw circle using the Graphics library
            Graphics g = panel9.CreateGraphics();
            Pen p = new Pen(Color.Gold, 60);
            g.DrawEllipse(p, 40, 40, 60, 60);
            g.Dispose();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            //Draw circle using the Graphics library
            Graphics g = panel10.CreateGraphics();
            Pen p = new Pen(Color.Gold, 60);
            g.DrawEllipse(p, 40, 40, 60, 60);
            g.Dispose();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            //Draw circle using the Graphics library
            Graphics g = panel11.CreateGraphics();
            Pen p = new Pen(Color.Gold, 60);
            g.DrawEllipse(p, 40, 40, 60, 60);
            g.Dispose();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            //Draw circle using the Graphics library
            Graphics g = panel12.CreateGraphics();
            Pen p = new Pen(Color.Gold, 60);
            g.DrawEllipse(p, 40, 40, 60, 60);
            g.Dispose();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            //Draw circle using the Graphics library
            Graphics g = panel13.CreateGraphics();
            Pen p = new Pen(Color.Gold, 60);
            g.DrawEllipse(p, 40, 40, 60, 60);
            g.Dispose();
        }

        
        //showRef method is used to display the citations in the messageBox
        private void showRef(int index) {
            String citation=" ";
            for (var i = 0; i < rsrch.byInterestArea[index].citations.Count; i++) {
                citation = citation+ "\r\n >>" + rsrch.byInterestArea[index].citations[i];
            }
           
            MessageBox.Show(citation);

         }

        private void panel2_Click(object sender, EventArgs e)
        {
            showRef(0);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            showRef(1);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            showRef(11);
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            showRef(7);
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            showRef(5);
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            showRef(6);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            showRef(2);
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            showRef(8);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            showRef(3);
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            showRef(9);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            showRef(4);
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            showRef(10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();
            f.Show();
            this.Hide();
       }

        private void label2_Click(object sender, EventArgs e)
        {
            showRef(0);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            showRef(1);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            showRef(11);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            showRef(6);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            showRef(5);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            showRef(7);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            showRef(10);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            showRef(4);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            showRef(9);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            showRef(2);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            showRef(8);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            showRef(3);
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
