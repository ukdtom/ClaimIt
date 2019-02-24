using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Xml;



namespace ClaimIt
{
    public partial class Form1 : Form
    {

        #region Parameters

        private string PMSID
        {
            get;set;
        }

        private string PMSUsr
        {
            get;set;
        }

        private string PMSPwd
        {
            get; set;
        }

        private string PMSUsrToken
        {
            get; set;
        }

        private string PMSClaimItToken
        {
            get; set;
        }

        private string PMSIPAddr
        {
            get; set;
        }

        private string _machineIdentifier;
        private string machineIdentifier
        {
            get
            {
                return _machineIdentifier;
            }
            set
            {
                _machineIdentifier = value;
            }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }


        private void LlSourceCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitClaimIt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link to Github: https://github.com/ukdtom/ClaimIt ");
            }
        }

        private void VisitClaimIt()
        {
            // Change the color of the link text by setting LinkVisited   
            // to true.  
            llSourceCode.LinkVisited = true;
            //Call the Process.Start method to open the default browser   
            //with a URL:  
            System.Diagnostics.Process.Start("https://github.com/ukdtom/ClaimIt");
        }

        private void VisitLicense()
        {
            // Change the color of the link text by setting LinkVisited   
            // to true.  
            llLicense.LinkVisited = true;
            //Call the Process.Start method to open the default browser   
            //with a URL:  
            System.Diagnostics.Process.Start("https://github.com/ukdtom/ClaimIt/blob/master/LICENSE");
        }

        private void VisitDownload()
        {
            // Change the color of the link text by setting LinkVisited   
            // to true.  
            llDownload.LinkVisited = true;
            //Call the Process.Start method to open the default browser   
            //with a URL:  
            System.Diagnostics.Process.Start("https://github.com/ukdtom/ClaimIt/releases/latest");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " Version: " + Application.ProductVersion;
            this.mtbIPAddress.ValidatingType = typeof(System.Net.IPAddress);
            this.LWStatus.Items.Add(LWItem("Idle...", Color.Gray));
        }

        private void LlLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLicense();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link to Github: https://github.com/ukdtom/ClaimIt/blob/master/LICENSE ");
            }
        }

        private void llDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitDownload();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link to Github: https://github.com/ukdtom/ClaimIt/releases/latest ");
            }
        }

        private Boolean ComparePwd()
        {
            this.LWStatus.Items.Add(LWItem("Checking entered passwords match", Color.Gray));
            if (this.tbPlexTvPassword.Text == this.tbPlexTvPassword2.Text)
            {
                this.LWStatus.Items.Add(LWItem("Password checked...OK", Color.Green));
                PMSPwd = this.tbPlexTvPassword.Text;
                return true;
            }
            else
            {
                this.LWStatus.Items.Add(LWItem("Password checked...ERROR...Passwords entered didn't match", Color.Red));                
                return false;
            }
        }

        private ListViewItem LWItem( string ItemText, System.Drawing.Color Color)
        {
            ListViewItem LWItemEntry = new ListViewItem
            {
                Text = ItemText,                
                ForeColor = Color
            };
            return LWItemEntry;
        }

        private void FatalError()
        {
            this.LWStatus.Items.Add(LWItem("FATAL ERROR.....Job Aborted", Color.Red));
        }

        private Boolean GetPMSIdentifier()
        {
            try
            {
                this.LWStatus.Items.Add(LWItem("Fetching Identifier from PMS", Color.Gray));
                string url = "http://" + mtbIPAddress.Text.Replace(" ", "") + ":32400/identity";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if ((int)response.StatusCode == 200)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(response.GetResponseStream());
                    machineIdentifier = xmlDoc.DocumentElement.GetAttribute("machineIdentifier");
                    this.LWStatus.Items.Add(LWItem("Got PMS Identifier as: " + machineIdentifier, Color.Green));
                    return true;
                }
                else
                {
                    this.LWStatus.Items.Add(LWItem("PROBLEM GETTING PMS IDENTIFIER.....Job Aborted", Color.Red));
                    this.LWStatus.Items.Add(LWItem("http status was: " + response.StatusCode.ToString(), Color.Red));
                    return false;
                }
            }
            catch (Exception ex)
            {
                this.LWStatus.Items.Add(LWItem("PROBLEM GETTING PMS IDENTIFIER.....Job Aborted", Color.Red));
                this.LWStatus.Items.Add(LWItem("Error was: " + ex.Message, Color.Red));
                return false;
            }                        
        }

        private void BtnClaimIt_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;            
            this.LWStatus.Items.Add(LWItem("Starting to work...", Color.Gray));
            if (ComparePwd())
            {
                if (GetPMSIdentifier())
                {
                    this.LWStatus.Items.Add(LWItem("All Done", Color.Green));
                }
             
            }
            else
            {
                FatalError();
            }            
            Cursor.Current = Cursors.Default;
        }
    }
}
