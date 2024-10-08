using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace IMsystem
{

    public partial class Customerreg : Form
    {

        public Customerreg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
            this.Hide();
            Payment payment = new Payment();
            payment.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Prakash\\Documents\\customer.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
           

            con.Open();
            String query = "INSERT INTO customer_tbl(Name, Martitial_status, Age, Nationality,Gender,DOB,Mobile_No, Address, Email_Id,Aadhar_Card_No,Passport_No,Benificiary_Name,Relation_to_the_applicant,policyname,policyno,policytype,coverage,effectivedate,expdate,Benificiary_Mobile_No) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox14.Text + "','" + textBox13.Text + "','" + pname + "','" + pno + "','" + ptype + "','" + pcover + "','" + edate + "','" + expdate + "','"+textBox11.Text+"')";

                
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Insert SUCCESSFULLY");

        }
    }
}



