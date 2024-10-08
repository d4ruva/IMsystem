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
    public partial class Addpolicy : Form
    {

       
        public Addpolicy()
        {
            InitializeComponent();
            button4.Click += button4_Click;
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Prakash\\Documents\\policy.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
           
            con.Open();

            String query = "INSERT INTO policy_tbl(policyname, policyno, policytype, coverage,effectivedate,expdate,premiumamt, deductibleamt, paymentsch, policystatus)  VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text+"')";
            SqlDataAdapter sda=new SqlDataAdapter(query,con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Insert SUCCESSFULLY");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM policy_tbl";
            SqlDataAdapter sda=new SqlDataAdapter(query,con);
            DataTable dt=new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("policyname like '%" + textBox11.Text + "%'");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Agent form2 = new Agent();

            // Show Form2
            form2.Show();

            // Optionally, you can close Form1 if you don't want it open
            this.Hide();
        }

        private void Addpolicy_Load(object sender, EventArgs e)
        {

        }
    }
}
