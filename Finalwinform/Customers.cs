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
    public partial class Customers : Form
    {
        String strconn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public Customers()
        {
            InitializeComponent();
        }

     

        private void Customers_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Customers", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main back = new Main();
            IsMdiContainer = true;
            back.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomers back = new AddCustomers();
            IsMdiContainer = true;
            back.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveCustomers b = new RemoveCustomers();
            IsMdiContainer = true;
            b.ShowDialog();
        }
    }
}
