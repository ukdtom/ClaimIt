namespace ClaimIt
{
    partial class Form1
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
            this.lbAbout = new System.Windows.Forms.ListBox();
            this.llSourceCode = new System.Windows.Forms.LinkLabel();
            this.llLicense = new System.Windows.Forms.LinkLabel();
            this.llDownload = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LWStatus = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtbIPAddress = new System.Windows.Forms.MaskedTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClaimIt = new System.Windows.Forms.Button();
            this.lblPMSIP = new System.Windows.Forms.Label();
            this.tbPlexTvPassword2 = new System.Windows.Forms.TextBox();
            this.lblPlexTVPassword2 = new System.Windows.Forms.Label();
            this.tbPlexTvPassword = new System.Windows.Forms.TextBox();
            this.tbPlexTVName = new System.Windows.Forms.TextBox();
            this.lblPlexTVPassword = new System.Windows.Forms.Label();
            this.lblPlexTvLoginName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAbout
            // 
            this.lbAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAbout.FormattingEnabled = true;
            this.lbAbout.ItemHeight = 16;
            this.lbAbout.Items.AddRange(new object[] {
            "Welcome to ClaimIt",
            "This will hopefully assist you in Claiming a Plex Media Server, in case the offic" +
                "ial methods doesn\'t work",
            " ",
            "Note that this is a free utillity, so if you paid for it, you where scammed!",
            "If this utillity was NOT dowloaded from the GitHub link below, then please abort " +
                "this, and then downlowd from the link below!",
            " ",
            "This Utillity will ask you for your plex.tv credentials, which might a concern fo" +
                "r a you, but we need it to authenticate towards plex.tv",
            " ",
            "If you wants to check out the sourcecode, then please review the sourcecode at th" +
                "e link provided below"});
            this.lbAbout.Location = new System.Drawing.Point(12, 12);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(982, 132);
            this.lbAbout.TabIndex = 1;
            this.lbAbout.TabStop = false;
            // 
            // llSourceCode
            // 
            this.llSourceCode.AutoSize = true;
            this.llSourceCode.Location = new System.Drawing.Point(12, 150);
            this.llSourceCode.Name = "llSourceCode";
            this.llSourceCode.Size = new System.Drawing.Size(86, 17);
            this.llSourceCode.TabIndex = 2;
            this.llSourceCode.TabStop = true;
            this.llSourceCode.Text = "SourceCode";
            this.llSourceCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlSourceCode_LinkClicked);
            // 
            // llLicense
            // 
            this.llLicense.AutoSize = true;
            this.llLicense.Location = new System.Drawing.Point(104, 150);
            this.llLicense.Name = "llLicense";
            this.llLicense.Size = new System.Drawing.Size(57, 17);
            this.llLicense.TabIndex = 3;
            this.llLicense.TabStop = true;
            this.llLicense.Text = "License";
            this.llLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlLicense_LinkClicked);
            // 
            // llDownload
            // 
            this.llDownload.AutoSize = true;
            this.llDownload.Location = new System.Drawing.Point(167, 150);
            this.llDownload.Name = "llDownload";
            this.llDownload.Size = new System.Drawing.Size(70, 17);
            this.llDownload.TabIndex = 4;
            this.llDownload.TabStop = true;
            this.llDownload.Text = "Download";
            this.llDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlDownload_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.LWStatus);
            this.panel1.Controls.Add(this.mtbIPAddress);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.btnClaimIt);
            this.panel1.Controls.Add(this.lblPMSIP);
            this.panel1.Controls.Add(this.tbPlexTvPassword2);
            this.panel1.Controls.Add(this.lblPlexTVPassword2);
            this.panel1.Controls.Add(this.tbPlexTvPassword);
            this.panel1.Controls.Add(this.tbPlexTVName);
            this.panel1.Controls.Add(this.lblPlexTVPassword);
            this.panel1.Controls.Add(this.lblPlexTvLoginName);
            this.panel1.Location = new System.Drawing.Point(15, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 351);
            this.panel1.TabIndex = 5;
            // 
            // LWStatus
            // 
            this.LWStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LWStatus.LabelWrap = false;
            this.LWStatus.Location = new System.Drawing.Point(398, 46);
            this.LWStatus.Name = "LWStatus";
            this.LWStatus.Size = new System.Drawing.Size(547, 244);
            this.LWStatus.TabIndex = 12;
            this.LWStatus.TabStop = false;
            this.LWStatus.UseCompatibleStateImageBehavior = false;
            this.LWStatus.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 900;
            // 
            // mtbIPAddress
            // 
            this.mtbIPAddress.Location = new System.Drawing.Point(21, 268);
            this.mtbIPAddress.Mask = "###.###.###.###";
            this.mtbIPAddress.Name = "mtbIPAddress";
            this.mtbIPAddress.Size = new System.Drawing.Size(113, 22);
            this.mtbIPAddress.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(395, 17);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status:";
            // 
            // btnClaimIt
            // 
            this.btnClaimIt.Location = new System.Drawing.Point(21, 311);
            this.btnClaimIt.Name = "btnClaimIt";
            this.btnClaimIt.Size = new System.Drawing.Size(75, 23);
            this.btnClaimIt.TabIndex = 5;
            this.btnClaimIt.Text = "&ClaimIt";
            this.btnClaimIt.UseVisualStyleBackColor = true;
            this.btnClaimIt.Click += new System.EventHandler(this.BtnClaimIt_Click);
            // 
            // lblPMSIP
            // 
            this.lblPMSIP.AutoSize = true;
            this.lblPMSIP.Location = new System.Drawing.Point(18, 228);
            this.lblPMSIP.Name = "lblPMSIP";
            this.lblPMSIP.Size = new System.Drawing.Size(246, 17);
            this.lblPMSIP.TabIndex = 6;
            this.lblPMSIP.Text = "IP Address of your Plex Media Server:";
            // 
            // tbPlexTvPassword2
            // 
            this.tbPlexTvPassword2.Location = new System.Drawing.Point(21, 185);
            this.tbPlexTvPassword2.Name = "tbPlexTvPassword2";
            this.tbPlexTvPassword2.PasswordChar = '*';
            this.tbPlexTvPassword2.Size = new System.Drawing.Size(306, 22);
            this.tbPlexTvPassword2.TabIndex = 3;
            // 
            // lblPlexTVPassword2
            // 
            this.lblPlexTVPassword2.AutoSize = true;
            this.lblPlexTVPassword2.Location = new System.Drawing.Point(18, 150);
            this.lblPlexTVPassword2.Name = "lblPlexTVPassword2";
            this.lblPlexTVPassword2.Size = new System.Drawing.Size(177, 17);
            this.lblPlexTVPassword2.TabIndex = 4;
            this.lblPlexTVPassword2.Text = "plex.tv password repeated:";
            // 
            // tbPlexTvPassword
            // 
            this.tbPlexTvPassword.Location = new System.Drawing.Point(21, 116);
            this.tbPlexTvPassword.Name = "tbPlexTvPassword";
            this.tbPlexTvPassword.PasswordChar = '*';
            this.tbPlexTvPassword.Size = new System.Drawing.Size(306, 22);
            this.tbPlexTvPassword.TabIndex = 2;
            // 
            // tbPlexTVName
            // 
            this.tbPlexTVName.Location = new System.Drawing.Point(21, 46);
            this.tbPlexTVName.Name = "tbPlexTVName";
            this.tbPlexTVName.Size = new System.Drawing.Size(306, 22);
            this.tbPlexTVName.TabIndex = 1;
            // 
            // lblPlexTVPassword
            // 
            this.lblPlexTVPassword.AutoSize = true;
            this.lblPlexTVPassword.Location = new System.Drawing.Point(18, 83);
            this.lblPlexTVPassword.Name = "lblPlexTVPassword";
            this.lblPlexTVPassword.Size = new System.Drawing.Size(116, 17);
            this.lblPlexTVPassword.TabIndex = 1;
            this.lblPlexTVPassword.Text = "plex.tv password:";
            // 
            // lblPlexTvLoginName
            // 
            this.lblPlexTvLoginName.AutoSize = true;
            this.lblPlexTvLoginName.Location = new System.Drawing.Point(18, 17);
            this.lblPlexTvLoginName.Name = "lblPlexTvLoginName";
            this.lblPlexTvLoginName.Size = new System.Drawing.Size(125, 17);
            this.lblPlexTvLoginName.TabIndex = 0;
            this.lblPlexTvLoginName.Text = "plex.tv login name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.llDownload);
            this.Controls.Add(this.llLicense);
            this.Controls.Add(this.llSourceCode);
            this.Controls.Add(this.lbAbout);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbAbout;
        private System.Windows.Forms.LinkLabel llSourceCode;
        private System.Windows.Forms.LinkLabel llLicense;
        private System.Windows.Forms.LinkLabel llDownload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPlexTvPassword;
        private System.Windows.Forms.TextBox tbPlexTVName;
        private System.Windows.Forms.Label lblPlexTVPassword;
        private System.Windows.Forms.Label lblPlexTvLoginName;
        private System.Windows.Forms.TextBox tbPlexTvPassword2;
        private System.Windows.Forms.Label lblPlexTVPassword2;
        private System.Windows.Forms.Button btnClaimIt;
        private System.Windows.Forms.Label lblPMSIP;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MaskedTextBox mtbIPAddress;
        private System.Windows.Forms.ListView LWStatus;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}