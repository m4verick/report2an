namespace WeeklyReport.View
{
    partial class StudioManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabSM = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Win = new System.Windows.Forms.RadioButton();
            this.rb_Droid = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_PUB = new System.Windows.Forms.RadioButton();
            this.rb_GE = new System.Windows.Forms.RadioButton();
            this.btnSMSubmit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_LocalDeadline = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_iOSDeadline = new System.Windows.Forms.DateTimePicker();
            this.txtSM_HQProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSM_LocalProd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSM_EvolutionUpd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSM_GameTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_GLPass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_GLMailAcc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_SendMailReport = new System.Windows.Forms.Button();
            this.btn_ViewReport = new System.Windows.Forms.Button();
            this.dtp_Report = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.wb_ViewReport = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_GfxAlloc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_GdAlloc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_Producer = new System.Windows.Forms.ComboBox();
            this.txt_QaAlloc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_PrgAlloc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_Producer = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_AddAlloc = new System.Windows.Forms.Button();
            this.TabSM.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Producer)).BeginInit();
            this.SuspendLayout();
            // 
            // TabSM
            // 
            this.TabSM.Controls.Add(this.tabPage1);
            this.TabSM.Controls.Add(this.tabPage2);
            this.TabSM.Controls.Add(this.tabPage3);
            this.TabSM.Location = new System.Drawing.Point(12, 12);
            this.TabSM.Name = "TabSM";
            this.TabSM.SelectedIndex = 0;
            this.TabSM.Size = new System.Drawing.Size(852, 517);
            this.TabSM.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnSMSubmit);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dtp_LocalDeadline);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dtp_iOSDeadline);
            this.tabPage1.Controls.Add(this.txtSM_HQProd);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cmbSM_LocalProd);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtSM_EvolutionUpd);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtSM_GameTitle);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(844, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Win);
            this.groupBox2.Controls.Add(this.rb_Droid);
            this.groupBox2.Location = new System.Drawing.Point(22, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 49);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Platform Type";
            // 
            // rb_Win
            // 
            this.rb_Win.AutoSize = true;
            this.rb_Win.Location = new System.Drawing.Point(14, 18);
            this.rb_Win.Name = "rb_Win";
            this.rb_Win.Size = new System.Drawing.Size(69, 17);
            this.rb_Win.TabIndex = 12;
            this.rb_Win.TabStop = true;
            this.rb_Win.Text = "Windows";
            this.rb_Win.UseVisualStyleBackColor = true;
            // 
            // rb_Droid
            // 
            this.rb_Droid.AutoSize = true;
            this.rb_Droid.Location = new System.Drawing.Point(124, 18);
            this.rb_Droid.Name = "rb_Droid";
            this.rb_Droid.Size = new System.Drawing.Size(61, 17);
            this.rb_Droid.TabIndex = 13;
            this.rb_Droid.TabStop = true;
            this.rb_Droid.Text = "Android";
            this.rb_Droid.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_PUB);
            this.groupBox1.Controls.Add(this.rb_GE);
            this.groupBox1.Location = new System.Drawing.Point(22, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 49);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Type";
            // 
            // rb_PUB
            // 
            this.rb_PUB.AutoSize = true;
            this.rb_PUB.Location = new System.Drawing.Point(18, 19);
            this.rb_PUB.Name = "rb_PUB";
            this.rb_PUB.Size = new System.Drawing.Size(73, 17);
            this.rb_PUB.TabIndex = 9;
            this.rb_PUB.TabStop = true;
            this.rb_PUB.Text = "Publishing";
            this.rb_PUB.UseVisualStyleBackColor = true;
            // 
            // rb_GE
            // 
            this.rb_GE.AutoSize = true;
            this.rb_GE.Location = new System.Drawing.Point(128, 19);
            this.rb_GE.Name = "rb_GE";
            this.rb_GE.Size = new System.Drawing.Size(100, 17);
            this.rb_GE.TabIndex = 10;
            this.rb_GE.TabStop = true;
            this.rb_GE.Text = "Game Evolution";
            this.rb_GE.UseVisualStyleBackColor = true;
            // 
            // btnSMSubmit
            // 
            this.btnSMSubmit.Location = new System.Drawing.Point(202, 419);
            this.btnSMSubmit.Name = "btnSMSubmit";
            this.btnSMSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSMSubmit.TabIndex = 24;
            this.btnSMSubmit.Text = "Submit";
            this.btnSMSubmit.UseVisualStyleBackColor = true;
            this.btnSMSubmit.Click += new System.EventHandler(this.btnSMSubmit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Local Deadline";
            // 
            // dtp_LocalDeadline
            // 
            this.dtp_LocalDeadline.Location = new System.Drawing.Point(158, 353);
            this.dtp_LocalDeadline.Name = "dtp_LocalDeadline";
            this.dtp_LocalDeadline.Size = new System.Drawing.Size(200, 20);
            this.dtp_LocalDeadline.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "iOS Deadline";
            // 
            // dtp_iOSDeadline
            // 
            this.dtp_iOSDeadline.Location = new System.Drawing.Point(158, 305);
            this.dtp_iOSDeadline.Name = "dtp_iOSDeadline";
            this.dtp_iOSDeadline.Size = new System.Drawing.Size(200, 20);
            this.dtp_iOSDeadline.TabIndex = 20;
            // 
            // txtSM_HQProd
            // 
            this.txtSM_HQProd.Location = new System.Drawing.Point(158, 255);
            this.txtSM_HQProd.Name = "txtSM_HQProd";
            this.txtSM_HQProd.Size = new System.Drawing.Size(189, 20);
            this.txtSM_HQProd.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "HQ Producer";
            // 
            // cmbSM_LocalProd
            // 
            this.cmbSM_LocalProd.FormattingEnabled = true;
            this.cmbSM_LocalProd.Location = new System.Drawing.Point(158, 207);
            this.cmbSM_LocalProd.Name = "cmbSM_LocalProd";
            this.cmbSM_LocalProd.Size = new System.Drawing.Size(189, 21);
            this.cmbSM_LocalProd.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Local Producer";
            // 
            // txtSM_EvolutionUpd
            // 
            this.txtSM_EvolutionUpd.Location = new System.Drawing.Point(158, 163);
            this.txtSM_EvolutionUpd.Name = "txtSM_EvolutionUpd";
            this.txtSM_EvolutionUpd.Size = new System.Drawing.Size(189, 20);
            this.txtSM_EvolutionUpd.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Evolution Update Version";
            // 
            // txtSM_GameTitle
            // 
            this.txtSM_GameTitle.Location = new System.Drawing.Point(158, 29);
            this.txtSM_GameTitle.Name = "txtSM_GameTitle";
            this.txtSM_GameTitle.Size = new System.Drawing.Size(189, 20);
            this.txtSM_GameTitle.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Game Title";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_GLPass);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txt_GLMailAcc);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btn_SendMailReport);
            this.tabPage2.Controls.Add(this.btn_ViewReport);
            this.tabPage2.Controls.Add(this.dtp_Report);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.wb_ViewReport);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(844, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_GLPass
            // 
            this.txt_GLPass.Location = new System.Drawing.Point(505, 63);
            this.txt_GLPass.Name = "txt_GLPass";
            this.txt_GLPass.PasswordChar = '*';
            this.txt_GLPass.Size = new System.Drawing.Size(189, 20);
            this.txt_GLPass.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "GL Password";
            // 
            // txt_GLMailAcc
            // 
            this.txt_GLMailAcc.Location = new System.Drawing.Point(505, 27);
            this.txt_GLMailAcc.Name = "txt_GLMailAcc";
            this.txt_GLMailAcc.Size = new System.Drawing.Size(189, 20);
            this.txt_GLMailAcc.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "GL Account";
            // 
            // btn_SendMailReport
            // 
            this.btn_SendMailReport.Location = new System.Drawing.Point(722, 42);
            this.btn_SendMailReport.Name = "btn_SendMailReport";
            this.btn_SendMailReport.Size = new System.Drawing.Size(75, 23);
            this.btn_SendMailReport.TabIndex = 24;
            this.btn_SendMailReport.Text = "Send Mail";
            this.btn_SendMailReport.UseVisualStyleBackColor = true;
            this.btn_SendMailReport.Click += new System.EventHandler(this.btn_SendMailReport_Click);
            // 
            // btn_ViewReport
            // 
            this.btn_ViewReport.Location = new System.Drawing.Point(309, 40);
            this.btn_ViewReport.Name = "btn_ViewReport";
            this.btn_ViewReport.Size = new System.Drawing.Size(75, 23);
            this.btn_ViewReport.TabIndex = 23;
            this.btn_ViewReport.Text = "View";
            this.btn_ViewReport.UseVisualStyleBackColor = true;
            this.btn_ViewReport.Click += new System.EventHandler(this.btn_ViewReport_Click);
            // 
            // dtp_Report
            // 
            this.dtp_Report.Location = new System.Drawing.Point(82, 41);
            this.dtp_Report.Name = "dtp_Report";
            this.dtp_Report.Size = new System.Drawing.Size(189, 20);
            this.dtp_Report.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Date";
            // 
            // wb_ViewReport
            // 
            this.wb_ViewReport.Location = new System.Drawing.Point(14, 104);
            this.wb_ViewReport.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_ViewReport.Name = "wb_ViewReport";
            this.wb_ViewReport.Size = new System.Drawing.Size(816, 381);
            this.wb_ViewReport.TabIndex = 20;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_GfxAlloc);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.txt_GdAlloc);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.cmb_Producer);
            this.tabPage3.Controls.Add(this.txt_QaAlloc);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txt_PrgAlloc);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.dgv_Producer);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btn_AddAlloc);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(844, 491);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_GfxAlloc
            // 
            this.txt_GfxAlloc.Location = new System.Drawing.Point(108, 190);
            this.txt_GfxAlloc.Name = "txt_GfxAlloc";
            this.txt_GfxAlloc.Size = new System.Drawing.Size(93, 20);
            this.txt_GfxAlloc.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "GFX Allocation";
            // 
            // txt_GdAlloc
            // 
            this.txt_GdAlloc.Location = new System.Drawing.Point(108, 158);
            this.txt_GdAlloc.Name = "txt_GdAlloc";
            this.txt_GdAlloc.Size = new System.Drawing.Size(93, 20);
            this.txt_GdAlloc.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "GD Allocation";
            // 
            // cmb_Producer
            // 
            this.cmb_Producer.FormattingEnabled = true;
            this.cmb_Producer.Location = new System.Drawing.Point(108, 53);
            this.cmb_Producer.Name = "cmb_Producer";
            this.cmb_Producer.Size = new System.Drawing.Size(189, 21);
            this.cmb_Producer.TabIndex = 41;
            // 
            // txt_QaAlloc
            // 
            this.txt_QaAlloc.Location = new System.Drawing.Point(108, 123);
            this.txt_QaAlloc.Name = "txt_QaAlloc";
            this.txt_QaAlloc.Size = new System.Drawing.Size(93, 20);
            this.txt_QaAlloc.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "QA Allocation";
            // 
            // txt_PrgAlloc
            // 
            this.txt_PrgAlloc.Location = new System.Drawing.Point(108, 88);
            this.txt_PrgAlloc.Name = "txt_PrgAlloc";
            this.txt_PrgAlloc.Size = new System.Drawing.Size(93, 20);
            this.txt_PrgAlloc.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "PRG Allocation";
            // 
            // dgv_Producer
            // 
            this.dgv_Producer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Producer.Location = new System.Drawing.Point(364, 22);
            this.dgv_Producer.Name = "dgv_Producer";
            this.dgv_Producer.Size = new System.Drawing.Size(462, 450);
            this.dgv_Producer.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Producer";
            // 
            // btn_AddAlloc
            // 
            this.btn_AddAlloc.Location = new System.Drawing.Point(126, 255);
            this.btn_AddAlloc.Name = "btn_AddAlloc";
            this.btn_AddAlloc.Size = new System.Drawing.Size(75, 23);
            this.btn_AddAlloc.TabIndex = 29;
            this.btn_AddAlloc.Text = "Add";
            this.btn_AddAlloc.UseVisualStyleBackColor = true;
            this.btn_AddAlloc.Click += new System.EventHandler(this.btn_AddAlloc_Click);
            // 
            // StudioManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 554);
            this.Controls.Add(this.TabSM);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudioManagerForm";
            this.Text = "Studio Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudioManagerForm_Load);
            this.Resize += new System.EventHandler(this.StudioManagerForm_Resize);
            this.TabSM.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Producer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabSM;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSM_EvolutionUpd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_Droid;
        private System.Windows.Forms.RadioButton rb_Win;
        private System.Windows.Forms.RadioButton rb_GE;
        private System.Windows.Forms.RadioButton rb_PUB;
        private System.Windows.Forms.TextBox txtSM_GameTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_LocalDeadline;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_iOSDeadline;
        private System.Windows.Forms.TextBox txtSM_HQProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSM_LocalProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSMSubmit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SendMailReport;
        private System.Windows.Forms.Button btn_ViewReport;
        private System.Windows.Forms.DateTimePicker dtp_Report;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser wb_ViewReport;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_GLPass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_GLMailAcc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_AddAlloc;
        private System.Windows.Forms.DataGridView dgv_Producer;
        private System.Windows.Forms.ComboBox cmb_Producer;
        private System.Windows.Forms.TextBox txt_QaAlloc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_PrgAlloc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_GfxAlloc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_GdAlloc;
        private System.Windows.Forms.Label label15;
    }
}