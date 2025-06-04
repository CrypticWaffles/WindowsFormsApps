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
    public partial class RegisterForm : Form
    {
        IMongoCollection<User> usersCollection;

        public RegisterForm()
        {
            InitializeComponent();

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

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            // Get info from user
            string username = txtb_username.Text;
            string password = txtb_password.Text;
            string email = txtb_email.Text;
            string role = cmb_role.Text.ToLower();

            // Check if user exists, else error
            var filter = Builders<User>.Filter.Eq("username", username);

            var existingUser = usersCollection.Find(filter).FirstOrDefault();

            if (existingUser == null)
            {
                // Add user to DB
                var user = new User
                {
                    Username = username,
                    Password = password,
                    Email = email,
                    Role = role
                };

                usersCollection.InsertOne(user);

                MessageBox.Show("Registration Complete.");
                MainForm form = new MainForm();
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username already exists. Please choose a different one.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
