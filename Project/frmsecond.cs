using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmsecond : Form
    {
        public frmsecond()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void manageToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmStock stock = new FrmStock();
            stock.Show();
            this.Hide();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 demo = new Form1();
            demo.Show();
            this.Hide();
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order order = new order();
            order.Show();
            this.Hide();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            admin.Show();
            this.Hide();
        }
    }
}
