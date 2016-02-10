namespace WeeklyReport.View
{
    partial class ProducerForm
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
            this.tabProd = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txt_Attention = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Situation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_iOSDeadline = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LocalDeadline = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_GameTitle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtp_ETA = new System.Windows.Forms.DateTimePicker();
            this.btn_SubmitRisk = new System.Windows.Forms.Button();
            this.cmb_GameTitleRisk = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Minimize = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Cons = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_Impact = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_Likelyhood = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_List = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabProd.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProd
            // 
            this.tabProd.Controls.Add(this.tabPage1);
            this.tabProd.Controls.Add(this.tabPage2);
            this.tabProd.Location = new System.Drawing.Point(12, 12);
            this.tabProd.Name = "tabProd";
            this.tabProd.SelectedIndex = 0;
            this.tabProd.Size = new System.Drawing.Size(617, 620);
            this.tabProd.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Submit);
            this.tabPage1.Controls.Add(this.txt_Attention);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_Situation);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_iOSDeadline);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_LocalDeadline);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbStatus);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmb_GameTitle);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(609, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(285, 452);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 52;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txt_Attention
            // 
            this.txt_Attention.Location = new System.Drawing.Point(171, 303);
            this.txt_Attention.Multiline = true;
            this.txt_Attention.Name = "txt_Attention";
            this.txt_Attention.Size = new System.Drawing.Size(285, 107);
            this.txt_Attention.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Need Your Attention";
            // 
            // txt_Situation
            // 
            this.txt_Situation.Location = new System.Drawing.Point(171, 176);
            this.txt_Situation.Multiline = true;
            this.txt_Situation.Name = "txt_Situation";
            this.txt_Situation.Size = new System.Drawing.Size(285, 107);
            this.txt_Situation.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Situation - Next Goals";
            // 
            // txt_iOSDeadline
            // 
            this.txt_iOSDeadline.Location = new System.Drawing.Point(171, 132);
            this.txt_iOSDeadline.Name = "txt_iOSDeadline";
            this.txt_iOSDeadline.ReadOnly = true;
            this.txt_iOSDeadline.Size = new System.Drawing.Size(189, 20);
            this.txt_iOSDeadline.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "iOS Deadline";
            // 
            // txt_LocalDeadline
            // 
            this.txt_LocalDeadline.Location = new System.Drawing.Point(171, 93);
            this.txt_LocalDeadline.Name = "txt_LocalDeadline";
            this.txt_LocalDeadline.ReadOnly = true;
            this.txt_LocalDeadline.Size = new System.Drawing.Size(189, 20);
            this.txt_LocalDeadline.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Deadline";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "On Track",
            "Off Track",
            "On Track With Risks",
            "Off Track due iOS Status"});
            this.cmbStatus.Location = new System.Drawing.Point(171, 51);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(189, 21);
            this.cmbStatus.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Status";
            // 
            // cmb_GameTitle
            // 
            this.cmb_GameTitle.FormattingEnabled = true;
            this.cmb_GameTitle.Location = new System.Drawing.Point(171, 14);
            this.cmb_GameTitle.Name = "cmb_GameTitle";
            this.cmb_GameTitle.Size = new System.Drawing.Size(189, 21);
            this.cmb_GameTitle.TabIndex = 29;
            this.cmb_GameTitle.SelectionChangeCommitted += new System.EventHandler(this.cmb_GameTitle_SelectionChangeCommitted);
            this.cmb_GameTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_GameTitle_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Game Title";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtp_ETA);
            this.tabPage2.Controls.Add(this.btn_SubmitRisk);
            this.tabPage2.Controls.Add(this.cmb_GameTitleRisk);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txt_Minimize);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txt_Cons);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.cmb_Impact);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cmb_Likelyhood);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txt_List);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(609, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtp_ETA
            // 
            this.dtp_ETA.Location = new System.Drawing.Point(162, 528);
            this.dtp_ETA.Name = "dtp_ETA";
            this.dtp_ETA.Size = new System.Drawing.Size(285, 20);
            this.dtp_ETA.TabIndex = 68;
            // 
            // btn_SubmitRisk
            // 
            this.btn_SubmitRisk.Location = new System.Drawing.Point(293, 557);
            this.btn_SubmitRisk.Name = "btn_SubmitRisk";
            this.btn_SubmitRisk.Size = new System.Drawing.Size(75, 23);
            this.btn_SubmitRisk.TabIndex = 66;
            this.btn_SubmitRisk.Text = "Submit";
            this.btn_SubmitRisk.UseVisualStyleBackColor = true;
            this.btn_SubmitRisk.Click += new System.EventHandler(this.btn_SubmitRisk_Click);
            // 
            // cmb_GameTitleRisk
            // 
            this.cmb_GameTitleRisk.FormattingEnabled = true;
            this.cmb_GameTitleRisk.Location = new System.Drawing.Point(162, 19);
            this.cmb_GameTitleRisk.Name = "cmb_GameTitleRisk";
            this.cmb_GameTitleRisk.Size = new System.Drawing.Size(189, 21);
            this.cmb_GameTitleRisk.TabIndex = 65;
            this.cmb_GameTitleRisk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_GameTitleRisk_MouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Game Title";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 534);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "ETA for Solution";
            // 
            // txt_Minimize
            // 
            this.txt_Minimize.Location = new System.Drawing.Point(162, 408);
            this.txt_Minimize.Multiline = true;
            this.txt_Minimize.Name = "txt_Minimize";
            this.txt_Minimize.Size = new System.Drawing.Size(285, 107);
            this.txt_Minimize.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "What can we do";
            // 
            // txt_Cons
            // 
            this.txt_Cons.Location = new System.Drawing.Point(162, 282);
            this.txt_Cons.Multiline = true;
            this.txt_Cons.Name = "txt_Cons";
            this.txt_Cons.Size = new System.Drawing.Size(285, 107);
            this.txt_Cons.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Consequences";
            // 
            // cmb_Impact
            // 
            this.cmb_Impact.FormattingEnabled = true;
            this.cmb_Impact.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cmb_Impact.Location = new System.Drawing.Point(162, 235);
            this.cmb_Impact.Name = "cmb_Impact";
            this.cmb_Impact.Size = new System.Drawing.Size(189, 21);
            this.cmb_Impact.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Impact";
            // 
            // cmb_Likelyhood
            // 
            this.cmb_Likelyhood.FormattingEnabled = true;
            this.cmb_Likelyhood.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cmb_Likelyhood.Location = new System.Drawing.Point(162, 185);
            this.cmb_Likelyhood.Name = "cmb_Likelyhood";
            this.cmb_Likelyhood.Size = new System.Drawing.Size(189, 21);
            this.cmb_Likelyhood.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Likehood";
            // 
            // txt_List
            // 
            this.txt_List.Location = new System.Drawing.Point(162, 58);
            this.txt_List.Multiline = true;
            this.txt_List.Name = "txt_List";
            this.txt_List.Size = new System.Drawing.Size(285, 107);
            this.txt_List.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "List of Possible Risks";
            // 
            // ProducerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(854, 641);
            this.Controls.Add(this.tabProd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProducerForm";
            this.Text = "Producer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabProd.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txt_Attention;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Situation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_iOSDeadline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_LocalDeadline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_GameTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_SubmitRisk;
        private System.Windows.Forms.ComboBox cmb_GameTitleRisk;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Minimize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Cons;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_Impact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_Likelyhood;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_List;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_ETA;

    }
}