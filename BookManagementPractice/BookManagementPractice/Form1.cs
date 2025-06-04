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

namespace BookManagementPractice
{
    public partial class Form1 : Form
    {
        IMongoCollection<Book> bookCollection;
        public Form1()
        {
            InitializeComponent();
        }

        IMongoCollection<Movie> movieCollection;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get connection string from app config
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

            // Get the name of the database from connection string
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;

            var mongoClient = new MongoClient(connectionString);

            //get the database
            var database = mongoClient.GetDatabase(databaseName);

            //get the collection
            bookCollection = database.GetCollection<Book>("books");
            movieCollection = database.GetCollection<Movie>("movies");

            LoadBookData();
            LoadMovieData();
        }

        private void LoadBookData()
        {
            var filterDefinition = Builders<Book>.Filter.Empty;

            var books = bookCollection.Find(filterDefinition).ToList();

            dataGridView1.DataSource = books;
        }

        private void LoadMovieData()
        {
            var filterDefinition = Builders<Movie>.Filter.Empty;

            var movies = movieCollection.Find(filterDefinition).ToList();

            dataGridView2.DataSource = movies;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Title = textBox_title.Text,
                Author = textBox_Author.Text,
                Pages = decimal.Parse(textBox_Pages.Text),
                Genre = textBox_Genre.Text,
            };

            bookCollection.InsertOne(book);

            LoadBookData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<Book>.Filter.Eq("Title", textBox_title.Text);
            bookCollection.DeleteOne(filterDefinition);
            LoadBookData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<Book>.Filter.Eq("Title", textBox_title.Text);
            var updateDefinition = Builders<Book>.Update
                .Set("Author", textBox_Author.Text)
                .Set("Pages", decimal.Parse(textBox_Pages.Text))
                .Set("Genre", textBox_Genre.Text);

            bookCollection.UpdateOne(filterDefinition, updateDefinition);
            LoadBookData();
        }

        private void button_MovieAdd_Click(object sender, EventArgs e)
        {
            var movie = new Movie
            {
                Title = textBox_MovieTitle.Text,
                Director = textBox_Director.Text,
                Runtime = decimal.Parse(textBox_Runtime.Text),
                Genre = textBox_MovieGenre.Text,
                Year = decimal.Parse(textBox_Year.Text)
            };

            movieCollection.InsertOne(movie);

            LoadMovieData();
        }

        private void button_MovieDelete_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<Movie>.Filter.Eq("Title", textBox_MovieTitle.Text);
            movieCollection.DeleteOne(filterDefinition);
            LoadMovieData();
        }

        private void button_MovieUpdate_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<Movie>.Filter.Eq("Title", textBox_MovieTitle.Text);
            var updateDefinition = Builders<Movie>.Update
                .Set("Director", textBox_Director.Text)
                .Set("Runtime", decimal.Parse(textBox_Runtime.Text))
                .Set("Genre", textBox_MovieGenre.Text)
                .Set("Year", decimal.Parse(textBox_Year.Text));

            movieCollection.UpdateOne(filterDefinition, updateDefinition);
            LoadMovieData();
        }
    }
}
