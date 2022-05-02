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
    public partial class ArriveNote : Form
    {
        String strconn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public ArriveNote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conn = new SqlConnection(strconn);
                conn.Open();
                String ArID = textBox1.Text;
                String ID = textBox2.Text;
                String Name = textBox7.Text;
                String Date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                String ArPrice = textBox4.Text;
                String EPrice = textBox6.Text;
                String Q = textBox5.Text;

                SqlCommand cmd = new SqlCommand("insert Products values('" + ID + "','" + Name + "','" + Q + "','" + ArPrice + "','" + EPrice + "')", conn);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("insert ArriveNote values('" + ArID + "',cast('" + Date + "'as Date),'" + ID + "','" + ArPrice + "','" + Q + "')", conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Add OK!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duplicate ID!!  Type Again!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main b = new Main();
            IsMdiContainer = true;
            b.ShowDialog();
        }

        private void ArriveNote_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from ArriveNote", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
