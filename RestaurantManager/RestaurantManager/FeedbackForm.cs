using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class FeedbackForm : Form
    {
        // Dependencies passed from MainForm
        private MainForm mainForm;
        private User currentUser;

        // MongoDB Collection
        private IMongoCollection<Feedback> feedbackCollection;

        // Default constructor
        public FeedbackForm()
        {
            InitializeComponent();
        }

        // Main constructor
        public FeedbackForm(User current, MainForm main) : this()
        {
            mainForm = main;
            currentUser = current;

            InitializeDatabaseCollection();
            LoadAllFeedback();
            ClearFeedbackFields();
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

                feedbackCollection = database.GetCollection<Feedback>("feedback");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to database: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Loads all feedback into dgv_feedback
        private void LoadAllFeedback()
        {
            try
            {
                var feedback = feedbackCollection.Find(Builders<Feedback>.Filter.Empty)
                                                 .SortByDescending(f => f.SubmissionDate)
                                                 .ToList();
                dgv_feedback.DataSource = feedback;

                if (dgv_feedback.Columns.Contains("SubmissionDate"))
                {
                    dgv_feedback.Columns["SubmissionDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading feedback: {ex.Message}", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Submit Feedback button click event
        private void btn_submitFeedback_Click(object sender, EventArgs e)
        {
            // Input Validation
            if (string.IsNullOrWhiteSpace(txtb_orderId.Text))
            {
                MessageBox.Show("Please enter your Order ID.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rating = (int)nud_rating.Value;

            if (string.IsNullOrWhiteSpace(txtb_comment.Text))
            {
                MessageBox.Show("Please provide a comment.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var feedback = new Feedback
                {
                    OrderID = txtb_orderId.Text.Trim(),
                    Rating = rating,
                    Comment = txtb_comment.Text.Trim(),
                    SubmissionDate = DateTime.Now,
                    UserID = currentUser?.UserID
                };

                feedbackCollection.InsertOne(feedback);

                MessageBox.Show("Thank you for your feedback!", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllFeedback();
                ClearFeedbackFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while submitting feedback: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper to clear input fields for feedback submission
        private void ClearFeedbackFields()
        {
            txtb_orderId.Clear();
            nud_rating.Value = nud_rating.Maximum;
            txtb_comment.Clear();
        }

        // Event for when the form is closed
        private void FeedbackForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.Show();
            }
        }
    }
}