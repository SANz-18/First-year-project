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
    public partial class frmAdmin : Form
    {
        private string user;
        private string pass;

        DBconnection con;

        private BindingSource bindingSource = new BindingSource();
        public frmAdmin()
        {
            InitializeComponent();
            try
            {
                con = DBconnection.getDBconnection();
                dgvAdmin.DataSource = bindingSource;
                refreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool isDataValid()
        {
            user = txt_user.Text;
            pass = txt_Password.Text;
           

            if (user == string.Empty || pass == string.Empty)
            {
                MessageBox.Show("You must enter all data");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (isDataValid())
                {
                    string query1 = "INSERT INTO admin (UserName,Password ) VALUES('{0}','{1}')";
                    query1 = string.Format(query1, user, pass);
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
            string sqlForSelectingAll = "select * from admin";
            bindingSource.DataSource = con.getDataTable(sqlForSelectingAll);
            // Resize the DataGridView columns to fit the newly loaded content.
            dgvAdmin.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btn_adminBack_Click(object sender, EventArgs e)
        {

            frmsecond frmsecond = new frmsecond();
            frmsecond.Show();
            this.Hide();
        }
    }
}
