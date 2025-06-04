using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class MainForm : Form
    {
        public string username;

        // MongoDB Collection
        IMongoCollection<User> usersCollection;

        // Dependencies passed from Form1
        User currentUser;

        public MainForm()
        {
            InitializeComponent();
        }

        // Alternate constructor including a parameter
        public MainForm(string usernameF) : this()
        {
            InitializeDatabaseCollection();
            username = usernameF;
            lb_login.Text = "Logged in as: " + username;
            currentUser = GetUser(username);

            lb_role.Text = "Role: " + currentUser.Role;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        public User GetUser(string username)
        {
            var filter = Builders<User>.Filter.Eq("username", username);
            return usersCollection.Find(filter).FirstOrDefault();
        }

        // Centralized method to initialize MongoDB collection
        public void InitializeDatabaseCollection()
        {
            try
            {
                // Get connectionstring from app config
                var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

                // Get name of the database from conenction string
                var databaseName = MongoUrl.Create(connectionString).DatabaseName;

                var mongoClient = new MongoClient(connectionString);

                // Get the database
                var database = mongoClient.GetDatabase(databaseName);

                // Get collection
                usersCollection = database.GetCollection<User>("users");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to database: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(this);
            menuForm.Show();
            this.Hide();
        }

        private void btn_reservations_Click(object sender, EventArgs e)
        {
            ReservationsForm reservationsForm = new ReservationsForm(currentUser, this);
            reservationsForm.Show();
            this.Hide();
        }

        private void btn_ordersPro_Click(object sender, EventArgs e)
        {
            OrderProcessingForm orderProcessingForm = new OrderProcessingForm(currentUser, this);
            orderProcessingForm.Show();
            this.Hide();
        }

        private void btn_feedback_Click(object sender, EventArgs e)
        {
            FeedbackForm feedbackForm = new FeedbackForm(currentUser, this);
            feedbackForm.Show();
            this.Hide();
        }
    }
}
