using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Library
{
    public partial class Form1 : Form
    {
        private const string connectionString = @"Data Source=KOMPUTER;Initial Catalog=Library;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, Title, Author, Publication_Year, Genre, Client FROM BookJournal";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* using (SqlConnection connection = new SqlConnection(connectionString))
             {
                 string query =  $"insert into BookJournal (Title, Author, Publication_Year, Genre, Client) values ({titleBox.Text}, {authorBox.Text}, {yearBox.Text}, {genreBox.Text}, {clientBox.Text})";

                 SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                 try
                 {
                     connection.Open();
                     adapter.SelectCommand.ExecuteNonQuery();
                     MessageBox.Show("Запись добавлена успешно");
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}");
                 }

             }*/
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO BookJournal (Title, Author, Publication_Year, Genre, Client) " +
                               "VALUES (@Title, @Author, @Publication_Year, @Genre, @Client)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", titleBox.Text);
                command.Parameters.AddWithValue("@Author", authorBox.Text);
                command.Parameters.AddWithValue("@Publication_Year", yearBox.Text);
                command.Parameters.AddWithValue("@Genre", genreBox.Text);
                command.Parameters.AddWithValue("@Client", clientBox.Text);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Запись добавлена успешно");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось добавить запись");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int bookId = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["ID"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM BookJournal WHERE ID = @ID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", bookId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
