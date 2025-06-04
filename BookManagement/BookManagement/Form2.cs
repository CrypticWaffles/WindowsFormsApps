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

namespace BookManagement
{
    public partial class loginForm : Form
    {
        IMongoCollection<User> usersCollection;

        public loginForm()
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


        private void btn_login_Click(object sender, EventArgs e)
        {
            // Get info from user
            string username = txtb_username.Text;
            string password = txtb_password.Text;

            // Check user info against DB for match
            var filter = Builders<User>.Filter.Eq("username", username) &
                Builders<User>.Filter.Eq("password", password);

            var user = usersCollection.Find(filter).FirstOrDefault();

            // If match, send to form1, else error
            if (user != null)
            {
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            // Get info from user
            string username = txtb_username.Text;
            string password = txtb_password.Text;

            // Check if user exists, else error
            var filter = Builders<User>.Filter.Eq("username", username);

            var existingUser = usersCollection.Find(filter).FirstOrDefault();

            if (existingUser == null)
            {
                // Add user to DB
                var user = new User
                {
                    Username = username,
                    Password = password
                };

                usersCollection.InsertOne(user);

                MessageBox.Show("Registration Complete.");
            }
            else
            {
                MessageBox.Show("Username already exists. Please choose a different one.");
            }
            // Add user to DB

        }
    }
}
