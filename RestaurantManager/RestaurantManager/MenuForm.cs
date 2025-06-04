using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class MenuForm : Form
    {
        // Dependencies passed from MainForm
        private MainForm mainForm;

        // MongoDB Collection
        private IMongoCollection<Item> menuCollection;

        // State variable for the selected menu item's ID
        private string selectedItemID; 

        // Default constructor 
        public MenuForm()
        {
            InitializeComponent();
            InitializeDatabaseCollection(); 
            LoadAllMenuItems(); 
            ClearItemFields(); 
        }

        // Main constructor
        public MenuForm(MainForm form) : this()
        {
            mainForm = form;
        }

        // Centralized method to initialize MongoDB collection
        private void InitializeDatabaseCollection()
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
                var databaseName = MongoUrl.Create(connectionString).DatabaseName;
                var mongoClient = new MongoClient(connectionString);
                var database = mongoClient.GetDatabase(databaseName);

                menuCollection = database.GetCollection<Item>("menuItems");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to database: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Loads all menu items into dgv_main
        private void LoadAllMenuItems()
        {
            try
            {
                var items = menuCollection.Find(Builders<Item>.Filter.Empty).ToList();
                dgv_main.DataSource = items;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading menu items: {ex.Message}", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add Item button click event 
        private void btn_add_Click(object sender, EventArgs e)
        {
            // Input Validation
            if (string.IsNullOrWhiteSpace(txtb_name.Text) ||
                string.IsNullOrWhiteSpace(txtb_desc.Text) ||
                string.IsNullOrWhiteSpace(txtb_category.Text))
            {
                MessageBox.Show("Please fill in all text fields (Name, Description, Category).", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtb_price.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid Price (positive number).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var item = new Item
                {
                    Name = txtb_name.Text.Trim(),
                    Description = txtb_desc.Text.Trim(),
                    Price = price,
                    Category = txtb_category.Text.Trim()
                };

                menuCollection.InsertOne(item);

                MessageBox.Show("Menu item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllMenuItems(); 
                ClearItemFields(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the menu item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Double-click event on dgv_main to select an item and populate fields
        private void dgv_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Item selectedItem = dgv_main.Rows[e.RowIndex].DataBoundItem as Item;

                if (selectedItem != null)
                {
                    selectedItemID = selectedItem.ItemID;
                    txtb_name.Text = selectedItem.Name;
                    txtb_desc.Text = selectedItem.Description;
                    txtb_price.Text = selectedItem.Price.ToString();
                    txtb_category.Text = selectedItem.Category;
                }
            }
        }

        // Update Item button click event
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedItemID))
            {
                MessageBox.Show("Please select an item to update by double-clicking it in the table.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Input Validation
            if (string.IsNullOrWhiteSpace(txtb_name.Text) ||
                string.IsNullOrWhiteSpace(txtb_desc.Text) ||
                string.IsNullOrWhiteSpace(txtb_category.Text))
            {
                MessageBox.Show("Please fill in all text fields (Name, Description, Category).", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtb_price.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid Price (positive number).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var filter = Builders<Item>.Filter.Eq("_id", new ObjectId(selectedItemID));
                var update = Builders<Item>.Update
                    .Set("Name", txtb_name.Text.Trim())
                    .Set("Description", txtb_desc.Text.Trim())
                    .Set("Price", price)
                    .Set("Category", txtb_category.Text.Trim());

                var result = menuCollection.UpdateOne(filter, update);

                if (result.ModifiedCount > 0)
                {
                    MessageBox.Show("Menu item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllMenuItems();
                    ClearItemFields();
                }
                else
                {
                    MessageBox.Show("No menu item was updated. It might not exist or no changes were made.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the menu item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete Item button click event
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedItemID))
            {
                MessageBox.Show("Please select an item to delete by double-clicking it in the table.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                $"Are you sure you want to delete '{txtb_name.Text}' from the menu? This action cannot be undone.",
                "Confirm Menu Item Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var filter = Builders<Item>.Filter.Eq("_id", new ObjectId(selectedItemID));
                    var result = menuCollection.DeleteOne(filter);

                    if (result.DeletedCount > 0)
                    {
                        MessageBox.Show("Menu item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllMenuItems();
                        ClearItemFields();
                    }
                    else
                    {
                        MessageBox.Show("No menu item was deleted. It might not exist.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Item ID format. This should not happen if ID is retrieved correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred during menu item deletion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Helper to clear input fields for menu item details
        private void ClearItemFields()
        {
            selectedItemID = null;
            txtb_name.Clear();
            txtb_desc.Clear();
            txtb_price.Clear();
            txtb_category.Clear();
        }

        // Event for when the form is closed
        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.Show();
            }
        }

        // Remove unused event handler (dgv_main_DoubleClick)
        // private void dgv_main_DoubleClick(object sender, EventArgs e)
        // {
        //     // This method is empty and redundant with dgv_main_CellDoubleClick, can be removed.
        // }

        // --- Optional: Input validation for price textbox ---
        // private void txtb_price_KeyPress(object sender, KeyPressEventArgs e)
        // {
        //     if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        //     {
        //         e.Handled = true;
        //     }
        //     if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
        //     {
        //         e.Handled = true;
        //     }
        // }
    }
}