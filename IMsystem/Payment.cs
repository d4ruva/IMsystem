using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMsystem
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        public void fillgridviewpolicy()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Prakash\\Documents\\policy.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from policy_tbl", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Select";
            checkBoxColumn.Width = 50;
            checkBoxColumn.Name = "checkboxcolumn";
            dataGridView1.Columns.Insert(0, checkBoxColumn);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Prakash\\Documents\\policy.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "SELECT * FROM policy_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public static DataGridViewRow selectedrow;




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                pname.Text = row.Cells["policyname"].Value.ToString();
                pno.Text = row.Cells["policyno"].Value.ToString();
                ptype.Text = row.Cells["policytype"].Value.ToString();
                pcover.Text = row.Cells["coverage"].Value.ToString();
                edate.Text = row.Cells["effectivedate"].Value.ToString();
                expdate.Text = row.Cells["expdate"].Value.ToString();
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Prakash\\Documents\\customer.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
            con.Open();
            string query = "SELECT * FROM customer_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        public static DataGridViewRow selectedrow1;
        public void fillgridviewpolicy1()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Prakash\\Documents\\customer.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
            SqlDataAdapter da = new SqlDataAdapter("select * from customer_tbl", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Select";
            checkBoxColumn.Width = 50;
            checkBoxColumn.Name = "checkboxcolumn";
            dataGridView2.Columns.Insert(0, checkBoxColumn);

        }
        
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Name"].Value.ToString();
                textBox2.Text = row.Cells["Martitial_status"].Value.ToString();
                textBox3.Text = row.Cells["Age"].Value.ToString();
                textBox4.Text = row.Cells["Nationality"].Value.ToString();
                textBox5.Text = row.Cells["Gender"].Value.ToString();
                textBox6.Text = row.Cells["DOB"].Value.ToString();
                textBox7.Text = row.Cells["Mobile_No"].Value.ToString();
                textBox8.Text = row.Cells["Address"].Value.ToString();
                textBox8.Text = row.Cells["Email_Id"].Value.ToString();

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //
        }
    }
}
