using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeeklyReport.Model
{
    class StudioManager
    {
        string m_gameTitle;
        int m_projectType;
        int m_platformType;
        int m_evolutionUpdate;
        string m_localProducer;
        string m_hqProducer;
        string m_iosDeadline;
        string m_localDeadline;

        public StudioManager()
        { 
        }

        public StudioManager(string title, int project,int platform,int evo,string localPrd,string hqProd,string iosDeadline,string localdead)
        {
            m_gameTitle = title;
             m_projectType = project;
            m_platformType = platform;
             m_evolutionUpdate = evo;
             m_localProducer = localPrd;
             m_hqProducer = hqProd;
             m_iosDeadline = iosDeadline;
             m_localDeadline = localdead;
        }

        public string m_GameTitle
        {
            set { m_gameTitle = value; }
            get { return m_gameTitle; }
        }

        public int m_ProjectType
        {
            set { m_projectType = value; }
            get { return m_projectType; }
        }

        public int m_PlatformType
        {
            set { m_platformType = value; }
            get { return m_platformType; }
        }

        public int m_EvolutionUpdate
        {
            set { m_evolutionUpdate = value; }
            get { return m_evolutionUpdate; }
        }

        public string m_LocalProducer
        {
            set { m_localProducer = value; }
            get { return m_localProducer; }
        }

        public string m_HqProducer
        {
            set { m_hqProducer = value; }
            get { return m_hqProducer; }
        }

        public string m_IosDeadline
        {
            set { m_iosDeadline = value; }
            get { return m_iosDeadline; }
        }

        public string m_LocalDeadline
        {
            set { m_localDeadline = value; }
            get { return m_localDeadline; }
        }
    }
}
