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
using System.Net.Mail;
using System.Net;

namespace WeeklyReport.View
{
    public partial class StudioManagerForm : Form
    {

        private StudioManager s_StudioManager;
        private SMManager s_SMManager;
        private ProducerManager s_ProducerManager;
        //private BindingSource s_BindingPelanggan = new BindingSource();

        private string m_GameTitle;
        private string m_Status;
        private string m_Situation;
        private string m_Attention;
        private string m_Deadline;

        private string m_Risk;
        private string m_Likelyhood;
        private string m_Impact;
        private string m_Cons;
        private string m_Solution;
        private string m_ETA;


        public StudioManagerForm()
        {
            InitializeComponent();
            tabPage1.Text = "Input Project";
            tabPage2.Text = "View Report";
            tabPage3.Text = "Input Allocation";
            s_SMManager = new SMManager();
            s_ProducerManager = new ProducerManager();
            DateTimeFormat();
            DataSetComboBoxProd();
        }

        private void btnSMSubmit_Click(object sender, EventArgs e)
        {
           s_StudioManager = new StudioManager(txtSM_GameTitle.Text.ToString(), isClickProject(), isClickPlatform(), int.Parse(txtSM_EvolutionUpd.Text.ToString()), cmbSM_LocalProd.SelectedItem.ToString(), txtSM_HQProd.Text.ToString(), dtp_LocalDeadline.Text.ToString(), dtp_iOSDeadline.Text.ToString());

           if (s_SMManager.AddStudioManager(s_StudioManager))
           {
               MessageBox.Show("Succesfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               ClearField();
           }
           else
           {
               MessageBox.Show("Failed to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
        }

        private void DataSetComboBoxProd()
        {
            DataSet ds = s_SMManager.GetDataProducerByName();
            cmbSM_LocalProd.DataSource = ds.Tables[0];
            cmbSM_LocalProd.DisplayMember = "user_name";
            cmbSM_LocalProd.ValueMember = "id_user";
        }

        private void DataSetComboBoxGame()
        {
            //DataSet ds = s_ProducerManager.GetDataGameByName();
            //cmb_GameTitleSM.DataSource = ds.Tables[0];
            //cmb_GameTitleSM.DisplayMember = "game_title";
            //cmb_GameTitleSM.ValueMember = "gameid";
        }

        private int isClickProject()
        {
            if (rb_PUB.Checked)
                return 1;
            else if (rb_GE.Checked)
                return 2;
            else
                return 0;
        }

        private void InitWebView()
        {
            wb_ViewReport.AllowWebBrowserDrop = false;
        }

        private int isClickPlatform()
        {
            if (rb_Win.Checked)
                return 1;
            else if (rb_Droid.Checked)
                return 2;
            else
                return 0;
        }

        private void DateTimeFormat()
        {
            dtp_iOSDeadline.Format = DateTimePickerFormat.Custom;
            dtp_iOSDeadline.CustomFormat = "yyyy-MM-dd";

            dtp_LocalDeadline.Format = DateTimePickerFormat.Custom;
            dtp_LocalDeadline.CustomFormat = "yyyy-MM-dd";

            dtp_Report.Format = DateTimePickerFormat.Custom;
            dtp_Report.CustomFormat = "yyyy-MM-dd";
        }

        private void ClearField()
        {
            txtSM_EvolutionUpd.Text = "";
            txtSM_GameTitle.Text = "";
            txtSM_HQProd.Text = "";
        }

        private void MailSending(string username, string pass)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress(username);
                message.To.Add(new MailAddress("ruben.ramirez@gameloft.com"));
                message.Subject = "Test";
                message.IsBodyHtml = true;
                //message.Body = BodyMessage();
               
                //NetworkCredential loginInfo = new NetworkCredential(Convert.ToString(ConfigurationManager.AppSettings["frederik.sabandar@gmail.com"]), Convert.ToString(ConfigurationManager.AppSettings["fr3d3r1ks4b4nd@r"]));

                smtp.Port = 25;
                smtp.Host = "mail01.jog.gameloft.org";
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(username, pass);
                //smtp.Credentials = new System.Net.NetworkCredential("frederik.sabandar@gmail.com", "fr3d3r1ks4b4nd@r");
               // smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("err: " + ex.Message);
            }
        }

        private string BodyMessage(string gameTitle, string status, string situation, string attention, string deadline)
        {
            string content = "<html>"+
                            "<head>"+
                            "<meta http-equiv=" + "\"Content-Type\"" + " content="+"\"text/html;" +
                                "charset=windows-1252\">" +
                            "<meta name=" + "\"Generator\"" + " content="+"\"Microsoft Word 15 (filtered medium)\">" +
                            "</head>" +
                            "<body bgcolor="+ "\"#FFFFFF\"" + " lang="+ "\"EN-US\"" + " link="+ "\"#0563C1\""+ " text="+ "\"#333333\"" + 
                            " vlink=" + "\"#954F72\">"+
                            "<div class="+ "\"WordSection1\">" + 
                                "<table class=" + "\"MsoTableGrid\""+
                                " style="+ "\"border-collapse:collapse;border:none\""+ " border=" + "\"1\"" +
                                " cellpadding="+ "\"0\""+ " cellspacing="+ "\"0\">" + 
                                "<tbody>" +
                                    "<tr>" +
                                    "<td colspan="+"\"2\""+ " style="+"\"width:625.1pt;border:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\""+ " valign="+"\"top\""+
                                        " width="+"\"833\">" + 
                                        "<p class="+"\"MsoNormal\"" + " style="+"\"text-align:center\""+
                                        " align="+"\"center\">"+ gameTitle +"<o:p></o:p></p>" +
                                    "</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                    "<td style="+"\"width:116.6pt;border:solid windowtext 1.0pt;border-top:none;padding:0in 5.4pt 0in 5.4pt\"" +
                                        " valign="+"\"top\""+ " width="+"\"155\">" +
                                        "<p class="+"\"MsoNormal\">" + "Status<o:p></o:p></p>" +
                                    "</td>" + 
                                    "<td " +
                                        "style="+"\"width:508.5pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign="+"\"top\"" +
                                        " width="+"\"678\">" + 
                                        "<p class="+ "\"MsoNormal\">" + status + "<o:p></o:p></p>" +
                                    "</td>"+
                                    "</tr>"+
                                    "<tr>"+
                                    "<td style="+ "\"width:116.6pt;border:solid windowtext 1.0pt;border-top:none;padding:0in 5.4pt 0in 5.4pt\"" + " valign="+ "\"top\"" + " width="+ "\"155\">" + 
                                        "<p class="+ "\"MsoNormal\">" + "Deadline<o:p></o:p></p>" +
                                    "</td>" + 
                                    "<td" +
                                        " style="+ "\"width:508.5pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign="+ "\"top\"" +
                                        " width="+ "\"678\">"+
                                        "<p class="+ "\"MsoNormal\">" + deadline + "<o:p></o:p></p>" + 
                                    "</td>" + 
                                    "</tr>" + 
                                    "<tr>" +
                                    "<td style="+"\"width:116.6pt;border:solid windowtext 1.0pt;border-top:none;padding:0in 5.4pt 0in 5.4pt\"" + 
                                        " valign="+ "\"top\"" + " width="+ "\"155\">"+
                                        "<p class="+ "\"MsoNormal\">" + "Situation &amp; Next Goals<o:p></o:p></p>" + 
                                    "</td>" + 
                                    "<td" +
                                    " style="+ "\"width:508.5pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign="+ "\"top\"" +
                                        " width="+ "\"678\">" + 
                                        "<p class=" + "\"MsoNormal\">" + situation + "<o:p></o:p></p>" +
                                    "</td>" + 
                                    "</tr>" +
                                    "<tr>" +
                                    "<td style="+ "\"width:116.6pt;border:solid windowtext 1.0pt;border-top:none;padding:0in 5.4pt 0in 5.4pt\"" + 
                                        " valign="+ "\"top\"" + " width="+ "\"155\">" + 
                                        "<p class="+ "\"MsoNormal\">" + "Need your Attention<o:p></o:p></p>" + 
                                    "</td>" +
                                    "<td" + 
                                        " style="+ "\"width:508.5pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign="+"\"top\"" + 
                                        " width="+ "\"678\">" + 
                                        "<p class=" + "\"MsoNormal\">" + attention + "<o:p></o:p></p>" +
                                   "</td>" + 
                                    "</tr>" +
                                    "<tr>" +
                                    "<td style="+ "\"width:116.6pt;border:solid windowtext 1.0pt;border-top:none;padding:0in 5.4pt 0in 5.4pt\"" + " valign="+ "\"top\"" + " width="+ "\"155\">" + 
                                        "<p class="+ "\"MsoNormal\">" + "Risk and Solution<o:p></o:p></p>" + 
                                    "</td>"+
                                    "<td" +
                                        " style="+ "\"width:508.5pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign="+ "\"top\"" + 
                                        " width="+ "\"678\">" + 
                                        "<p class="+ "\"MsoNormal\">" + "<o:p> </o:p></p>" + 
                                    "</td>" + 
                                    "</tr>" + 
                                    "<tr style="+ "\"height:73.75pt\">" + 
                                    "<td colspan="+ "\"2\"" + " style="+ "\"width:625.1pt;border:solid windowtext 1.0pt;border-top:none;padding:0in 5.4pt 0in 5.4pt;height:73.75pt\"" + " valign="+ "\"top\"" + " width="+ "\"833\">" + 
                                        "<p class="+ "\"MsoNormal\">" + "-- <o:p></o:p></span></p>" + 
                                        "<table class="+ "\"MsoTableGrid\"" +
                                        " style="+ "\"border-collapse:collapse;border:none\"" + " border="+ "\"1\"" +
                                        " cellpadding="+ "\"0\"" + " cellspacing="+ "\"0\">"+
                                        "<tbody>" + 
                                            "<tr>"+ 
                                            "<td style="+ "\"width:137.4pt;border:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign="+ "\"top\""+
                                                " width="+ "\"183\">" + 
                                                "<p class="+ "\"MsoNormal\">" + "List of Possible Risks<o:p></o:p></p>" + 
                                            "</td>"+
                                            "<td style="+ "\"width:57.3pt;border:solid windowtext 1.0pt;border-left:none;padding:0in 5.4pt 0in 5.4pt\"" + " valign="+ "\"top\"" + " width="+ "\"76\">" + 
                                                "<p class="+ "\"MsoNormal\">" + "Likelihood<o:p></o:p></p>" + 
                                            "</td>" + 
                                            "<td style="+ "\"width:51.1pt;border:solid windowtext 1.0pt;border-left:none;padding:0in 5.4pt 0in 5.4pt\"" + " valign="+ "\"top\"" + " width="+ "\"68\">" +
                                                "<p class="+ "\"MsoNormal\">" + "Impact<o:p></o:p></p>" +
                                            "</td>" + 
                                            "<td style="+ "\"width:1.75in;border:solid windowtext 1.0pt;border-left:none;padding:0in 5.4pt 0in 5.4pt\"" + " valign="+ "\"top\""+ " width="+ "\"168\">" +
                                                "<p class="+ "\"MsoNormal\">" + "Consequences<o:p></o:p></p>" +
                                            "</td>" +
                                            "<td style="+ "\"width:146.05pt;border:solid windowtext 1.0pt;border-left:none;padding:0in 5.4pt 0in 5.4pt\"" + " valign="+ "\"top\""+ " width="+ "\"195\">" +
                                                "<p class="+ "\"MsoNormal\">" + "Solutions<o:p></o:p></p>" +
                                            "</td>"+ 
                                            "<td style="+ "\"width:95.6pt;border:solid windowtext 1.0pt;border-left:none;padding:0in 5.4pt 0in 5.4pt\"" + " valign="+ "\"top\"" + " width="+ "\"127\">" + 
                                                "<p class="+ "\"MsoNormal\">" + "ETA for Solutions<o:p></o:p></p>" +
                                            "</td>" +
                                            "</tr>" +
                                            "<tr>" +
                                            "<td style="+ "\"width:137.4pt;border:solid windowtext 1.0pt;border-top:none;padding:0in 5.4pt 0in 5.4pt\"" +
                                                " valign="+ "\"top\"" + " width="+ "\"183\">" + 
                                                "<p class="+ "\"MsoNormal\">" + "Content1<o:p></o:p></span></p>" +
                                                "<p class="+ "\"MsoNormal\">" + "<o:p> </o:p></span></p>" + 
                                            "</td>" + 
                                            "<td" +
                                                " style="+ "\"width:57.3pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\""+ " valign="+ "\"top\""+
                                                " width="+ "\"76\">"+
                                                "<p class="+"\"MsoNormal\">" + "Content1<o:p></o:p></span></p>" +
                                                "<p class="+"\"MsoNormal\">" + "<o:p> </o:p></span></p>" + 
                                            "</td>"+
                                            "<td"+
                                                " style="+ "\"width:51.1pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\""+ " valign="+"\"top\"" +
                                                " width="+"\"68\">"+ 
                                                "<p class=" + "\"MsoNormal\">" + "Content1<o:p></o:p></span></p>" +
                                                "<p class="+"\"MsoNormal\">" +"<o:p> </o:p></span></p>"+
                                            "</td>"+
                                            "<td"+
                                                " style="+ "\"width:1.75in;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\""+ " valign="+ "\"top\"" +
                                                " width="+ "\"168\">"+
                                                "<p class="+ "\"MsoNormal\">" + "Content1<o:p></o:p></span></p>"+
                                                "<p class="+ "\"MsoNormal\">" + "<o:p> </o:p></span></p>" +
                                            "</td>"+
                                            "<td"+
                                                " style="+ "\"width:146.05pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\""+ " valign="+ "\"top\""+
                                                " width="+ "\"195\">"+
                                                "<p class="+"\"MsoNormal\">" + "Content1<o:p></o:p></span></p>"+
                                                "<p class="+ "\"MsoNormal\">" + "<o:p> </o:p></span></p>" +
                                            "</td>"+
                                            "<td"+
                                                " style="+ "\"width:95.6pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\""+ " valign="+ "\"top\""+
                                                " width="+ "\"127\">"+ 
                                                "<p class="+ "\"MsoNormal\">" + "Content1<o:p></o:p></span></p>" +
                                                "<p class="+"\"MsoNormal\">" + "<o:p> </o:p></span></p>"+
                                            "</td>"+
                                            "</tr>"+
                                        "</tbody>"+ 
                                        "</table>"+
                                        "<p class="+ "\"MsoNormal\">" +"<o:p></o:p></span></p>" +
                                    "</td>" + 
                                    "</tr>" +
                                "</tbody>" +
                                "</table>" +
                                "<p class="+ "\"MsoNormal\">" + "<o:p> </o:p></span></p>" +
                            "</div>"+
                            "</body>" +
                        "</html>";

            return content;
        }

        private void btn_ViewReport_Click(object sender, EventArgs e)
        {
            wb_ViewReport.DocumentText = SetAllContents();
        }

        private void cmb_GameTitleSM_MouseClick(object sender, MouseEventArgs e)
        {
            DataSetComboBoxGame();
        }

        private string ConvertDateTime(string date)
        {
            DateTime temp = Convert.ToDateTime(date);
            return temp.ToString("dd MMMM yyyy");
        }

        private string SetAllContents()
        {
            string contents = "";
            string temp;

            DataSet ds = s_SMManager.GetDataSituationAttentionByGame(dtp_Report.Text.ToString());
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                temp = SetTemplateContent(ds.Tables[0].Rows[i][0].ToString(), ds.Tables[0].Rows[i][1].ToString(), ds.Tables[0].Rows[i][2].ToString(), ds.Tables[0].Rows[i][3].ToString(), ds.Tables[0].Rows[i][4].ToString(), ds.Tables[0].Rows[i][5].ToString());
                contents += temp;
            }
            return contents;
        }

