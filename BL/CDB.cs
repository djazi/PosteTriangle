using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

//this apps made by khalid djazi et ouissal allam soufiane halloumi please don't change this comment or delete it and don't change the names in the menu forms 
//you can add change add delete upgrade this app for better performance for the user experience FOR IMS promo 2021
//contact me khalid djazi by my mail adress khalid.djazi@esith.net 
namespace PosteTriangle.BL
{
    class CDB
    {



        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=projet");
        //private MySqlConnection connection = new MySqlConnection("server=192.168.43.35;port=3306;username=IMS3;password=0000;database=projet");

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
