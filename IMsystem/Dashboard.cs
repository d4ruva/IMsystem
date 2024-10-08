using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMsystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.Load += Agent_Load;
        }

        private void Agent_Load(object sender, EventArgs e)
        {
            LoadForm1IntoPanel();
        }
        private void LoadForm1IntoPanel()
        {
            // Create an instance of Form1
            Agent form1 = new Agent();

            
            form1.TopLevel = false;

            // Clear existing controls in the panel if needed
            panel1.Controls.Clear();

            // Add Form1 to the panel
            panel1.Controls.Add(form1);

            // Dock Form1 to fill the panel
            form1.Dock = DockStyle.Fill;

            // Show Form1
            form1.Show();
        }

        public void loadform(object form)
        {
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Customerreg c=new Customerreg();
            c.TopLevel = false;
            panel1.Controls.Add(c);
            c.BringToFront();
            c.Show();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void POLICY_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Addpolicy a= new Addpolicy();
            a.TopLevel = false;
            panel1.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Agent ag = new Agent();
            ag.TopLevel = false;


            panel1.Controls.Add(ag);
            ag.BringToFront();
            ag.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Payment p = new Payment();
            p.TopLevel = false;
            panel1.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
