using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PosteTriangle.BL
{
    class CDB
    {



        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=projets5");

        //create a function to open the question
        public void openConnection()
        {
            if(connection.State== System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //create a function to close the question
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        //create a function to return the connection
        public MySqlConnection getConnection()
        {
            return connection;

        }
    }
}
