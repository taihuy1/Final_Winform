using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace Finalwinform
{
    public partial class AddRequestStatus : Form
    {
        String strconn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public AddRequestStatus()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main C = new Main();
            IsMdiContainer = true;
            C.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strconn);
                conn.Open();
                String RpID = textBox1.Text;
                String CID = textBox3.Text;
                String ID = comboBox1.SelectedValue.ToString();
                String name = comboBox1.Text;
                String Quantity = textBox5.Text;
                String Payment = textBox6.Text;

                SqlCommand cmd = new SqlCommand("insert RequestStatus values('" + RpID + "','" + CID + "','" + ID + "','" + name + "','" + Quantity + "','" + Payment + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add OK!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Should enter CID available in Customers");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RequestStatus_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ProductName";
            comboBox1.ValueMember = "ProductID";
        }
    }
}
