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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Populate Form
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int count = lvPersonData.Items.Count;
            // Read Data from database

            // Connect
            const string connectString = @"Server=BIG-PP-9000\SQLEXPRESS; Database=DEV310DB; User ID=DEV310DB_User; Password=abc123; TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            // Create Query
            string query = "SELECT * FROM Person";

            // Query
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader[0].ToString(); 
                string email = reader[1].ToString();
                string phone = reader[2].ToString();
                string id = reader[3].ToString();

                lvPersonData.Items.Add(name);
                lvPersonData.Items[count].SubItems.Add(phone);
                lvPersonData.Items[count].SubItems.Add(email);
                lvPersonData.Items[count].SubItems.Add(id);
                count++;
            }

            // Close Db
            conn.Close();
        }

        // Clear Form
        private void btnClearListView_Click(object sender, EventArgs e)
        {
            int count = lvPersonData.Items.Count;

            for (int i = 0; i < count; i++)
            {
                lvPersonData.Items[0].Remove();
            }

            count = 0;
        }

        // Get individual form data
        private void lvPersonData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Get data from the list view
            string name = lvPersonData.SelectedItems[0].SubItems[0].Text;
            string phone = lvPersonData.SelectedItems[0].SubItems[1].Text;
            string email = lvPersonData.SelectedItems[0].SubItems[2].Text;
            string id = lvPersonData.SelectedItems[0].SubItems[3].Text;

            //copy data into text box
            txbName.Text = name;
            txbPhone.Text = phone;
            txbEmail.Text = email;
            txbID.Text = id;
        }

        // Edit Form Data
        private void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            // Connect
            const string connectString = @"Server=BIG-PP-9000\SQLEXPRESS; Database=DEV310DB; User ID=DEV310DB_User; Password=abc123; TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            // Create Query
            string query = "UpdatePerson";

            string name = txbName.Text;
            string phone = txbPhone.Text;
            string email = txbEmail.Text;
            string id = txbID.Text;

            // Query
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@personID", id);

            cmd.ExecuteNonQuery();

            // Close Db
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if txtb is empty
            if (!String.IsNullOrEmpty(txbID.Text)) 
            {
                // Delete record from DB
                // Connect
                const string connectString = @"Server=BIG-PP-9000\SQLEXPRESS; Database=DEV310DB; User ID=DEV310DB_User; Password=abc123; TrustServerCertificate=True;";
                SqlConnection conn = new SqlConnection(connectString);
                conn.Open();

                // Create Query
                string query = "DeletePerson";
                string personID = txbID.Text;

                // Query
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PersonID", personID);

                cmd.ExecuteNonQuery();

                // Close Db
                conn.Close();
            }
        }

        // Add to DB
        private void button2_Click(object sender, EventArgs e)
        {
            // Connect
            const string connectString = @"Server=BIG-PP-9000\SQLEXPRESS; Database=DEV310DB; User ID=DEV310DB_User; Password=abc123; TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            // Create Query
            string query = "InsertPerson";

            // Query
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", txbAddName.Text);
            cmd.Parameters.AddWithValue("@phone", txbAddPhone.Text);
            cmd.Parameters.AddWithValue("@email", txbAddEmail.Text);

            cmd.ExecuteNonQuery();

            // Close Db
            conn.Close();
        }
    }
}
