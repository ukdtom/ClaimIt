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
            this.button1 = new System.Windows.Forms.Button();
            this.lbAbout = new System.Windows.Forms.ListBox();
            this.llSourceCode = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            " ",
            "This was made by dane22, a Plex Community Member"});
            this.lbAbout.Location = new System.Drawing.Point(12, 12);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(982, 116);
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
            this.llSourceCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSourceCode_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.llSourceCode);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbAbout;
        private System.Windows.Forms.LinkLabel llSourceCode;
    }
}