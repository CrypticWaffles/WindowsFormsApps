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
using System.Xml.Linq;

namespace Form3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Populates People Data List View
        private void btnLoadPeople_Click(object sender, EventArgs e)
        {
            int count = lvPeopleData.Items.Count;

            // Read Data from database
            // Connect
            const string connectString = @"Server=BIG-PP-9000\SQLEXPRESS; Database=DEV310DB; User ID=DEV310DB_User; Password=abc123; TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            // Create Query
            string query = "SELECT name, personID FROM Person";

            // Query
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader[0].ToString();
                string id = reader[1].ToString();

                lvPeopleData.Items.Add(name);
                lvPeopleData.Items[count].SubItems.Add(id);
                count++;
            }

            // Close Db
            conn.Close();
        }

        // Pull data from Poeple Data List View into text boxes
        private void lvPeopleData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Get data from the list view
            string name = lvPeopleData.SelectedItems[0].SubItems[0].Text;
            string id = lvPeopleData.SelectedItems[0].SubItems[1].Text;

            //copy data into text box
            txtbName.Text = name;
            txtbID.Text = id;
        }

        // Populates Products List View
        private void btnLoadProducts_Click(object sender, EventArgs e)
        {
            int count = lvProductData.Items.Count;

            // Clear list view
            for (int i = 0; i < count; i++)
            {
                lvProductData.Items[0].Remove();
            }
            count = 0;

            // Read Data from database
            // Connect
            const string connectString = @"Server=BIG-PP-9000\SQLEXPRESS; Database=DEV310DB; User ID=DEV310DB_User; Password=abc123; TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            // Create Query
            string query = "SELECT * FROM Products WHERE InventoryAmount > 0";

            // Query
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader[0].ToString();
                string desc = reader[1].ToString();
                string ID = reader[2].ToString();
                string price = reader[3].ToString();
                string inv = reader[4].ToString();

                lvProductData.Items.Add(name);
                lvProductData.Items[count].SubItems.Add(desc);
                lvProductData.Items[count].SubItems.Add(price);
                lvProductData.Items[count].SubItems.Add(inv);
                lvProductData.Items[count].SubItems.Add(ID);
                count++;
            }

            // Close Db
            conn.Close();
        }

        private void lvProductData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Read Data from database
            // Connect
            const string connectString = @"Server=BIG-PP-9000\SQLEXPRESS; Database=DEV310DB; User ID=DEV310DB_User; Password=abc123; TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            // Create Query
            string query = @"UPDATE Products SET [inventoryAmount] = [inventoryAmount]-1 WHERE productID = @productID";
            string productID = lvProductData.SelectedItems[0].SubItems[4].Text;

            // Query
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.ExecuteNonQuery();

            // Create Query
            query = @"INSERT INTO SalesTransaction (ProductID, PersonID, PQuantity) VALUES (@proID, @perID, @quantity)";
            string personID = txtbID.Text;

            // Query
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@proID", productID);
            cmd.Parameters.AddWithValue("@perID", personID);
            cmd.Parameters.AddWithValue("@quantity", 1);
            cmd.ExecuteNonQuery();

            // Close Db
            conn.Close();

            // Get data from the views & Display in label
            string name = lvProductData.SelectedItems[0].SubItems[0].Text;
            string id = lvProductData.SelectedItems[0].SubItems[4].Text;
            label4.Text = "Thank you, " + txtbName.Text + ", for purchasing: " + name + " " + id;

            // Clear & Repopulate Products List View
            
            btnLoadProducts_Click(sender, e);
        }
    }
}
