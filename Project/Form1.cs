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
using System.Data.SqlClient;

namespace Project
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection (@"Data Source=DESKTOP-KPFQESI\SQLEXPRESS;Initial Catalog=project;Integrated Security=True ");
       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName , password;
            userName = txtUser.Text;
            password = txtPassword.Text;

            try
            {
                string querry = "SELECT * FROM admin WHERE UserName = '"+ txtUser.Text +"' AND Password = '"+ txtPassword.Text +"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0) 
                {
                    userName = txtUser.Text;
                    password = txtPassword.Text;

                    
                    frmsecond t = new frmsecond();
                    t.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details");
                    txtUser.Clear();
                    txtPassword.Clear();
                    txtUser.Focus();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
            txtUser.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar=true;
            }
        }
    }
}
