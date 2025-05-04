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

namespace DataExtraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=BIG-PP-9000\SQLEXPRESS;Initial Catalog=ProductDatabase;Integrated Security=True;");

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        // Loads Products to datagrid view from context
        private void LoadProducts()
        {
            try
            {
                using (var context = new ProductContext())
                {
                    dgv_products.DataSource = context.Products.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Adds new item to database
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ProductContext())
                {
                    // Creates new product object
                    var newProduct = new Product
                    {
                        ProductName = txb_name.Text,
                        Price = Convert.ToDecimal(txb_price.Text)
                    };

                    // Adds product to contect and saves it
                    context.Products.Add(newProduct);
                    context.SaveChanges();
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Updates existing item in database
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ProductContext())
                {
                    // Finds product with matching id
                    int id = int.Parse(txb_id.Text);
                    var product = context.Products.Find(id);

                    // if product exists changes attribute values
                    if (product != null)
                    {
                        product.ProductName = txb_name.Text;
                        product.Price = Convert.ToDecimal(txb_price.Text);
                        context.SaveChanges();
                        LoadProducts();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Deletes existing item from database
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ProductContext())
                {
                    // Finds product with matching id
                    int id = int.Parse(txb_id.Text);
                    var product = context.Products.Find(id);

                    // if product exists removes product.
                    if (product != null)
                    {
                        context.Products.Remove(product);
                        context.SaveChanges();
                        LoadProducts();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Refreshes dataset
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        // OnClick function to retrive data from rows
        private void dgv_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrives data from the first 3 cells of the selected row and adds them to text boxes
                txb_id.Text = dgv_products.Rows[e.RowIndex].Cells[0].Value.ToString();
                txb_name.Text = dgv_products.Rows[e.RowIndex].Cells[1].Value.ToString();
                txb_price.Text = dgv_products.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btn_search_click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ProductContext())
                {
                    // If a product name matches the text in the searchbar set datagridview to show only matching products
                    var results = context.Products.Where(p => p.ProductName.Contains(txb_search.Text)).ToList();
                    dgv_products.DataSource = results;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

  /* ADO.NET Implementation
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=BIG-PP-9000\SQLEXPRESS;Initial Catalog=ProductDatabase;Integrated Security=True;");

        // Auto generated code to populate dataGridView
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDatabaseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.productDatabaseDataSet.Products);

        }

        // Adds new item to database
        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txb_name.Text;
            // Converts string to double
            double price = Convert.ToDouble(txb_price.Text);
            string query = "INSERT INTO Products (ProductName, Price) VALUES (@name, @price);";

            try
            {
                // Connects to database adds needed values to connection string parameters, executes command
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.ExecuteNonQuery();
                this.productsTableAdapter.Fill(this.productDatabaseDataSet.Products);
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

        // Updates existing item in database
        private void btn_Update_Click(object sender, EventArgs e)
        {
            string name = txb_name.Text;
            double price = Convert.ToDouble(txb_price.Text);
            string id = txb_id.Text;
            string query = "UPDATE Products SET ProductName = @name, Price = @price WHERE ProductID = @id;";

            try
            {
                // Connects to database adds needed values to connection string parameters, executes command
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                this.productsTableAdapter.Fill(this.productDatabaseDataSet.Products);
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

        // Deletes existing item from database
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = txb_id.Text;
            string query = "DELETE FROM Products WHERE ProductID = @id;";
            try
            {
                // Connects to database adds needed values to connection string parameters, executes command
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                this.productsTableAdapter.Fill(this.productDatabaseDataSet.Products);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
            finally
            {
                connection.Close();
                txb_id.Clear();
                txb_name.Clear();
                txb_price.Clear();
            }
        }

        // Refreshes dataset
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.productDatabaseDataSet.Products);
        }

        // OnClick function to retrive data from rows
        private void dgv_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrives data from the first 3 cells of the selected row and adds them to text boxes
                txb_id.Text = dgv_products.Rows[e.RowIndex].Cells[0].Value.ToString();
                txb_name.Text = dgv_products.Rows[e.RowIndex].Cells[1].Value.ToString();
                txb_price.Text = dgv_products.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    } 
  */
}
