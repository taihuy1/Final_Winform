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
    public partial class AddPendingNote : Form

    {
        String strconn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public AddPendingNote()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PendingNote C = new PendingNote();
            IsMdiContainer = true;
            C.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conn = new SqlConnection(strconn);
                conn.Open();
                String pending = PendingID.Text;
                String D = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                String C = dataGridView1.Rows[0].Cells[1].Value.ToString();
                String ProductID = dataGridView1.Rows[0].Cells[2].Value.ToString();
                String price = "";

                for (int i = 0; i < dataGridViewproduct.Rows.Count - 1; i++)
                {
                    if (dataGridViewproduct.Rows[i].Cells[0].Value.ToString().Equals(ProductID))
                    {
                        price = dataGridViewproduct.Rows[i].Cells[4].Value.ToString();
                    }
                }
                String Q = dataGridView1.Rows[0].Cells[4].Value.ToString();


                SqlCommand cmd = new SqlCommand("insert PendingNote values('" + pending + "',cast('" + D + "'as Date),'" + C + "','" + ProductID + "','" + price + "','" + Q + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add OK!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("the information being duplicated!! type again!!");
            }
            
          
        }

        private void AddPendingNote_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from RequestStatus", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            SqlCommand cmd2 = new SqlCommand("select * from Products", conn);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            dataGridViewproduct.DataSource = dt2;
            PendingID.DataSource = dt;
            PendingID.DisplayMember = "RqID";
            PendingID.ValueMember = "CID";

            
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";


        }

        private void ProductID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PendingID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ID = PendingID.Text;
            SqlConnection conn = new SqlConnection(strconn);
            try
            {
                SqlCommand cmd = new SqlCommand("select * from RequestStatus where RqID = " + ID, conn);
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd);
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);
                dataGridView1.DataSource = dt2;
            }catch (Exception ex) {  }
            

         
        }
    }
}
