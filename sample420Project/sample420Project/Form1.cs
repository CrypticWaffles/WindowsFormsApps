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

namespace sample420Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=BIG-PP-9000\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True;");

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txb_username.Text;
            password = txb_password.Text;

            try
            {
                string query = "SELECT * FROM Users WHERE Username = '" + username + "' AND Password = '" + password + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    // can let them login
                    MessageBox.Show("Login Successful.");
                }
                else
                {
                    // username or password is incorrect
                    MessageBox.Show("Invalid Login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txb_password.Clear();
                    txb_username.Clear();

                    txb_username.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
            finally 
            { 
                connection.Close(); 
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txb_password.Clear();
            txb_username.Clear();

            txb_username.Focus();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
