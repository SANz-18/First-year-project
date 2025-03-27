using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Employee : Form
    {
        private string Emp_ID;
        private string First_Name;
        private string Last_Name;
        private string gender;
        private string nic;
        private string address;
        private int index;

        DBconnection con;

        private BindingSource bindingSource = new BindingSource();
        private string connectionString = @"Data Source=DESKTOP-KPFQESI\SQLEXPRESS;Initial Catalog=project;Integrated Security=True";

        public Employee()
        {
            InitializeComponent();
            try
            {
                con = DBconnection.getDBconnection();
                dgvEmployee.DataSource = bindingSource;
                refreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool isDataValid()
        {
            Emp_ID = txtemp_No.Text;
            First_Name = txtFName.Text;
            Last_Name = txtLName.Text;
           // gender = txtGender.Text;
           gender = comboBox_Emp.Text;
            nic = txtNIC.Text;
            address = txt_Address.Text;

            if (Emp_ID == string.Empty || First_Name == string.Empty)
            {
                MessageBox.Show("Both No. and Name of the Employee must be entered");
                return false;
            }
            return true;
        }


        private void btnE_back_Click(object sender, EventArgs e)
        {
            frmsecond frmsecond = new frmsecond();
            frmsecond.Show();
            this.Hide();
        }

        private void btnE_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (isDataValid())
                {
                    string query1 = "INSERT INTO Employeeee (Emp_ID, First_Name, Last_Name, Gender, NIC, Address) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')";
                    query1 = string.Format(query1, Emp_ID, First_Name, Last_Name, gender,nic,address);
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
            string sqlForSelectingAll = "select * from Employeeee";
            bindingSource.DataSource = con.getDataTable(sqlForSelectingAll);
            // Resize the DataGridView columns to fit the newly loaded content.
            dgvEmployee.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dgvEmployee.Rows[index];
            txtemp_No.Text = row.Cells[0].Value.ToString();
            txtFName.Text = row.Cells[1].Value.ToString();
            txtLName.Text = row.Cells[2].Value.ToString();
            comboBox_Emp.Text = row.Cells[3].Value.ToString();
            txtNIC.Text = row.Cells[4].Value.ToString();
            txt_Address.Text = row.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           // index = dgvEmployee.CurrentCell.RowIndex;
           // dgvEmployee.Rows.RemoveAt(index);
            try
            {
                DataGridViewRow row = dgvEmployee.Rows[index];
                if(MessageBox.Show(string.Format("You sure want to delete selected row?", row.Cells["Emp_ID"].Value),"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using(SqlConnection con1 = new SqlConnection(connectionString))
                    {
                        using(SqlCommand cmd = new SqlCommand("Delete from Employeeee where Emp_ID=@Emp_ID", con1))
                        {
                            cmd.Parameters.AddWithValue("Emp_ID", row.Cells["Emp_ID"].Value);
                            con1.Open();
                            cmd.ExecuteNonQuery();
                            con1.Close();
                        }

                    }
                }
                /*string query2 = "DELETE from database.Employeeee where Emp_ID = '" & txtemp_No.Text & "'";
            query2 = string.Format(query2, Emp_ID, First_Name, Last_Name, gender, nic, address);
                con.executeInsertUpdateQuery(query2);
                string query1 = "DELETE FROM Employeeee (Emp_ID, First_Name, Last_Name, Gender, NIC, Address) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')";
                query1 = string.Format(query1, Emp_ID, First_Name, Last_Name, gender, nic, address);
                con.executeInsertUpdateQuery(query1);

                refreshGrid();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnE_update_Click(object sender, EventArgs e)
        {
            try
            {
                Emp_ID = txtemp_No.Text;
                First_Name = txtFName.Text;
                Last_Name = txtLName.Text;
                gender = comboBox_Emp.Text;
                nic = txtNIC.Text;
                address = txt_Address.Text;

                SqlConnection con1 = new SqlConnection(connectionString);
                string query = "UPDATE Employeeee SET First_Name  = '" + First_Name + "',Last_Name = '" + Last_Name + "',Gender  = '" + gender + "' , NIC  = '" + nic + "' , Address = '"+address+ "' WHERE Emp_ID=" + Emp_ID;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtemp_No.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtNIC.Clear();
            txt_Address.Clear();
            txtemp_No.Focus();
        }
    }
}
