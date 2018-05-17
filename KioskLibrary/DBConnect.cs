using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace InfluxLibrary
{
    public class DataBase
    {
        private string _userID = "root";
        private string _password = "";
        private string _dbSource = "localhost";
        private string _catalog = "influx";
        public MySqlConnection connection;
        /// <summary>
        /// Make db connection
        /// </summary>
        public DataBase()
        {
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "mysql7.000webhost.com";
            conn_string.UserID = "a455555_test";
            conn_string.Password = "a455555_me";
            conn_string.Database = "xxxxxxxx";

            MySqlConnection conn = new MySqlConnection(conn_string.ToString());
            connection.Open();
        }
    }
}
