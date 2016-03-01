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
    class SMManager
    {
        private MySqlConnection connect;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapt;
        private MySqlDataReader reader;

        private DataSet dataSet;
        // private DataTable dataTable;
        private string query;

        public SMManager()
        {
            connect = ConnectionStrings.newCONN;
            query = string.Empty;
        }

        public bool AddStudioManager(StudioManager sm)
        {
            bool result = false;

            query = "INSERT INTO game (game_title, slot_type, upd_n, platform, local_producer, hq_prod, local_deadline, ios_deadline) VALUES('" + sm.m_GameTitle + "','" + sm.m_ProjectType + "','" + sm.m_EvolutionUpdate + "','" + sm.m_PlatformType + "','" + sm.m_LocalProducer + "','" + sm.m_HqProducer + "','" + sm.m_LocalDeadline + "','" + sm.m_IosDeadline + "')";

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

        public bool AddResourceAllocation(StudioManager sm)
        {
            bool result = false;

            query = "INSERT INTO resources (prod_id, prg_alloc, qa_alloc, gd_alloc, gfx_alloc) VALUES('" + sm.m_ProdId + "'," + sm.m_PrgAlloc + "," + sm.m_QaAlloc + "," + sm.m_GdAlloc + "," + sm.m_GfxAlloc + ")";

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

        public DataSet GetDataProducerByName()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT id_user, user_name FROM user_system WHERE role_user = 'Producer'";

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

        public DataSet GetDataSituationAttentionByGame(string date)
        {
            //string now = DateTime.Now.ToString("yyyy-MM-dd");
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT g.game_title, sa.status, g.local_deadline, sa.situation, sa.attention, g.gameid FROM situation_attentions sa JOIN game g ON g.gameid = sa.id_game_title WHERE sa.creation_date = '" + date + "'";

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

        public DataSet GetDataRisksSolutionByGame(string idGame, string date)
        {
            //string now = DateTime.Now.ToString("yyyy-MM-dd");
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT rs.risk, rs.likelyhood, rs.impact, rs.consequense, rs.solution, rs.eta from risks_solutions rs JOIN situation_attentions sa ON sa.id_situation_attention = rs.id_situation_attention WHERE rs.id_situation_attention = (SELECT sa.id_situation_attention FROM situation_attentions sa WHERE sa.id_game_title = " + idGame + ") AND sa.creation_date = '" + date + "'";

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
