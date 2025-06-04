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
    public partial class Form1 : Form
    {
        IMongoCollection<Book> bookCollection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get connectionstring from app config
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

            // Get name of the database from conenction string
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;

            var mongoClient = new MongoClient(connectionString);

            // Get the database
            var database = mongoClient.GetDatabase(databaseName);

            // Get collection
            bookCollection = database.GetCollection<Book>("books");

            LoadBookData();
        }

        // Load data grid view
        private void LoadBookData()
        {
            var filterDefinition = Builders<Book>.Filter.Empty;

            var books = bookCollection.Find(filterDefinition).ToList();

            dgv_main.DataSource = books;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Title = txtbx_title.Text,
                Author = txtbx_author.Text,
                Pages = decimal.Parse(txtbx_pages.Text),
                Genre = txtbx_genre.Text
            };

            bookCollection.InsertOne(book);

            LoadBookData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<Book>.Filter.Eq("Title", txtbx_title.Text);
            bookCollection.DeleteOne(filterDefinition);
            LoadBookData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<Book>.Filter.Eq("Title", txtbx_title.Text);
            var updateDefinition = Builders<Book>.Update
                .Set("Author", txtbx_author.Text)
                .Set("Pages", decimal.Parse(txtbx_pages.Text))
                .Set("Genre", txtbx_genre.Text);

            bookCollection.UpdateOne(filterDefinition, updateDefinition);
            LoadBookData();
        }

        private void btn_titleSort_Click(object sender, EventArgs e)
        {
            var sortedBookds = bookCollection.Find(Builders<Book>.Filter.Empty)
                .Sort(Builders<Book>.Sort.Ascending("Title")).ToList();

            dgv_main.DataSource = sortedBookds;
        }

        private void btn_authorSort_Click(object sender, EventArgs e)
        {
            var sortedBookds = bookCollection.Find(Builders<Book>.Filter.Empty)
                .Sort(Builders<Book>.Sort.Ascending("Author")).ToList();

            dgv_main.DataSource = sortedBookds;
        }

        private void btn_pagesSort_Click(object sender, EventArgs e)
        {
            var sortedBookds = bookCollection.Find(Builders<Book>.Filter.Empty)
                .Sort(Builders<Book>.Sort.Ascending("Pages")).ToList();

            dgv_main.DataSource = sortedBookds;
        }

        private void btn_genreSort_Click(object sender, EventArgs e)
        {
            var sortedBookds = bookCollection.Find(Builders<Book>.Filter.Empty)
                .Sort(Builders<Book>.Sort.Ascending("Genre")).ToList();

            dgv_main.DataSource = sortedBookds;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var searchtext = txtb_search.Text;

            var filterSearch = Builders<Book>.Filter.Or(
                Builders<Book>.Filter.Regex("Title", new MongoDB.Bson.BsonRegularExpression(searchtext, "i")),
                Builders<Book>.Filter.Regex("Author", new MongoDB.Bson.BsonRegularExpression(searchtext, "i")),
                Builders<Book>.Filter.Regex("Genre", new MongoDB.Bson.BsonRegularExpression(searchtext, "i")),
                Builders<Book>.Filter.Regex("Pages", new MongoDB.Bson.BsonRegularExpression(searchtext, "i")));

            var sortedBooks = bookCollection.Find(filterSearch).ToList();

            dgv_main.DataSource = sortedBooks;
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            // Get Everything from database
            var books = bookCollection.Find(Builders<Book>.Filter.Empty).ToList();

            // Calculate total books
            var totalBooks = books.Count;

            // Average pages
            var averagePages = books.Average(b => b.Pages);

            // Most popular genre
            // Select genre from books, group by genre, order by count(*) Desc Limit 1;
            var popularGenre = books.GroupBy(b => b.Genre).OrderByDescending(g => g.Count()).FirstOrDefault().Key;

            var report = $"Total Books: {totalBooks}\n" +
                $"Average number of pages per book: {averagePages}\n" +
                $"Most popular genre: {popularGenre}.";

            MessageBox.Show(report, "Report Summary");
        }
    }
}
