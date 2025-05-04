using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Connect
            const string connectString = @"Server=BIG-PP-9000\SQLEXPRESS; Database=DEV310DB; User ID=DEV310DB_User; Password=abc123; TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            // Create Query
            string query = "AddProduct";
            using (XmlReader reader = XmlReader.Create(@"E:\DevDrive\DEV310\DEV310\productDataDEV310.xml"))
            {
                string productName = "", productDesc = "", productPrice = "", productInv = "";
                ListViewItem currentItem = null;

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        string elementName = reader.Name;
                        reader.Read(); // Move to value

                        if (reader.NodeType == XmlNodeType.Text && !string.IsNullOrWhiteSpace(reader.Value))
                        {
                            switch (elementName)
                            {
                                case "Name":
                                    productName = reader.Value;
                                    currentItem = new ListViewItem(productName);
                                    lvProductData.Items.Add(currentItem);
                                    break;
                                case "Description":
                                    productDesc = reader.Value;
                                    currentItem?.SubItems.Add(productDesc);
                                    break;
                                case "Price":
                                    productPrice = reader.Value;
                                    currentItem?.SubItems.Add(productPrice);
                                    break;
                                case "InventoryAmount":
                                    productInv = reader.Value;
                                    currentItem?.SubItems.Add(productInv);

                                    // Execute database insert
                                    using (SqlCommand cmd = new SqlCommand("AddProduct", conn))
                                    {
                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.Parameters.AddWithValue("@name", productName);
                                        cmd.Parameters.AddWithValue("@desc", productDesc);
                                        cmd.Parameters.AddWithValue("@price", productPrice);
                                        cmd.Parameters.AddWithValue("@inv", productInv);
                                        cmd.ExecuteNonQuery(); // Run the query
                                    }

                                    // Reset for the next product
                                    productName = productDesc = productPrice = productInv = "";
                                    currentItem = null;
                                    break;
                            }
                        }
                    }
                }
            }

            // Close Connection
            conn.Close();
        }
    }
}

