using LibraryGUI.Model;
using MySql.Data.MySqlClient;

namespace LibraryGUI
{
    public partial class FormLibrary : Form
    {
        private string _connectionString = "Server=localhost;User=root;Password=1234;Database=test_sql_lesson";
        private MySqlConnection _connection;

        public FormLibrary()
        {
            InitializeComponent();
            _connection = new MySqlConnection(_connectionString);
        }

        private void FormLibrary_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = _connection;

            SelectBook(command);
            SelectReader(command);
            SelectSubscription(command);
        }

        public void SelectBook(MySqlCommand command)
        {
            _connection.Open();

            command.CommandText = "SELECT * FROM book b;";

            MySqlDataReader reader = command.ExecuteReader();
            List<Book> books = new List<Book>();

            while (reader.Read())
            {
                books.Add(new Book
                {
                    Id = reader.GetInt32("id"),
                    Title = reader.GetString("title"),
                    AuthorId = reader.GetInt32("author_id"),
                    PagesCount = reader.GetInt32("pages_count"),
                    Date = reader.IsDBNull(4) ? new DateTime() : reader.GetDateTime("date").Date
                });
            }

            _connection.Close();

            dataGridViewBook.DataSource = books;
        }

        public void SelectReader(MySqlCommand command)
        {
            _connection.Open();

            command.CommandText = "SELECT * FROM reader r;";

            MySqlDataReader reader = command.ExecuteReader();
            List<Reader> readers = new List<Reader>();

            while (reader.Read())
            {
                readers.Add(new Reader
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    Birthday = reader.GetDateTime("birthday"),
                    Organization = reader.IsDBNull(3) ? "Null" : reader.GetString("organization")
                });
            }

            _connection.Close();

            dataGridViewReader.DataSource = readers;
        }

        public void SelectSubscription(MySqlCommand command)
        {
            _connection.Open();

            command.CommandText = "SELECT * FROM subscription s;";

            MySqlDataReader reader = command.ExecuteReader();
            List<Subscription> subscriptions = new List<Subscription>();

            while (reader.Read())
            {
                subscriptions.Add(new Subscription
                {
                    Id = reader.GetInt32("id"),
                    ReaderId = reader.GetInt32("reader_id"),
                    BookId = reader.GetInt32("book_id"),
                    TakingDate = reader.GetDateTime("taking_date").Date,
                    BringDate = reader.GetDateTime("bring_date").Date,
                    IsReturn = reader.GetBoolean("is_return")
                });
            }

            _connection.Close();

            dataGridViewSubscription.DataSource = subscriptions;
        }
    }
}