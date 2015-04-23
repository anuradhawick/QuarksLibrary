using MySql.Data.MySqlClient;
using QuarksLibrary.LibraryActivities;
using QuarksLibrary.SearchAlgorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarksLibrary
{
    public partial class UserCheckOut : Form
    {
        private string bookTitle;
        private string authorName;
        private string ISBN;
        private MySqlConnection connection;
        private SearchDBUsers dbUsers;
        public UserCheckOut(string bookTitle, string authorName, string ISBN)
        {
            /*The constructor is passed with the parameters that are required to select the book from the
             * Data base. These are then called and updated for the remaining number of books
             * 
             * The button call of this method will add an entry for the burrower along with other details
             * */
            InitializeComponent();
            this.indexSearch.Select();
            this.bookTitle = bookTitle;
            this.authorName = authorName;
            this.ISBN = ISBN;
            titleLabel.Text = bookTitle;
            authorLabel.Text = authorName;
            ISBNlabel.Text = ISBN;
            this.connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234");
            this.dbUsers = new SearchDBUsers(ref searchResutGrid, this.connection);
            /*
             * these are temporary data for testing. datagrid view must be reconfigured
             */
            this.searchResutGrid.ColumnCount = 2;
            this.searchResutGrid.Columns[0].Name = "NIC";
            this.searchResutGrid.Columns[0].Width = 150;
            this.searchResutGrid.Columns[1].Name = "Name";
            this.searchResutGrid.Columns[1].Width = 450;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            subName.Text = null;
            subNIC.Text = null;
            subAdd.Text = null;
            subEmail.Text = null;
            subTel.Text = null;
            if (e.KeyCode == Keys.Space | e.KeyCode == Keys.Back | searchBar.Text.Equals(""))
            {
                searchResutGrid.Rows.Clear();
                return;
            }
            else if (indexSearch.Checked)
            {
                dbUsers.killThread();
                dbUsers.setNIC = searchBar.Text;
                Thread searcher = new Thread(dbUsers.searchByNIC);
                searcher.Start();
            }
            else
            {
                dbUsers.killThread();
                dbUsers.setName = searchBar.Text;
                Thread searcher = new Thread(dbUsers.searbyName);
                searcher.Start();
            }
        }

        private void searchResutGrid_Click(object sender, EventArgs e)
        {
            //this code will be updated with the correct data model
            try
            {
                subName.Text = searchResutGrid.SelectedRows[0].Cells[1].Value.ToString();
                subNIC.Text = searchResutGrid.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                //Do nothing
            }
        }

        private void returnBook_Click(object sender, EventArgs e)
        {
            this.connection.Open();
            string query = ""; //to search among books burrowed by the person selected
            MySqlCommand cmd = new MySqlCommand(query, this.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //search for the relevant book among the books that has been borrowed by the person
                //update the book status, user account and close the connection and return
            }
            this.connection.Close();
            //a message box is popped in case the book was not found among that has been borrowed by the person
        }

        private void bookCheckout_Click(object sender, EventArgs e)
        {
            if (subName.Text == "")
            {
                MessageBox.Show("Please select a user","Checkout");
                return;
            }
            //check if the user is able to borrow more books and the book has copies left to borrow

            //update the book status

            //update the user borrowings
            CheckOutPerformer perform = new CheckOutPerformer(subNIC.Text, ISBN, new MySqlConnection("datasource=localhost;port=3306;username=root;password=1234"));
            bool success = perform.checkOut();
            if (success)
            {
                MessageBox.Show("Checkout successful", "Checkout");
            }
            else
            {
                MessageBox.Show("Checkout failed! Same user has borrowed the book already", "Checkout");
            }
        }
    }
}
