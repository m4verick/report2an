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
    class ProducerManager
    {
        private MySqlConnection connect;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapt;
        private MySqlDataReader reader;

        private DataSet dataSet;
        // private DataTable dataTable;
        private string query;

        public ProducerManager()
        {
            connect = ConnectionStrings.newCONN;
            query = string.Empty;
        }

        public bool AddSituationsAttentions(Producer prod)
        {
            bool result = false;

            query = "INSERT INTO situation_attentions (id_game_title, status, situation, attention, creation_date) VALUES(" + prod.m_GameTitle + ",'" + prod.m_Status + "','" + prod.m_Situation + "','" + prod.m_Attention + "', '" + prod.m_CreationDate + "')";

            try
            {
                connect.Open();
                cmd = new MySqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                result = true;
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

        public bool AddRiskSolution(Producer prod)
        {
            bool result = false;

            query = "INSERT INTO risks_solutions (id_situation_attention, risk, likelyhood, impact, consequense, solution, eta, creation_date) VALUES((SELECT id_situation_attention FROM situation_attentions WHERE id_game_title = " + prod.m_IdSituation + " ),'" + prod.m_ListPossible + "','" + prod.m_Likehood + "','" + prod.m_Impact + "','" + prod.m_Consequences + "','" + prod.m_Minimize + "','" + prod.m_ETASol + "','" + prod.m_CreationDate + "')";

            try
            {
                connect.Open();
                cmd = new MySqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                result = true;
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

        public DataSet GetDataGameByName()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT gameid, game_title FROM game";

            try
            {
                connect.Open();
                adapt = new MySqlDataAdapter(query, connect);
                adapt.Fill(dataSet);
            }
            catch (MySqlException ex)
            {
                ex.Message.ToString();
                return null;
            }
            catch (Exception exec)
            {
                exec.Message.ToString();
                return null;
            }
            finally
            {
                connect.Close();
            }
            return dataSet;
        }

        public DataSet GetDataGameByNameDateNow()
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd");
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT sa.id_game_title AS gameid, g.game_title AS gametitle FROM situation_attentions sa JOIN game g ON g.gameid = sa.id_game_title WHERE sa.creation_date = '"+ now +"'";

            try
            {
                connect.Open();
                adapt = new MySqlDataAdapter(query, connect);
                adapt.Fill(dataSet);
            }
            catch (MySqlException ex)
            {
                ex.Message.ToString();
                return null;
            }
            catch (Exception exec)
            {
                exec.Message.ToString();
                return null;
            }
            finally
            {
                connect.Close();
            }
            return dataSet;
        }

        public DataSet GetDataDeadlineByID(string idgame)
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT local_deadline, ios_deadline FROM game WHERE gameid = "+ idgame +"";

            try
            {
                connect.Open();
                adapt = new MySqlDataAdapter(query, connect);
                adapt.Fill(dataSet);
            }
            catch (MySqlException ex)
            {
                ex.Message.ToString();
                return null;
            }
            catch (Exception exec)
            {
                exec.Message.ToString();
                return null;
            }
            finally
            {
                connect.Close();
            }
            return dataSet;
        }

        
    }
}
