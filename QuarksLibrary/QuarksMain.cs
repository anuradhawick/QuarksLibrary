using MySql.Data.MySqlClient;
using QuarksLibrary.SearchAlgorithms;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace QuarksLibrary
{
    public partial class QuarksMain : Form
    {
        private SearchBooks search;
        public QuarksMain()
        {
            InitializeComponent();
            titleSearchRad.Select();
            searchBar.Select();
            fromText.Enabled = false;
            toText.Enabled = false;
            search = new SearchBooks(ref bookData, new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234"));
            bookData.ColumnCount = 7;
            bookData.Columns[0].Name = "Book Title";
            bookData.Columns[1].Name = "Category";
            bookData.Columns[2].Name = "Author";
            bookData.Columns[3].Name = "ISBN";
            bookData.Columns[4].Name = "Year";
            bookData.Columns[5].Name = "Copies";
            bookData.Columns[6].Name = "Available copies";
        }
        public void updateCategories()
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM quarkslib.category", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                categorySelect.Items.Add(reader.GetString("category"));
            }
            con.Close();
            categorySelect.SelectedIndex = 0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutQIS()).ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                (new UserCheckOut(bookData.SelectedRows[0].Cells[0].Value.ToString(), bookData.SelectedRows[0].Cells[1].Value.ToString(), bookData.SelectedRows[0].Cells[2].Value.ToString())).ShowDialog();
            }
            catch (Exception)
            {
                //Do nothing
            }
        }

        private void bookSearchButton_Click(object sender, EventArgs e)
        {
            bookData.Rows.Clear();
            if (checkYear.Checked)
            {
                try
                {
                    if (Int32.Parse(fromText.Text) > Int32.Parse(toText.Text))
                    {
                        MessageBox.Show("Years enters are invalid", "Search");
                        return;
                    }
                    else
                    {
                        search.setToYear = toText.Text;
                        search.setFromYear = fromText.Text;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Years enters are invalid", "Search");
                }
            }
            //search through title
            if (titleSearchRad.Checked)
            {
                if (searchBar.Text == "")
                {
                    MessageBox.Show("Book title should not be empty", "Book search");
                    return;
                }
                search.killThread();
                search.BookTitle = searchBar.Text;
                Thread searcher = new Thread(search.titleBookSearch);
                searcher.Start();
            }
            //search through category
            else if (CategorySearchRad.Checked)
            {
                if (searchBar.Text == "")
                {
                    MessageBox.Show("Book title should not be empty", "Book search");
                    return;
                }
                search.killThread();
                search.BookTitle = searchBar.Text;
                search.BookCategory = categorySelect.SelectedItem.ToString();
                Thread searcher = new Thread(search.categoryBookSearch);
                searcher.Start();
            }
            //search through ISBN
            else if (ISBNsearchRad.Checked)
            {
                if (searchBar.Text == "")
                {
                    MessageBox.Show("ISBN should not be empty", "Book search");
                    return;
                }
                search.killThread();
                search.setISBN = searchBar.Text;
                Thread searcher = new Thread(search.ISBNBookSearch);
                searcher.Start();
            }
            //search through Author
            else if (AuthSearchRad.Checked)
            {
                if (searchBar.Text == "" && authName.Text == "")
                {
                    MessageBox.Show("You must enter a book title/ author name before this operation", "Book search");
                    return;
                }
                search.killThread();
                search.setauth = authName.Text;
                search.BookTitle = searchBar.Text;
                Thread searcher = new Thread(search.authtitleSearch);
                searcher.Start();
            }
        }

        private void QuarksMain_Load(object sender, EventArgs e)
        {
            updateCategories();
        }

        private void searchBar_KeyUp(object sender, KeyEventArgs e)
        {
            if (searchBar.Text == "")
            {
                bookData.Rows.Clear();
                return;
            }
            else if (!ISBNsearchRad.Checked | Keys.Return == e.KeyCode)
            {
                bookSearchButton_Click(sender, e);
            }

        }

        private void checkYear_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkYear.Checked)
            {
                fromText.Enabled = true;
                toText.Enabled = true;
                search.setYearCheck = true;
            }
            else
            {
                search.setYearCheck = false;
                fromText.Enabled = false;
                toText.Enabled = false;
            }
        }

        private void authName_KeyUp(object sender, KeyEventArgs e)
        {
            if (AuthSearchRad.Checked)
            {
                if (searchBar.Text == "" && authName.Text == "")
                {
                    bookData.Rows.Clear();
                    return;
                }
                else
                {
                    bookSearchButton_Click(sender, e);
                }
            }
        }
    }
}
