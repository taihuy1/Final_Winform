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
    public partial class RemoveProductscs : Form
    {
        String strconn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public RemoveProductscs()
        {
            InitializeComponent();
        }

        private void RemoveProductscs_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ProductID";
            comboBox1.ValueMember = "ProductID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products b = new Products();
            IsMdiContainer = true;
            b.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("delete from PendingNote where ProductID = '" + comboBox1.Text + "'", conn);
            cmd2.ExecuteNonQuery();
            SqlCommand cmd3 = new SqlCommand("delete from RequestStatus where ProductID = '" + comboBox1.Text + "'", conn);
            cmd3.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand("delete from Products where ProductID = '" + comboBox1.Text +"'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted!!!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
