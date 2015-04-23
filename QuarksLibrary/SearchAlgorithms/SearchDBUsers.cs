using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarksLibrary.SearchAlgorithms
{
    class SearchDBUsers
    {
        private MySqlConnection connection;
        private MySqlDataReader reader;
        private DataGridView dataGrid;
        private int killerVar;
        private string NIC;
        private string Name;
        public string setNIC
        {
            set { NIC = value; }
        }
        public string setName
        {
            set { Name = value; }
        }
        public SearchDBUsers(ref DataGridView dataGrid, MySqlConnection connection)
        {
            this.dataGrid = dataGrid;
            this.connection = connection;
            this.killerVar = 5;
            /* 
             * the connection is provided through the constructor
             * the killerVar is used to kill the running thread when the search text change as user give output
             */
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
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void searchByNIC()
        {
            this.dataGrid.Rows.Clear();
            int threadVar = this.killerVar;
            string nicRead;
            string query = "SELECT * FROM quarkslib.user";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, this.connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (threadVar != killerVar)
                {
                    connection.Close();
                    return;
                }
                nicRead = reader.GetString("NIC");
                if (nicRead.Length < NIC.Length)
                {
                    connection.Close();
                    return;
                }
                if (StringMatchFinder.matchStrings(nicRead.Substring(0,this.NIC.Length), this.NIC))
                {
                    string[] row = { reader.GetString("NIC"), reader.GetString("Name") };
                    this.dataGrid.Rows.Add(row);
                }
            }
            connection.Close();
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void searbyName()
        {
            this.dataGrid.Rows.Clear();
            int threadVar = this.killerVar;
            string nameRead;
            string query = "SELECT * FROM quarkslib.user";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, this.connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (threadVar != killerVar)
                {
                    connection.Close();
                    reader.Dispose();
                    return;
                }
                nameRead = reader.GetString("Name");
                if (StringMatchFinder.matchStrings(nameRead, this.Name))
                {
                    string[] row = { reader.GetString("NIC"), reader.GetString("Name") };
                    this.dataGrid.Rows.Add(row);
                }
            }
            connection.Close();
        }
    }
}
