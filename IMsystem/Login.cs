using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IMsystem
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Prakash\\Documents\\login.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(userid.Text=="admin"&& pass.Text=="admin")
            {
                MessageBox.Show("LOGGED IN SUCCESSFULLY");
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("invalid","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userid.Clear();
            pass.Clear();


            userid.Focus();
        }
    }
}