        private string SetAllParameterRiskAndSolutions(string GameTitle)
        {
            string contentRiskSolutions = "";
            string temp;
            DataSet ds = s_SMManager.GetDataRisksSolutionByGame(GameTitle, dtp_Report.Text.ToString());
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                temp = SetTemplateRiskAndSolutions(ds.Tables[0].Rows[i][0].ToString(), ds.Tables[0].Rows[i][1].ToString(), ds.Tables[0].Rows[i][2].ToString(), ds.Tables[0].Rows[i][3].ToString(), ds.Tables[0].Rows[i][4].ToString(), ds.Tables[0].Rows[i][5].ToString());
                contentRiskSolutions += temp;
            }

            return contentRiskSolutions;
        }

        private string SetTemplateContent(string gameTitle, string status, string deadline, string situation, string attention, string idGameTitle)
        {
            return"<html>" +
                "<head>" +
                "<meta http-equiv=" + "\"Content-Type\"" + " content=" + "\"text/html;" +
                    "charset=windows-1252\">" +
                "<meta name=" + "\"Generator\"" + " content=" + "\"Microsoft Word 15 (filtered medium)\">" +
                "</head>" +
                "<body bgcolor=" + "\"#FFFFFF\"" + " lang=" + "\"EN-US\"" + " link=" + "\"#0563C1\"" + " text=" + "\"#333333\"" +
                " vlink=" + "\"#954F72\">" +
                "<div class=" + "\"WordSection1\">" +
                    "<table class=" + "\"MsoTableGrid\"" +
                    " style=" + "\"border-collapse:collapse;border:none\"" + " border=" + "\"1\"" +
                    " cellpadding=" + "\"0\"" + " cellspacing=" + "\"0\">" +
                    "<tbody>" +
                        "<tr>" +
                        "<td colspan=" + "\"2\"" + " style=" + "\"width:625.1pt;border:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" +
                            " width=" + "\"833\">" +
                            "<p class=" + "\"MsoNormal\"" + " style=" + "\"text-align:center\"" +
                            " align=" + "\"center\">" + gameTitle + "<o:p></o:p></p>" +
                        "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td style=" + "\"width:116.6pt;border:solid windowtext 1.0pt;border-top:none;padding:0in 5.4pt 0in 5.4pt\"" +
                            " valign=" + "\"top\"" + " width=" + "\"155\">" +
                            "<p class=" + "\"MsoNormal\">" + "Status<o:p></o:p></p>" +
                        "</td>" +
                        "<td " +
                            "style=" + "\"width:508.5pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" +
                            " width=" + "\"678\">" +
                            "<p class=" + "\"MsoNormal\">" + status + "<o:p></o:p></p>" +
                        "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td style=" + "\"width:116.6pt;border:solid windowtext 1.0pt;border-top:none;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" + " width=" + "\"155\">" +
                            "<p class=" + "\"MsoNormal\">" + "Deadline<o:p></o:p></p>" +
                        "</td>" +
                        "<td" +
                            " style=" + "\"width:508.5pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" +
                            " width=" + "\"678\">" +
                            "<p class=" + "\"MsoNormal\">" + deadline + "<o:p></o:p></p>" +
                        "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td style=" + "\"width:116.6pt;border:solid windowtext 1.0pt;border-top:none;padding:0in 5.4pt 0in 5.4pt\"" +
                            " valign=" + "\"top\"" + " width=" + "\"155\">" +
                            "<p class=" + "\"MsoNormal\">" + "Situation &amp; Next Goals<o:p></o:p></p>" +
                        "</td>" +
                        "<td" +
                        " style=" + "\"width:508.5pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" +
                            " width=" + "\"678\">" +
                            "<p class=" + "\"MsoNormal\">" + situation + "<o:p></o:p></p>" +
                        "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td style=" + "\"width:116.6pt;border:solid windowtext 1.0pt;border-top:none;padding:0in 5.4pt 0in 5.4pt\"" +
                            " valign=" + "\"top\"" + " width=" + "\"155\">" +
                            "<p class=" + "\"MsoNormal\">" + "Need your Attention<o:p></o:p></p>" +
                        "</td>" +
                        "<td" +
                            " style=" + "\"width:508.5pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" +
                            " width=" + "\"678\">" +
                            "<p class=" + "\"MsoNormal\">" + attention + "<o:p></o:p></p>" +
                        "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td style=" + "\"width:116.6pt;border:solid windowtext 1.0pt;border-top:none;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" + " width=" + "\"155\">" +
                            "<p class=" + "\"MsoNormal\">" + "Risk and Solution<o:p></o:p></p>" +
                        "</td>" +
                        "<td" +
                            " style=" + "\"width:508.5pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" +
                            " width=" + "\"678\">" +
                            "<p class=" + "\"MsoNormal\">" + "<o:p> </o:p></p>" +
                        "</td>" +
                        "</tr>" +
                        "<tr style=" + "\"height:73.75pt\">" +
                        "<td colspan=" + "\"2\"" + " style=" + "\"width:625.1pt;border:solid windowtext 1.0pt;border-top:none;padding:0in 5.4pt 0in 5.4pt;height:73.75pt\"" + " valign=" + "\"top\"" + " width=" + "\"833\">" +
                            "<p class=" + "\"MsoNormal\">" + "-- <o:p></o:p></span></p>" +
                            "<table class=" + "\"MsoTableGrid\"" +
                            " style=" + "\"border-collapse:collapse;border:none\"" + " border=" + "\"1\"" +
                            " cellpadding=" + "\"0\"" + " cellspacing=" + "\"0\">" +
                            "<tbody>" +
                                "<tr>" +
                                "<td style=" + "\"width:137.4pt;border:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" +
                                    " width=" + "\"183\">" +
                                    "<p class=" + "\"MsoNormal\">" + "List of Possible Risks<o:p></o:p></p>" +
                                "</td>" +
                                "<td style=" + "\"width:57.3pt;border:solid windowtext 1.0pt;border-left:none;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" + " width=" + "\"76\">" +
                                    "<p class=" + "\"MsoNormal\">" + "Likelihood<o:p></o:p></p>" +
                                "</td>" +
                                "<td style=" + "\"width:51.1pt;border:solid windowtext 1.0pt;border-left:none;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" + " width=" + "\"68\">" +
                                    "<p class=" + "\"MsoNormal\">" + "Impact<o:p></o:p></p>" +
                                "</td>" +
                                "<td style=" + "\"width:1.75in;border:solid windowtext 1.0pt;border-left:none;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" + " width=" + "\"168\">" +
                                    "<p class=" + "\"MsoNormal\">" + "Consequences<o:p></o:p></p>" +
                                "</td>" +
                                "<td style=" + "\"width:146.05pt;border:solid windowtext 1.0pt;border-left:none;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" + " width=" + "\"195\">" +
                                    "<p class=" + "\"MsoNormal\">" + "Solutions<o:p></o:p></p>" +
                                "</td>" +
                                "<td style=" + "\"width:95.6pt;border:solid windowtext 1.0pt;border-left:none;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" + " width=" + "\"127\">" +
                                    "<p class=" + "\"MsoNormal\">" + "ETA for Solutions<o:p></o:p></p>" +
                                "</td>" +
                                "</tr>" +
                                SetAllParameterRiskAndSolutions(idGameTitle) +
                            "</tbody>" +
                            "</table>" +
                            "<p class=" + "\"MsoNormal\">" + "<o:p></o:p></span></p>" +
                        "</td>" +
                        "</tr>" +
                    "</tbody>" +
                    "</table>" +
                    "<p class=" + "\"MsoNormal\">" + "<o:p> </o:p></span></p>" +
                "</div>" +
                "</body>" +
            "</html>";
        }

