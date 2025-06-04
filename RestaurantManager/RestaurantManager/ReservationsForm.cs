using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class ReservationsForm : Form
    {
        // Dependencies passed from MainForm
        private User currentUser;
        private MainForm mainForm;

        // MongoDB Collection
        private IMongoCollection<Reservation> reservationsCollection;

        // State variable for the selected reservation
        private string selectedResID;

        // Default constructor
        public ReservationsForm()
        {
            InitializeComponent();
        }

        // Main constructor
        public ReservationsForm(User user, MainForm main) : this()
        {
            currentUser = user;
            mainForm = main;

            lb_username.Text = "Logged in as: " + currentUser.Username; 

            InitializeDatabaseCollections(); 
            LoadUserReservations(); 
            ClearReservationFields(); 
        }

        // Centralized method to initialize MongoDB collections
        private void InitializeDatabaseCollections()
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
                var databaseName = MongoUrl.Create(connectionString).DatabaseName;
                var mongoClient = new MongoClient(connectionString);
                var database = mongoClient.GetDatabase(databaseName);

                reservationsCollection = database.GetCollection<Reservation>("reservations");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to database: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Loads reservations specific to the current user into dgv_main
        private void LoadUserReservations()
        {
            try
            {
                if (currentUser == null || string.IsNullOrEmpty(currentUser.UserID))
                {
                    MessageBox.Show("User not identified. Cannot load user reservations.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgv_main.DataSource = null;
                    return;
                }

                var filter = Builders<Reservation>.Filter.Eq("userID", currentUser.UserID);
                var reservations = reservationsCollection.Find(filter).SortByDescending(r => r.ReservationDate).ToList(); // Sort by date
                dgv_main.DataSource = reservations;

                if (dgv_main.Columns.Contains("ReservationDate"))
                {
                    dgv_main.Columns["ReservationDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user reservations: {ex.Message}", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add Reservation button click event
        private void btn_addReservation_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtb_tableNum.Text, out int tableNumber) || tableNumber <= 0)
            {
                MessageBox.Show("Please enter a valid Table Number (positive integer).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtb_numPeople.Text, out int numberOfPeople) || numberOfPeople <= 0)
            {
                MessageBox.Show("Please enter a valid Number of People (positive integer).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtp_date.Value < DateTime.Now.AddMinutes(-5))
            {
                MessageBox.Show("Reservation date and time cannot be in the past.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var reservation = new Reservation
                {
                    UserID = currentUser.UserID,
                    TableNumber = tableNumber,
                    ReservationDate = dtp_date.Value,
                    NumberOfPeople = numberOfPeople,
                    Status = "Pending"
                };

                reservationsCollection.InsertOne(reservation);

                MessageBox.Show("Reservation added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserReservations();
                ClearReservationFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update Reservation button click event
        private void btn_updateReservation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedResID))
            {
                MessageBox.Show("Please select a reservation to update by double-clicking it.", "No Reservation Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!int.TryParse(txtb_tableNum.Text, out int tableNumber) || tableNumber <= 0)
            {
                MessageBox.Show("Please enter a valid Table Number (positive integer).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtb_numPeople.Text, out int numberOfPeople) || numberOfPeople <= 0)
            {
                MessageBox.Show("Please enter a valid Number of People (positive integer).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtp_date.Value < DateTime.Now.AddMinutes(-5))
            {
                MessageBox.Show("Reservation date and time cannot be in the past for an update.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var filter = Builders<Reservation>.Filter.Eq("_id", new ObjectId(selectedResID));
                var update = Builders<Reservation>.Update
                    .Set("tableNumber", tableNumber)
                    .Set("reservationDate", dtp_date.Value)
                    .Set("numberOfPeople", numberOfPeople);

                var result = reservationsCollection.UpdateOne(filter, update);

                if (result.ModifiedCount > 0)
                {
                    MessageBox.Show("Reservation updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserReservations();
                    ClearReservationFields();
                }
                else
                {
                    MessageBox.Show("No reservation was updated. It might not exist or no changes were made.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel Reservation button click event
        private void btn_cancelReservation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedResID))
            {
                MessageBox.Show("Please select a reservation to cancel by double-clicking it in the table.", "No Reservation Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to cancel this reservation? This action cannot be undone.",
                "Confirm Reservation Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var filter = Builders<Reservation>.Filter.Eq("_id", new ObjectId(selectedResID));
                    var deleteResult = reservationsCollection.DeleteOne(filter);

                    if (deleteResult.DeletedCount > 0)
                    {
                        MessageBox.Show("Reservation cancelled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUserReservations();
                        ClearReservationFields();
                        ClearSelectedReservationStatus();
                    }
                    else
                    {
                        MessageBox.Show("No reservation was cancelled. It might not exist.", "Cancellation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Reservation ID format. This should not happen if ID is retrieved correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred during reservation cancellation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Double-click event on dgv_main to select a reservation and populate fields
        private void dgv_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Reservation selectedReservation = dgv_main.Rows[e.RowIndex].DataBoundItem as Reservation;

                if (selectedReservation != null)
                {
                    selectedResID = selectedReservation.ReservationID;
                    txtb_tableNum.Text = selectedReservation.TableNumber.ToString();
                    dtp_date.Value = selectedReservation.ReservationDate;
                    txtb_numPeople.Text = selectedReservation.NumberOfPeople.ToString();

                    lbl_selectedReservationStatus.Text = $"Status: {selectedReservation.Status}";
                }
            }
        }

        private void btn_refreshStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedResID))
            {
                MessageBox.Show("Please select a reservation to refresh its status.", "No Reservation Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var filter = Builders<Reservation>.Filter.Eq("_id", new ObjectId(selectedResID));
                Reservation refreshedReservation = reservationsCollection.Find(filter).FirstOrDefault();

                if (refreshedReservation != null)
                {
                    lbl_selectedReservationStatus.Text = $"Status: {refreshedReservation.Status}";
                    MessageBox.Show($"Reservation ID: {refreshedReservation.ReservationID}\nCurrent Status: {refreshedReservation.Status}", "Reservation Status Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserReservations(); 
                }
                else
                {
                    lbl_selectedReservationStatus.Text = "Status: Reservation Not Found";
                    MessageBox.Show("Selected reservation not found in the database.", "Reservation Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing reservation status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper to clear input fields for reservation details
        private void ClearReservationFields()
        {
            selectedResID = null;
            txtb_tableNum.Clear();
            dtp_date.Value = DateTime.Now;
            txtb_numPeople.Clear();
            ClearSelectedReservationStatus();
        }

        // Helper to clear the status label for selected reservation
        private void ClearSelectedReservationStatus()
        {
            lbl_selectedReservationStatus.Text = "Status: -";
        }

        // KeyPress event for txtb_tableNum to only accept integers
        private void txtb_tableNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // KeyPress event for txtb_numPeople to only accept integers
        private void txtb_numPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ReservationsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}