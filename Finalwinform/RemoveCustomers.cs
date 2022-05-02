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
    public partial class RemoveCustomers : Form
    {
        String strconn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public RemoveCustomers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers b = new Customers();
            IsMdiContainer = true;
            b.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            SqlCommand cmd3 = new SqlCommand("delete from RequestStatus where CID = "+comboBox1.Text,conn);
            SqlCommand cmd2 = new SqlCommand("delete from PendingNote where CID = " + comboBox1.Text, conn);
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand("delete from Customers where CID = " + comboBox1.Text, conn);
            cmd.ExecuteNonQuery ();
            MessageBox.Show("Deleted!!!");
        }

        private void RemoveCustomers_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Customers", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "CID";
            comboBox1.ValueMember = "CID";
        }
    }
}
