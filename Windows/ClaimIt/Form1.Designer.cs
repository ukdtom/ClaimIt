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
            this.lblPlexTvLoginName = new System.Windows.Forms.Label();
            this.lblPlexTVPassword = new System.Windows.Forms.Label();
            this.tbPlexTVName = new System.Windows.Forms.TextBox();
            this.tbPlexTvPassword = new System.Windows.Forms.TextBox();
            this.lblPlexTVPassword2 = new System.Windows.Forms.Label();
            this.tbPlexTvPassword2 = new System.Windows.Forms.TextBox();
            this.lblPMSIP = new System.Windows.Forms.Label();
            this.tbIPPMS = new System.Windows.Forms.TextBox();
            this.btnClaimIt = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAbout
            // 
            this.lbAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAbout.Enabled = false;
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
            "This Utillity will ask you for your plex.tv credentials, which is a concern for a" +
                " you, so if in doubt, please review the sourcecode at the link provided below"});
            this.lbAbout.Location = new System.Drawing.Point(12, 12);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(982, 132);
            this.lbAbout.TabIndex = 1;
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
            this.llDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDownload_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.btnClaimIt);
            this.panel1.Controls.Add(this.tbIPPMS);
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
            // lblPlexTvLoginName
            // 
            this.lblPlexTvLoginName.AutoSize = true;
            this.lblPlexTvLoginName.Location = new System.Drawing.Point(18, 17);
            this.lblPlexTvLoginName.Name = "lblPlexTvLoginName";
            this.lblPlexTvLoginName.Size = new System.Drawing.Size(125, 17);
            this.lblPlexTvLoginName.TabIndex = 0;
            this.lblPlexTvLoginName.Text = "plex.tv login name:";
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
            // tbPlexTVName
            // 
            this.tbPlexTVName.Location = new System.Drawing.Point(21, 46);
            this.tbPlexTVName.Name = "tbPlexTVName";
            this.tbPlexTVName.Size = new System.Drawing.Size(306, 22);
            this.tbPlexTVName.TabIndex = 2;
            // 
            // tbPlexTvPassword
            // 
            this.tbPlexTvPassword.Location = new System.Drawing.Point(21, 116);
            this.tbPlexTvPassword.Name = "tbPlexTvPassword";
            this.tbPlexTvPassword.PasswordChar = '*';
            this.tbPlexTvPassword.Size = new System.Drawing.Size(306, 22);
            this.tbPlexTvPassword.TabIndex = 3;
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
            // tbPlexTvPassword2
            // 
            this.tbPlexTvPassword2.Location = new System.Drawing.Point(21, 185);
            this.tbPlexTvPassword2.Name = "tbPlexTvPassword2";
            this.tbPlexTvPassword2.PasswordChar = '*';
            this.tbPlexTvPassword2.Size = new System.Drawing.Size(306, 22);
            this.tbPlexTvPassword2.TabIndex = 5;
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
            // tbIPPMS
            // 
            this.tbIPPMS.Location = new System.Drawing.Point(21, 262);
            this.tbIPPMS.Name = "tbIPPMS";
            this.tbIPPMS.Size = new System.Drawing.Size(306, 22);
            this.tbIPPMS.TabIndex = 7;
            // 
            // btnClaimIt
            // 
            this.btnClaimIt.Location = new System.Drawing.Point(21, 311);
            this.btnClaimIt.Name = "btnClaimIt";
            this.btnClaimIt.Size = new System.Drawing.Size(75, 23);
            this.btnClaimIt.TabIndex = 8;
            this.btnClaimIt.Text = "&ClaimIt";
            this.btnClaimIt.UseVisualStyleBackColor = true;
            // 
            // lbStatus
            // 
            this.lbStatus.Enabled = false;
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.ItemHeight = 16;
            this.lbStatus.Items.AddRange(new object[] {
            "Waiting for user to start"});
            this.lbStatus.Location = new System.Drawing.Point(398, 46);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(557, 244);
            this.lbStatus.TabIndex = 9;
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
        private System.Windows.Forms.TextBox tbIPPMS;
        private System.Windows.Forms.Label lblPMSIP;
        private System.Windows.Forms.ListBox lbStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}