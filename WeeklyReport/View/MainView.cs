using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WeeklyReport.View
{
    public partial class MainView : Form
    {
        string m_mainRole = String.Empty;

        public MainView(string mainRole)
        {
            InitializeComponent();
            m_mainRole = mainRole;
        }

        private bool IsAlreadyActivated(Type formType)
        {
            if (this.MdiChildren.GetLength(0) > 0)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm.GetType().Equals(formType))
                        return true;
                }
            }
            return false;
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (!IsAlreadyActivated(typeof(ProducerForm)))
                {
                    ProducerForm s_ProducerForm = new ProducerForm();
                    s_ProducerForm.MdiParent = this;
                    s_ProducerForm.Dock = DockStyle.Fill;
                    s_ProducerForm.Show();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Failed to show Producer Form due this error : " + exc.Message, "Information");
            }
        }

        private void inputProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (!IsAlreadyActivated(typeof(StudioManagerForm)))
                {
                    StudioManagerForm s_SMForm = new StudioManagerForm();
                    s_SMForm.MdiParent = this;
                    s_SMForm.Dock = DockStyle.Fill;
                    s_SMForm.Show();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Failed to show Studio Manager Form due this error : " + exc.Message, "Information");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login s_Login = new Login();
                this.Close();
                s_Login.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit application ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            if (m_mainRole.Equals("Producer"))
            {
                inputToolStripMenuItem.Enabled = false;
            }
        }
    }
}
