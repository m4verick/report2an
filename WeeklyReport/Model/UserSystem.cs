using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeeklyReport.Model
{
    class UserSystem
    {
        string m_username;
        string m_password;
        string m_role;

        public string m_Username
        {
            set { m_username = value; }
            get { return m_username; }
        }

        public string m_Password
        {
            set { m_password = value; }
            get { return m_password; }
        }

        public string m_Role
        {
            set { m_role = value; }
            get { return m_role; }
        }
    }
}
