using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WeeklyReport.Control;

namespace WeeklyReport.View
{
    public partial class Login : Form
    {
        UserSystemManager s_UserSystemManager;
        string m_MainRole = String.Empty;

        public Login()
        {
            InitializeComponent();
            s_UserSystemManager = new UserSystemManager();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.TextLength > 0 && txt_Password.TextLength > 0)
            {
                m_MainRole = s_UserSystemManager.GetRoleUserSystem(txt_Username.Text.ToString(), txt_Password.Text.ToString());

                if (!m_MainRole.Equals(String.Empty))
                {
                    MessageBox.Show("Login succesful");
                    this.Hide();
                    MainView s_mView = new MainView(m_MainRole);
                    s_mView.Show();
                }
                else
                {
                    MessageBox.Show("Login failed");
                }
            }
            else 
            {
                MessageBox.Show("Please fill username or/and password");
            }
        }
    }
}
