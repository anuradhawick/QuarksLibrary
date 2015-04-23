using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarksLibrary
{
    public partial class UpdateLibrary : Form
    {
        MySqlConnection connection;
        public UpdateLibrary()
        {
            InitializeComponent();
            connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234");
        }
        private void updateCategoryList()
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM quarkslib.category", connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                bookCategory.Items.Add(reader.GetString("category"));
            }
            connection.Close();
            bookCategory.SelectedIndex = 0;
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            updateCategoryList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM quarkslib.book_data where ISBN = '" + ISBNtext.Text + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("The book is not available", "Update Library");
                titleText.Text = "";
                AuthorName.Text = "";
                YearText.Text = "";
                bookCategory.Text = "";
                copies.Text = "";
            }
            else
            {
                titleText.Text = reader.GetString("title");
                AuthorName.Text = reader.GetString("author_name");
                YearText.Text = reader.GetString("pub_year_year");
                bookCategory.Text = reader.GetString("category_category");
                copies.Text = reader.GetString("copies");
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM quarkslib.book_data where ISBN = '" + ISBNtext.Text + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("The book is not available", "Update Library");
            }
            else
            {
                connection.Close();
                button1_Click(sender, e);
                connection.Open();
                DialogResult res = MessageBox.Show("Are you sure you want to delete?", "Update Library", MessageBoxButtons.YesNo);
                if (res == DialogResult.No)
                {
                    connection.Close();
                    return;
                }
                query = "DELETE FROM quarkslib.book_data where ISBN = '" + ISBNtext.Text + "'";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteReader();
            }
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
