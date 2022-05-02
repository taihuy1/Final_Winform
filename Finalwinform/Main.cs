using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalwinform
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products products = new Products();
            IsMdiContainer = true;
            products.ShowDialog();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers C = new Customers();
            IsMdiContainer = true;
            C.ShowDialog();
        }

        private void requestStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Request products = new Request();
            IsMdiContainer = true;
            products.ShowDialog();
        }

        private void pendingNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PendingNote products = new PendingNote();
            IsMdiContainer = true;
            products.ShowDialog();
        }

        private void arriveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ArriveNote products = new ArriveNote();
            IsMdiContainer = true;
            products.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
