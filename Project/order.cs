using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class order : Form
    {
        private string order_no;
        private string coffeetype;
        private string priceperone;
        private string quantity;
        
        private int orderIndex;

        DBconnection con;

        private BindingSource bindingSource = new BindingSource();
        private string connectionString = @"Data Source=DESKTOP-KPFQESI\SQLEXPRESS;Initial Catalog=project;Integrated Security=True";
        public order()
        {
            InitializeComponent();
            try
            {
                con = DBconnection.getDBconnection();
                dgvOrder.DataSource = bindingSource;
                refreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool isDataValid()
        {
            order_no = txtorderNo.Text;
            coffeetype = comboOrder.Text;
            priceperone = txtO_price.Text;
           
            quantity = txtO_quantity.Text;
           
            if (order_no == string.Empty || coffeetype == string.Empty || priceperone== string.Empty)
            {
                MessageBox.Show("order No., coffeetype and price must be entered");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           

            try
            {
                if (isDataValid())
                {
                    string query1 = "INSERT INTO ord (OrderNo, CoffeeType, PricePerOne, C_Quantity) VALUES('{0}','{1}','{2}','{3}')";
                    query1 = string.Format(query1, order_no, coffeetype, priceperone, quantity);
                    con.executeInsertUpdateQuery(query1);
                    refreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void refreshGrid()
        {
            string sqlForSelectingAll = "select * from ord";
            bindingSource.DataSource = con.getDataTable(sqlForSelectingAll);
            // Resize the DataGridView columns to fit the newly loaded content.
            dgvOrder.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderIndex = e.RowIndex;
            DataGridViewRow row = dgvOrder.Rows[orderIndex];
            txtorderNo.Text = row.Cells[0].Value.ToString();
            comboOrder.Text = row.Cells[1].Value.ToString();
            txtO_price.Text = row.Cells[2].Value.ToString();
            txtO_quantity.Text = row.Cells[3].Value.ToString();
           
        }

        private void btnO_dlt_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow row = dgvOrder.Rows[orderIndex];
                if (MessageBox.Show(string.Format("You sure want to delete selected row?", row.Cells["OrderNo"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con1 = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("Delete from ord where OrderNo=@OrderNo", con1))
                        {
                            cmd.Parameters.AddWithValue("OrderNo", row.Cells["OrderNo"].Value);
                            con1.Open();
                            cmd.ExecuteNonQuery();
                            con1.Close();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnO_back_Click(object sender, EventArgs e)
        {
            frmsecond frmsecond = new frmsecond();
            frmsecond.Show();
            this.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double total;
                int quanti;
                double price;

                total = 0;
                quanti = Convert.ToInt32(txtO_quantity.Text);
                price = Convert.ToDouble(txtO_price.Text);

                total= quanti*price;
                lblPrice.Text=total.ToString();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnO_clear_Click(object sender, EventArgs e)
        {
            txtorderNo.Clear();
            txtO_quantity.Clear();
            txtO_price.Clear();
            lblPrice.Text = string.Empty;
            txtorderNo.Focus();
        }
    }
}
