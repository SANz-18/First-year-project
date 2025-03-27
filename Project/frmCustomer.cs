using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmCustomer : Form
    {
        private string customer_no;
        private string customer_fName;
        private string customer_lName;
        private string customerGender;
        private string customerNic;
        private string customerAddress;
        private int cusIndex;

        DBconnection con;

        private BindingSource bindingSource = new BindingSource();
        private string connectionString = @"Data Source=DESKTOP-KPFQESI\SQLEXPRESS;Initial Catalog=project;Integrated Security=True";
        public frmCustomer()
        {
            InitializeComponent();
            try
            {
                con = DBconnection.getDBconnection();
                dgvCustomer.DataSource = bindingSource;
                refreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool isDataValid()
        {
            customer_no = txtCustomer_No.Text;
            customer_fName = txtCustomer_Fname.Text;
            customer_lName = txtCustomer_Lname.Text;
            // gender = txtGender.Text;
            customerGender = comboBox_Customer.Text;
            customerNic = txtCustomer_NIC.Text;
            customerAddress = txtCustomer_Address.Text;

            if (customer_no == string.Empty || customer_fName == string.Empty)
            {
                MessageBox.Show("Both No. and Name of the customer must be entered");
                return false;
            }
            return true;
        }

        private void btnCback_Click(object sender, EventArgs e)
        {
            frmsecond frmsecond = new frmsecond();
            frmsecond.Show();
            this.Hide();
        }

        private void btnCustomer_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (isDataValid())
                {
                    string query1 = "INSERT INTO customer (CustomerNo, FirstName, LastName, Gender, NIC, Address) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')";
                    query1 = string.Format(query1, customer_no, customer_fName, customer_lName, customerGender, customerNic, customerAddress);
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
            string sqlForSelectingAll = "select * from customer";
            bindingSource.DataSource = con.getDataTable(sqlForSelectingAll);
            // Resize the DataGridView columns to fit the newly loaded content.
            dgvCustomer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cusIndex = e.RowIndex;
            DataGridViewRow row = dgvCustomer.Rows[cusIndex];
            txtCustomer_No.Text = row.Cells[0].Value.ToString();
            txtCustomer_Fname.Text = row.Cells[1].Value.ToString();
            txtCustomer_Lname.Text = row.Cells[2].Value.ToString();
            comboBox_Customer.Text = row.Cells[3].Value.ToString();
            txtCustomer_NIC.Text = row.Cells[4].Value.ToString();
            txtCustomer_Address.Text = row.Cells[5].Value.ToString();
        }

        private void btnCus_Dlt_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvCustomer.Rows[cusIndex];
                if (MessageBox.Show(string.Format("You sure want to delete selected row?", row.Cells["CustomerNo"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con1 = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("Delete from customer where CustomerNo=@CustomerNo", con1))
                        {
                            cmd.Parameters.AddWithValue("CustomerNo", row.Cells["CustomerNo"].Value);
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

        private void btnC_update_Click(object sender, EventArgs e)
        {
            try
            {
                customer_no = txtCustomer_No.Text;
                customer_fName = txtCustomer_Fname.Text;
                customer_lName = txtCustomer_Lname.Text;
                customerGender = comboBox_Customer.Text;
                customerNic = txtCustomer_NIC.Text;
                customerAddress = txtCustomer_Address.Text;

                SqlConnection con1 = new SqlConnection(connectionString);
                string query = "UPDATE customer SET FirstName = '" + customer_fName + "',LastName = '" + customer_lName + "',Gender  = '" + customerGender + "' , NIC = '" + customerNic + "' , Address = '" + customerAddress + "' WHERE CustomerNo=" + customer_no;
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

        private void btnC_clear_Click(object sender, EventArgs e)
        {
            txtCustomer_No.Clear();
            txtCustomer_Fname.Clear();
            txtCustomer_Lname.Clear();
            txtCustomer_Address.Clear();
            txtCustomer_NIC.Clear();
            txtCustomer_No.Focus();

        }
    }
}
