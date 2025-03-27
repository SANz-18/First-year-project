using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FrmStock : Form
    {
        private string item_no;
        private string item_Name;
        private string quantity;
        private string expireDate;
        private string price;
        private int itemiCellIndex;
        

        DBconnection con;

        private BindingSource bindingSource = new BindingSource();
        private string connectionString = @"Data Source=DESKTOP-KPFQESI\SQLEXPRESS;Initial Catalog=project;Integrated Security=True";
        public FrmStock()
        {
            InitializeComponent();
            try
            {
                con = DBconnection.getDBconnection();
                dgvItem.DataSource = bindingSource;
                refreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool isDataValid()
        {
            item_no = txtItem_Num.Text;
            item_Name = txtItem_Name.Text;
            quantity = txtItem_Quantity.Text;
            expireDate = txtItem_Exdate.Text;
            price = txtPrice.Text;
           
            
            

            if (item_no == string.Empty || item_Name == string.Empty || expireDate == string.Empty)
            {
                MessageBox.Show("All the details must be entered");
                return false;
            }
            return true;
        }

        private void btnSback_Click(object sender, EventArgs e)
        {
            frmsecond frmsecond = new frmsecond();
            frmsecond.Show();
            this.Hide();
        }

        private void btnItem_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (isDataValid())
                {
                    string query1 = "INSERT INTO item1 (ItemNo, ItemName, Quantity, ExpireDate, Price) VALUES('{0}','{1}','{2}','{3}','{4}')";
                    query1 = string.Format(query1, item_no, item_Name, quantity, expireDate, price);
                   
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
            string sqlForSelectingAll = "select * from item1";
            bindingSource.DataSource = con.getDataTable(sqlForSelectingAll);
            // Resize the DataGridView columns to fit the newly loaded content.
            dgvItem.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemiCellIndex = e.RowIndex;
            DataGridViewRow row = dgvItem.Rows[itemiCellIndex];
            txtItem_Num.Text = row.Cells[0].Value.ToString();
            txtItem_Name.Text = row.Cells[1].Value.ToString();
            txtItem_Quantity.Text = row.Cells[2].Value.ToString();
            txtItem_Exdate.Text = row.Cells[3].Value.ToString();
            txtPrice.Text = row.Cells[4].Value.ToString();
           
        }

        private void btnStock_Dlt_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvItem.Rows[itemiCellIndex];
                if (MessageBox.Show(string.Format("You sure want to delete selected row?", row.Cells["ItemNo"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con1 = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("Delete from item1 where ItemNo=@ItemNo", con1))
                        {
                            cmd.Parameters.AddWithValue("ItemNo", row.Cells["ItemNo"].Value);
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

        private void btnS_update_Click(object sender, EventArgs e)
        {
            try
            {
                item_no = txtItem_Num.Text;
                item_Name = txtItem_Name.Text;
                quantity = txtItem_Quantity.Text;
                expireDate = txtItem_Exdate.Text;
                price = txtPrice.Text;

                SqlConnection con1 = new SqlConnection(connectionString);
                string query = "UPDATE item1 SET ItemName  = '" + item_Name + "', Quantity  = '" + quantity + "', ExpireDate  = '" + expireDate + "' , Price  = '" + price + "' WHERE ItemNo=" + item_no ;
                SqlCommand cmd = new SqlCommand(query, con1);
                con1.Open();
                cmd.ExecuteNonQuery();
                con1.Close();
                MessageBox.Show("Data has been updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSClear_Click(object sender, EventArgs e)
        {
            txtItem_Num.Clear();
            txtItem_Name.Clear();
            txtItem_Quantity.Clear();
            txtItem_Exdate.Clear();
            txtPrice.Clear();
            txtItem_Num.Focus();
        }
    }
}
