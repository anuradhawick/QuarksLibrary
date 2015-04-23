using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarksLibrary.SearchAlgorithms
{
    class SearchBooks
    {
        private DataGridView datagrid;
        private MySqlConnection connection;
        private string bookTitle;
        private string ISBN;
        private string category;
        private string auth;
        private bool checkYear;
        private int killerVar;
        private string fromYear;
        private string toYear;
        public string BookTitle
        {
            set { bookTitle = value; }
        }
        public string BookCategory
        {
            set { category = value; }
        }
        public string setISBN
        {
            set { ISBN = value; }
        }
        public string setauth
        {
            set { auth = value; }
        }
        public bool setYearCheck
        {
            set { checkYear = value; }
        }
        public string setToYear
        {
            set { toYear = value; }
        }
        public string setFromYear
        {
            set { fromYear = value; }
        }
        public SearchBooks(ref DataGridView dataGrid, MySqlConnection connection)
        {
            this.connection = connection;
            this.datagrid = dataGrid;
            this.killerVar = 5;
        }
        public void killThread()
        {
            if (this.killerVar == 10)
            {
                this.killerVar = 5;
            }
            else
            {
                this.killerVar++;
            }
        }
        //search using the title provided
        public void titleBookSearch()
        {
            int threadV = killerVar;
            datagrid.Rows.Clear();
            connection.Open();
            string query = "SELECT * FROM quarkslib.book_data";
            if (checkYear)
            {
                query += " where pub_year_year >= '" + fromYear + "' and pub_year_year <= '" + toYear + "'";
            }
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (threadV != killerVar)
                {
                    connection.Close();
                    return;
                }
                if (StringMatchFinder.matchStrings(reader.GetString("title"), bookTitle))
                {
                    string[] row = { reader.GetString("title"), reader.GetString("category_category"), reader.GetString("author_name"), 
                                       reader.GetString("ISBN"), reader.GetString("pub_year_year"), reader.GetString("copies"),
                                       reader.GetString("availableCopies") };
                    datagrid.Rows.Add(row);
                }
            }
            connection.Close();
        }
        //search using the category
        public void categoryBookSearch()
        {
            int threadV = killerVar;
            datagrid.Rows.Clear();
            connection.Open();
            string query = "SELECT * FROM quarkslib.book_data where category_category = '" + category + "'";
            if (checkYear)
            {
                query += " and pub_year_year >= '" + fromYear + "' and pub_year_year <= '" + toYear + "'";
            }
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (threadV != killerVar)
                {
                    connection.Close();
                    return;
                }
                if (StringMatchFinder.matchStrings(reader.GetString("title"), bookTitle))
                {
                    string[] row = { reader.GetString("title"), reader.GetString("category_category"), reader.GetString("author_name"), 
                                       reader.GetString("ISBN"), reader.GetString("pub_year_year"), reader.GetString("copies"),
                                       reader.GetString("availableCopies") };
                    datagrid.Rows.Add(row);
                }
            }
            connection.Close();
        }
        //quick search by ISBN
        public void ISBNBookSearch()
        {
            int threadV = killerVar;
            datagrid.Rows.Clear();
            connection.Open();
            Console.WriteLine(ISBN);
            string query = "SELECT * FROM quarkslib.book_data where ISBN = '" + ISBN + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == false)
            {
                MessageBox.Show("Searched book does not exist", "ISBN search");
                connection.Close();
            }
            else
            {
                string[] row = { reader.GetString("title"), reader.GetString("category_category"), reader.GetString("author_name"), 
                                       reader.GetString("ISBN"), reader.GetString("pub_year_year"), reader.GetString("copies"),
                                       reader.GetString("availableCopies") };

                connection.Close();
                datagrid.Rows.Add(row);
            }
        }

        //search by author and title
        public void authtitleSearch()
        {
            int threadV = killerVar;
            datagrid.Rows.Clear();
            connection.Open();
            string query = "SELECT * FROM quarkslib.book_data";
            if (checkYear)
            {
                query += query += " where pub_year_year >= '" + fromYear + "' and pub_year_year <= '" + toYear + "'";
            }
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (threadV != killerVar)
                {
                    connection.Close();
                    return;
                }
                if ((bookTitle == "" ? true : StringMatchFinder.matchStrings(reader.GetString("title"), bookTitle)) && (auth == "" ? true : StringMatchFinder.matchStrings(reader.GetString("author_name"), auth)))
                {
                    string[] row = { reader.GetString("title"), reader.GetString("category_category"), reader.GetString("author_name"), 
                                       reader.GetString("ISBN"), reader.GetString("pub_year_year"), reader.GetString("copies"),
                                       reader.GetString("availableCopies") };
                    datagrid.Rows.Add(row);
                }
            }
            connection.Close();
        }
    }
}
