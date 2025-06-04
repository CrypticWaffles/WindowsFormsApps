using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class OrderProcessingForm : Form
    {
        // Dependencies passed from MainForm
        private MainForm mainForm;
        private User currentUser;

        // MongoDB Collections
        private IMongoCollection<Order> ordersCollection;
        private IMongoCollection<Item> menuCollection;

        // Data for the order being built
        private BindingList<OrderItemDetail> currentOrderItemsInCart;
        private decimal currentOrderTotal = 0m;

        // Data for managing selected existing orders
        private string selectedExistingOrderID;

        // Array to define the status progression
        private string[] STATUS_PROGRESSION = { "Placed", "In Kitchen", "Ready to Serve", "Served" };


        public OrderProcessingForm(User current, MainForm main)
        {
            InitializeComponent();

            mainForm = main;
            currentUser = current;

            InitializeDatabaseCollections();
            SetupOrderItemsDataGridView();
            LoadAllData();

            nud_quantity.Minimum = 1;
            nud_quantity.Value = 1;

            ClearOrderCreationFields();

            orderStatusTimer.Start();
        }

        private void InitializeDatabaseCollections()
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
                var databaseName = MongoUrl.Create(connectionString).DatabaseName;
                var mongoClient = new MongoClient(connectionString);
                var database = mongoClient.GetDatabase(databaseName);

                ordersCollection = database.GetCollection<Order>("orders");
                menuCollection = database.GetCollection<Item>("menuItems");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Configure the DataGridView for items in the current cart
        private void SetupOrderItemsDataGridView()
        {
            currentOrderItemsInCart = new BindingList<OrderItemDetail>();
            dgv_currentOrderItems.DataSource = currentOrderItemsInCart;

            // Manual column setup for dgv_currentOrderItems
            dgv_currentOrderItems.AutoGenerateColumns = false;

            // Clear existing columns if any from designer or previous runs
            dgv_currentOrderItems.Columns.Clear();

            dgv_currentOrderItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ItemName", HeaderText = "Item", DataPropertyName = "ItemName", ReadOnly = true });
            dgv_currentOrderItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Quantity", HeaderText = "Qty", DataPropertyName = "Quantity", ReadOnly = true });
            dgv_currentOrderItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "UnitPrice", HeaderText = "Unit Price", DataPropertyName = "UnitPrice", ReadOnly = true, DefaultCellStyle = { Format = "C2" } });
            dgv_currentOrderItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Subtotal", HeaderText = "Subtotal", DataPropertyName = "Subtotal", ReadOnly = true, DefaultCellStyle = { Format = "C2" } });

            // Adjust column widths
            dgv_currentOrderItems.Columns["ItemName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_currentOrderItems.Columns["Quantity"].Width = 60;
            dgv_currentOrderItems.Columns["UnitPrice"].Width = 90;
            dgv_currentOrderItems.Columns["Subtotal"].Width = 100;
        }


        // Load initial data for the form
        private void LoadAllData()
        {
            LoadMenuItems();
            LoadCustomerOrders();
        }

        // Loads available menu items into dgv_menu
        private void LoadMenuItems()
        {
            try
            {
                var items = menuCollection.Find(Builders<Item>.Filter.Empty).ToList();
                dgv_menu.DataSource = items;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading menu items: {ex.Message}", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Loads orders placed by the current user into dgv_customerOrders
        private void LoadCustomerOrders()
        {
            try
            {
                if (currentUser == null || string.IsNullOrEmpty(currentUser.UserID))
                {
                    MessageBox.Show("User not identified. Cannot load customer orders.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgv_customerOrders.DataSource = null;
                    return;
                }

                var filter = Builders<Order>.Filter.Eq("userID", currentUser.UserID);
                var orders = ordersCollection.Find(filter).SortByDescending(o => o.OrderDate).ToList();
                dgv_customerOrders.DataSource = orders;

                // Ensure dgv_customerOrders displays total
                if (dgv_customerOrders.Columns.Contains("TotalAmount"))
                {
                    dgv_customerOrders.Columns["TotalAmount"].DefaultCellStyle.Format = "C2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer orders: {ex.Message}", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper to recalculate and display the current order total
        private void UpdateOrderTotal()
        {
            currentOrderTotal = currentOrderItemsInCart.Sum(item => item.Subtotal);
            lbl_orderTotalValue.Text = currentOrderTotal.ToString("C2"); // Format as currency
        }

        // User selects a menu item (double-click)
        private void dgv_menu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Item selectedMenuItem = dgv_menu.Rows[e.RowIndex].DataBoundItem as Item;

                if (selectedMenuItem != null)
                {
                    txtb_selectedItemName.Text = selectedMenuItem.Name;
                    txtb_selectedItemPrice.Text = selectedMenuItem.Price.ToString("C2"); // Format as currency
                    nud_quantity.Value = 1; // Default quantity to 1
                }
            }
        }

        // Add selected menu item to the current order
        private void btn_addToOrder_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtb_selectedItemName.Text))
            {
                MessageBox.Show("Please select an item from the menu to add.", "Selection Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtb_selectedItemPrice.Text.Replace("$", ""), out decimal unitPrice))
            {
                MessageBox.Show("Invalid price for the selected item.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantity = (int)nud_quantity.Value;

            // Check if item already exists in the current cart to update quantity
            var existingOrderItem = currentOrderItemsInCart.FirstOrDefault(
                oi => oi.ItemName == txtb_selectedItemName.Text && oi.UnitPrice == unitPrice);

            if (existingOrderItem != null)
            {
                existingOrderItem.Quantity += quantity;
                dgv_currentOrderItems.Refresh();
            }
            else
            {
                // Add as a new item
                OrderItemDetail newItem = new OrderItemDetail
                {
                    ItemName = txtb_selectedItemName.Text,
                    Quantity = quantity,
                    UnitPrice = unitPrice
                };
                currentOrderItemsInCart.Add(newItem);
            }

            UpdateOrderTotal();
            ClearOrderCreationFields();
        }

        // Timer to update order status
        private void orderStatusTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                // Check if the timer is enabled
                var activeOrdersFilter = Builders<Order>.Filter.And(
                    Builders<Order>.Filter.Ne("status", "Served"),
                    Builders<Order>.Filter.Ne("status", "Cancelled")
                );

                // Fetch the next order to process
                var orderToProgress = ordersCollection.Find(activeOrdersFilter)
                                                      .SortBy(o => o.OrderDate)
                                                      .Limit(1) // Process one order per tick
                                                      .FirstOrDefault();

                if (orderToProgress != null)
                {
                    string currentStatus = orderToProgress.Status;
                    int currentIndex = Array.IndexOf(STATUS_PROGRESSION, currentStatus);

                    // Check if the current status is in our progression
                    if (currentIndex != -1 && currentIndex < STATUS_PROGRESSION.Length - 1)
                    {
                        // Get the next status in the sequence
                        string nextStatus = STATUS_PROGRESSION[currentIndex + 1];

                        // Update the order's status in MongoDB
                        var updateFilter = Builders<Order>.Filter.Eq("_id", new ObjectId(orderToProgress.OrderID));
                        var updateDefinition = Builders<Order>.Update.Set("status", nextStatus);
                        var result = ordersCollection.UpdateOne(updateFilter, updateDefinition);

                        if (result.ModifiedCount > 0)
                        {
                            System.Diagnostics.Debug.WriteLine($"Order {orderToProgress.OrderID} status updated: '{currentStatus}' -> '{nextStatus}'");
                        }
                    }
                }

                LoadCustomerOrders();

                // If an order was selected and its status changed, update the label immediately
                if (!string.IsNullOrEmpty(selectedExistingOrderID))
                {
                    var selectedOrder = ordersCollection.Find(o => o.OrderID == selectedExistingOrderID).FirstOrDefault();
                    if (selectedOrder != null)
                    {
                        lbl_selectedOrderStatus.Text = $"Status: {selectedOrder.Status} (Total: {selectedOrder.TotalAmount:C2})";
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in order status timer: {ex.Message}");
            }
        }

        // Remove selected item from the current order cart
        private void btn_removeFromOrder_Click(object sender, EventArgs e)
        {
            if (dgv_currentOrderItems.SelectedRows.Count > 0)
            {
                OrderItemDetail itemToRemove = dgv_currentOrderItems.SelectedRows[0].DataBoundItem as OrderItemDetail;
                if (itemToRemove != null)
                {
                    currentOrderItemsInCart.Remove(itemToRemove);
                    UpdateOrderTotal();
                }
            }
            else
            {
                MessageBox.Show("Please select an item in your current order to remove.", "Selection Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Place the new order
        private void btn_placeOrder_Click(object sender, EventArgs e)
        {
            if (currentOrderItemsInCart.Count == 0)
            {
                MessageBox.Show("Your order is empty. Please add items before placing the order.", "Order Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentUser == null || string.IsNullOrEmpty(currentUser.UserID))
            {
                MessageBox.Show("User not logged in. Cannot place order.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Order newOrder = new Order
                {
                    UserID = currentUser.UserID,
                    OrderDate = DateTime.Now,
                    Items = currentOrderItemsInCart.ToList(),
                    TotalAmount = currentOrderTotal,
                    Status = "Placed"
                };

                ordersCollection.InsertOne(newOrder);

                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the current order cart and refresh customer orders
                ClearOrderCreationFields();
                LoadCustomerOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error placing order: {ex.Message}", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // User selects an existing order from dgv_customerOrders
        private void dgv_customerOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Order selectedOrder = dgv_customerOrders.Rows[e.RowIndex].DataBoundItem as Order;
                if (selectedOrder != null)
                {
                    selectedExistingOrderID = selectedOrder.OrderID;
                    lbl_selectedOrderStatus.Text = $"Status: {selectedOrder.Status} (Total: {selectedOrder.TotalAmount:C2})";
                }
            }
        }

        // Refresh status of the selected customer order
        private void btn_refreshOrderStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedExistingOrderID))
            {
                MessageBox.Show("Please select an order to refresh its status.", "No Order Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var filter = Builders<Order>.Filter.Eq("_id", new ObjectId(selectedExistingOrderID));
                Order refreshedOrder = ordersCollection.Find(filter).FirstOrDefault();

                if (refreshedOrder != null)
                {
                    lbl_selectedOrderStatus.Text = $"Status: {refreshedOrder.Status} (Total: {refreshedOrder.TotalAmount:C2})";
                    MessageBox.Show($"Order ID: {refreshedOrder.OrderID}\nCurrent Status: {refreshedOrder.Status}", "Order Status Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomerOrders();
                }
                else
                {
                    lbl_selectedOrderStatus.Text = "Status: Order Not Found";
                    MessageBox.Show("Selected order not found in the database.", "Order Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing order status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel selected order
        private void btn_cancelSelectedOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedExistingOrderID))
            {
                MessageBox.Show("Please select an order to cancel.", "No Order Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to cancel this order? This action cannot be undone.",
                "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var filter = Builders<Order>.Filter.Eq("_id", new ObjectId(selectedExistingOrderID));
                    var update = Builders<Order>.Update.Set("status", "Cancelled");

                    var result = ordersCollection.UpdateOne(filter, update);

                    if (result.ModifiedCount > 0)
                    {
                        MessageBox.Show("Order has been cancelled.", "Order Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCustomerOrders(); // Refresh the list
                        ClearSelectedOrderDisplay(); // Clear status display
                    }
                    else
                    {
                        MessageBox.Show("Could not cancel order. It might already be cancelled or completed.", "Cancellation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error cancelling order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Helper to clear the fields for a new order
        private void ClearOrderCreationFields()
        {
            txtb_selectedItemName.Clear();
            txtb_selectedItemPrice.Clear();
            nud_quantity.Value = 1;
            UpdateOrderTotal();
        }

        // Helper to clear selected order status display
        private void ClearSelectedOrderDisplay()
        {
            selectedExistingOrderID = null;
            lbl_selectedOrderStatus.Text = "Status: -";
        }

        private void OrderPlacementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}