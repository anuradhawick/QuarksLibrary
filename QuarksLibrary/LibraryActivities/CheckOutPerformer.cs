using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarksLibrary.LibraryActivities
{

    class CheckOutPerformer
    {
        private MySqlConnection connection;
        private MySqlDataReader reader;
        private string userNIC;
        private string bookISBN;
        public CheckOutPerformer(string userNIC,string bookISBN,MySqlConnection connection)
        {
            this.userNIC = userNIC;
            this.bookISBN = bookISBN;
            this.connection = connection;
        }

        
        public bool checkOut()
        {
            connection.Open();
            string query = "SELECT * FROM quarkslib.borrowings where user_NIC = "+"'"+this.userNIC+"'";
            MySqlCommand cmd = new MySqlCommand(query, this.connection);
            reader = cmd.ExecuteReader();
            string borrowedISBN;
            //checking if the user has borrowed the same book before, if so illegal move by the user
            while (reader.Read())
            {
                borrowedISBN = reader.GetString("ISBN");
                if (borrowedISBN.Equals(bookISBN))
                {
                    connection.Close();
                    return false;
                }
            }
            //adding the borrowed book details to the book borrowings of the user
            query = "INSERT INTO quarkslib.borrowings values('"+userNIC+"','"+bookISBN+"','"+"2011/1/1"+"','"+"2011/12/31')";
            reader.Close();
            MySqlCommand cmd2 = new MySqlCommand(query, connection);
            cmd2.ExecuteReader();
            connection.Close();
            return true;
        }
        //below method requires modification
        public void updateBookStatus()
        {
            connection.Open();
            string query = "SELECT * FROM quarkslib.borrowings where user_NIC = " + "'" + this.userNIC + "'";
            MySqlCommand cmd = new MySqlCommand(query, this.connection);
            reader = cmd.ExecuteReader();
            string borrowedISBN;
            //checking if the user has borrowed the same book before, if so illegal move by the user
            while (reader.Read())
            {
                borrowedISBN = reader.GetString("ISBN");
                if (borrowedISBN.Equals(bookISBN))
                {
                    connection.Close();
                    //return false;
                }
            }
            //adding the borrowed book details to the book borrowings of the user
            query = "INSERT INTO quarkslib.borrowings values('" + userNIC + "','" + bookISBN + "','" + "2011/1/1" + "','" + "2011/12/31')";
            reader.Close();
            MySqlCommand cmd2 = new MySqlCommand(query, connection);
            cmd2.ExecuteReader();
            connection.Close();
            //return true;
        }
    }
}
