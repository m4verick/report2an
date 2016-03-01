using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeeklyReport.Model;
using WeeklyReport.Control;

namespace WeeklyReport.View
{
    public partial class ProducerForm : Form
    {

        private Producer s_Producer;
        private ProducerManager s_ProducerManager;

        public ProducerForm()
        {
            InitializeComponent();
            s_ProducerManager = new ProducerManager();
           // DataSetComboBoxGame();
            tabPage1.Text = "Input Situation and Attention";
            tabPage2.Text = "Input Risks and Solutions";
            DateTimeFormat();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (cmb_GameTitle.SelectedIndex > -1 && cmbStatus.SelectedIndex > -1 && txt_Situation.TextLength > 0 && txt_Attention.TextLength > 0)
            {
                if (MessageBox.Show("Are you sure want to store those datas ? Please note, after you submit, the datas cannot be reverted", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    s_Producer = new Producer(cmb_GameTitle.SelectedValue.ToString(), cmbStatus.SelectedItem.ToString(), txt_Situation.Text.ToString(), txt_Attention.Text.ToString(), DateTime.Now.ToString("yyyy-MM-dd"));

                    if (s_ProducerManager.AddSituationsAttentions(s_Producer))
                    {
                        MessageBox.Show("Succesfully added","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ClearField();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void DataSetComboBoxGame()
        {
            DataSet ds = s_ProducerManager.GetDataGameByName();
            cmb_GameTitle.DataSource = ds.Tables[0];
            cmb_GameTitle.DisplayMember = "game_title";
            cmb_GameTitle.ValueMember = "gameid";
        }

        private void DataSetComboBoxGameByDateNow()
        {
            DataSet ds = s_ProducerManager.GetDataGameByNameDateNow();
            cmb_GameTitleRisk.DataSource = ds.Tables[0];
            cmb_GameTitleRisk.DisplayMember = "gametitle";
            cmb_GameTitleRisk.ValueMember = "gameid";
        }

        private void cmb_GameTitle_MouseClick(object sender, MouseEventArgs e)
        {
            DataSetComboBoxGame();
        }

        private void cmb_GameTitle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataSet ds = s_ProducerManager.GetDataDeadlineByID(cmb_GameTitle.SelectedValue.ToString());
            txt_iOSDeadline.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_LocalDeadline.Text = ds.Tables[0].Rows[0][1].ToString();
        }

        private void btn_SubmitRisk_Click(object sender, EventArgs e)
        {
            s_Producer = new Producer(cmb_GameTitleRisk.SelectedValue.ToString(), txt_List.Text.ToString(), cmb_Likelyhood.SelectedItem.ToString(), cmb_Impact.SelectedItem.ToString(), txt_Cons.Text.ToString(), txt_Minimize.Text.ToString(), dtp_ETA.Text.ToString(), DateTime.Now.ToString("yyyy-MM-dd"));

            if (s_ProducerManager.AddRiskSolution(s_Producer))
            {
                MessageBox.Show("Succesfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearField();
            }
            else
            {
                MessageBox.Show("Failed to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_GameTitleRisk_MouseClick(object sender, MouseEventArgs e)
        {
            DataSetComboBoxGameByDateNow();
        }

        private void DateTimeFormat()
        {
            dtp_ETA.Format = DateTimePickerFormat.Custom;
            dtp_ETA.CustomFormat = "yyyy-MM-dd";
        }
    }
}
