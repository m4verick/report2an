using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeeklyReport.Model
{
    class Producer
    {
        string m_gameTitle;
        string m_status;
        string m_situation;
        string m_attention;

        string m_idSituation;
        string m_listPossible;
        string m_likehood;
        string m_impact;
        string m_consequences;
        string m_minimize;
        string m_ETA;
        string m_creationDate;

        public Producer()
        { 
        }

        public Producer(string title, string status, string situation, string attention, string datecreat)
        {
            m_gameTitle = title;
            m_status = status;
            m_situation = situation;
            m_attention = attention;
            m_creationDate = datecreat;
        }

        public Producer(string id, string list, string likehood, string impact, string consequ, string minimize, string eta, string datecreat)
        {
            m_idSituation = id;
            m_listPossible = list;
            m_likehood = likehood;
             m_impact = impact;
             m_consequences = consequ;
             m_minimize = minimize;
             m_ETA = eta;
             m_creationDate = datecreat;
        }

        public string m_GameTitle
        {
            set { m_gameTitle = value; }
            get { return m_gameTitle; }
        }

        public string m_Status
        {
            set { m_status = value; }
            get { return m_status; }
        }

        public string m_Situation
        {
            set { m_situation = value; }
            get { return m_situation; }
        }

        public string m_Attention
        {
            set { m_attention = value; }
            get { return m_attention; }
        }

        public string m_ListPossible
        {
            set { m_listPossible = value; }
            get { return m_listPossible; }
        }

        public string m_Consequences
        {
            set { m_consequences = value; }
            get { return m_consequences; }
        }

        public string m_Likehood
        {
            set { m_likehood = value; }
            get { return m_likehood; }
        }

        public string m_Impact
        {
            set { m_impact = value; }
            get { return m_impact; }
        }

        public string m_IdSituation
        {
            set { m_idSituation = value; }
            get { return m_idSituation; }
        }

        public string m_Minimize
        {
            set { m_minimize = value; }
            get { return m_minimize; }
        }

        public string m_ETASol
        {
            set { m_ETA = value; }
            get { return m_ETA; }
        }

        public string m_CreationDate
        {
            set { m_creationDate = value; }
            get { return m_creationDate; }
        }
    }
}