        private string SetTemplateRiskAndSolutions(string risk, string likelyhood, string impact, string cons, string solution, string eta)
        {
            return "<tr>" +
                "<td style=" + "\"width:137.4pt;border:solid windowtext 1.0pt;border-top:none;padding:0in 5.4pt 0in 5.4pt\"" +
                    " valign=" + "\"top\"" + " width=" + "\"183\">" +
                    "<p class=" + "\"MsoNormal\">" + risk + "<o:p></o:p></span></p>" +
                    "<p class=" + "\"MsoNormal\">" + "<o:p> </o:p></span></p>" +
                "</td>" +
                "<td" +
                    " style=" + "\"width:57.3pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" +
                    " width=" + "\"76\">" +
                    "<p class=" + "\"MsoNormal\">" + likelyhood + "<o:p></o:p></span></p>" +
                    "<p class=" + "\"MsoNormal\">" + "<o:p> </o:p></span></p>" +
                "</td>" +
                "<td" +
                    " style=" + "\"width:51.1pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" +
                    " width=" + "\"68\">" +
                    "<p class=" + "\"MsoNormal\">" + impact + "<o:p></o:p></span></p>" +
                    "<p class=" + "\"MsoNormal\">" + "<o:p> </o:p></span></p>" +
                "</td>" +
                "<td" +
                    " style=" + "\"width:1.75in;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" +
                    " width=" + "\"168\">" +
                    "<p class=" + "\"MsoNormal\">" + cons + "<o:p></o:p></span></p>" +
                    "<p class=" + "\"MsoNormal\">" + "<o:p> </o:p></span></p>" +
                "</td>" +
                "<td" +
                    " style=" + "\"width:146.05pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" +
                    " width=" + "\"195\">" +
                    "<p class=" + "\"MsoNormal\">" + solution + "<o:p></o:p></span></p>" +
                    "<p class=" + "\"MsoNormal\">" + "<o:p> </o:p></span></p>" +
                "</td>" +
                "<td" +
                    " style=" + "\"width:95.6pt;border-top:none;border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;padding:0in 5.4pt 0in 5.4pt\"" + " valign=" + "\"top\"" +
                    " width=" + "\"127\">" +
                    "<p class=" + "\"MsoNormal\">" + eta + "<o:p></o:p></span></p>" +
                    "<p class=" + "\"MsoNormal\">" + "<o:p> </o:p></span></p>" +
                "</td>" +
                "</tr>";

        }

        private void StudioManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void StudioManagerForm_Resize(object sender, EventArgs e)
        {
            TabSM.Height = StudioManagerForm.ActiveForm.Size.Height;
            TabSM.Width = StudioManagerForm.ActiveForm.Size.Width;

            wb_ViewReport.Height = StudioManagerForm.ActiveForm.Size.Height - 10;
            wb_ViewReport.Width = StudioManagerForm.ActiveForm.Size.Width - 10;
        }

        private void btn_SendMailReport_Click(object sender, EventArgs e)
        {
            MailSending(txt_GLMailAcc.Text.ToString(), txt_GLPass.Text.ToString());
        }
    }
}
