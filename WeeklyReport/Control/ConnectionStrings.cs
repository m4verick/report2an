using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace WeeklyReport.Control
{
    class ConnectionStrings
    {
        private static string conn;

        public ConnectionStrings()
        {
            try
            {
                conn = getConn();
            }
            catch (MySqlException ex)
            {
                ex.Message.ToString();
            }
        }

        public static string getConn()
        {
            return "Server=localhost;Database=weeklyreport;Uid=root;Pwd=";
        }

        public static string CONN
        {
            set { }
            get { return conn; }
        }

        public static MySqlConnection newCONN
        {
            set { }
            get { return new MySqlConnection(getConn()); }
        }
    }
}
