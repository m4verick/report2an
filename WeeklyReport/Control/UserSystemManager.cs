using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using WeeklyReport.Model;

namespace WeeklyReport.Control
{
    class UserSystemManager
    {
        private MySqlConnection connect;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapt;
        private MySqlDataReader reader;

        private DataSet dataSet;
        // private DataTable dataTable;
        private string query;

        public UserSystemManager()
        {
            connect = ConnectionStrings.newCONN;
            query = string.Empty;
        }

        public bool ValidateLogin(UserSystem u_ser)
        {
            bool result = false;

            query = "SELECT * FROM user_system WHERE user_name = '" + u_ser.m_Username + "' and pass_user = '" + u_ser.m_Password + "'";

            try
            {
                connect.Open();
                cmd = new MySqlCommand(query, connect);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    result = true;
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                result = false;
            }
            finally
            {
                connect.Close();
            }

            return result;
        }

        public string GetRoleUserSystem(string userName, string passUser)
        {
            string result = String.Empty;

            query = string.Empty;
            query = "SELECT role_user FROM user_system WHERE user_name = '" + userName + "' AND pass_user = '" + passUser + "'";

            try
            {
                connect.Open();
                cmd = new MySqlCommand(query, connect);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result = reader.GetString(0);
                }
                else
                {
                    result = String.Empty;
                }
            }
            catch (MySqlException ex)
            {
                ex.Message.ToString();
                result = String.Empty;
            }
            catch (Exception exec)
            {
                exec.Message.ToString();
                result = String.Empty;
            }
            finally
            {
                connect.Close();
            }
            return result;
        }
    }
}
