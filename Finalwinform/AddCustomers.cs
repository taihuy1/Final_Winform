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
    public partial class AddCustomers : Form
    {
        String strconn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public AddCustomers()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers C = new Customers();
            IsMdiContainer = true;
            C.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strconn);
                conn.Open();
                String name = textName.Text;
                String Phone = textPhone.Text;
                String Address = textAddress.Text;
                String ID = textID.Text;

                SqlCommand cmd = new SqlCommand("insert Customers values('" + ID + "','" + name + "','" + Address + "','" + Phone + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add OK!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duplicate ID!! Type again");
            }
            
        }
    }
}
