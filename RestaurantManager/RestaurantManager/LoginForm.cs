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
    public partial class LoginForm : Form
    {
        IMongoCollection<User> usersCollection;

        public LoginForm()
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
                MainForm mainForm = new MainForm(username);
                mainForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
            }
        }

        // Return to starting form
        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
