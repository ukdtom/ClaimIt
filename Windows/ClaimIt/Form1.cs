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
        
        private string PMSID { get; set; }       
        private string PMSUsr { get; set; } 
        private string PMSPwd { get; set; } 
        private string PMSUsrToken { get; set;  }       
        private string PMSClaimItToken { get; set; }
        private string PMSIPAddr { get; set; }
        
        #endregion

        public Form1()
        {
            InitializeComponent();
            // Hide column headers
            LWStatus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
        }

        private void LlSourceCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitClaimIt();
            }
            catch (Exception)
            {
                UpdateStatus("Unable to open link to Github: https://github.com/ukdtom/ClaimIt ", Color.Red);                
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
            UpdateStatus("Idle...", Color.Gray);            
        }

        private void LlLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLicense();
            }
            catch (Exception)
            {
                UpdateStatus("Unable to open link to Github: https://github.com/ukdtom/ClaimIt/blob/master/LICENSE ", Color.Red);                
            }
        }

        private void LlDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitDownload();
            }
            catch (Exception)
            {
                UpdateStatus("Unable to open link to Github: https://github.com/ukdtom/ClaimIt/releases/latest", Color.Red);                
            }
        }

        private Boolean ComparePwd()
        {
            UpdateStatus("Checking entered passwords match", Color.Gray);            
            if (this.tbPlexTvPassword.Text == this.tbPlexTvPassword2.Text)
            {
                UpdateStatus("Password checked...OK", Color.Green);                
                PMSPwd = this.tbPlexTvPassword.Text;
                return true;
            }
            else
            {
                UpdateStatus("Password checked...ERROR...Passwords entered didn't match", Color.Red);                             
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
            UpdateStatus("FATAL ERROR.....Job Aborted", Color.Red);            
        }

        private Boolean GetPMSIdentifier()
        {
            try
            {
                UpdateStatus("Fetching Identifier from PMS", Color.Gray);                
                string url = "http://" + PMSIPAddr + ":32400/identity";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if ((int)response.StatusCode == 200)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(response.GetResponseStream());
                    PMSID = xmlDoc.DocumentElement.GetAttribute("machineIdentifier");
                    UpdateStatus("Got PMS Identifier as: " + PMSID, Color.Green);                    
                    return true;
                }
                else
                {
                    UpdateStatus("PROBLEM: Getting PMS Identifier.....Job Aborted", Color.Red);
                    UpdateStatus("http status was: " + response.StatusCode.ToString(), Color.Red);                    
                    return false;
                }
            }
            catch (Exception ex)
            {
                UpdateStatus("PROBLEM: Getting PMS Identifier.....Job Aborted", Color.Red);
                UpdateStatus("Error was: " + ex.Message, Color.Red);
                return false;
            }                        
        }

        private Boolean GetUserToken()
        {
            try
            { 
                string url = string.Format("https://plex.tv/api/v2/users/signin?login={0}&password={1}&X-Plex-Client-Identifier=ClaimIt-{2}", PMSUsr, PMSPwd, PMSID);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if ((int)response.StatusCode < 300)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(response.GetResponseStream());
                    PMSUsrToken = xmlDoc.DocumentElement.GetAttribute("authToken");
                    UpdateStatus("Got plex.tv User Token as: <SCRAMBLED>", Color.Green);                    
                    return true;
                }
                else
                {
                    UpdateStatus("PROBLEM: getting plex.tv Authentication Token.....Job Aborted", Color.Red);
                    UpdateStatus("http status was: " + response.StatusCode.ToString(), Color.Red);
                    return false;
                }
            }
            catch (Exception ex)
            {
                UpdateStatus("PROBLEM: getting plex.tv Authentication Token.....Job Aborted", Color.Red);
                UpdateStatus("Error was: " + ex.Message, Color.Red);
                return false;
            }
        }

        private Boolean GetClaimToken()
        {
            try
            {
                string url = string.Format("https://plex.tv/api/claim/token?X-Plex-Token={0}&X-Plex-Client-Identifier=ClaimIt-{1}", PMSUsrToken, PMSID);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);                
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if ((int)response.StatusCode == 200)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(response.GetResponseStream());
                    PMSClaimItToken = xmlDoc.DocumentElement.GetAttribute("token");
                    UpdateStatus("Got Claim Token as: " + PMSClaimItToken, Color.Green);                    
                    return true;
                }
                else
                {
                    UpdateStatus("PROBLEM: getting plex.tv Claim Token.....Job Aborted", Color.Red);
                    UpdateStatus("http status was: " + response.StatusCode.ToString(), Color.Red);
                    return false;
                }
            }
            catch (Exception ex)
            {
                UpdateStatus("PROBLEM: Getting PMS Claim Token.....Job Aborted", Color.Red);
                UpdateStatus("Error was: " + ex.Message, Color.Red);
                return false;
            }
        }

        private Boolean ClaimIt()
        {
            try
            {
                string url = string.Format("http://{0}:32400/myplex/claim?token={1}&X-Plex-Client-Identifier=ClaimIt-{2}&X-Plex-Token={3}", PMSIPAddr, PMSClaimItToken, PMSID, PMSUsrToken);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if ((int)response.StatusCode == 200)
                {
                    return true;
                }
                else
                {
                    UpdateStatus("PROBLEM: Can't claim PMS.....Job Aborted", Color.Red);
                    UpdateStatus("http status was: " + response.StatusCode.ToString(), Color.Red);
                    return false;
                }                
            }
            catch (Exception ex)
            {
                UpdateStatus("PROBLEM: Can't Claim PMS.....Job Aborted", Color.Red);                
                UpdateStatus("Error was: " + ex.Message, Color.Red);
                UpdateStatus("If status code is 401, then most likely the PMS was already claimed, and belongs to somebody else!", Color.Red);
                UpdateStatus("If this really is your server, then see: https://support.plex.tv/articles/204281528-why-am-i-locked-out-of-server-settings-and-how-do-i-get-in/", Color.Red);
                return false;
            }
        }

        private void UpdateStatus(string status, Color color)
        {
            // Add item with correct color
            this.LWStatus.Items.Add(LWItem(status, color));
            // Make sure it's visible
            LWStatus.Items[LWStatus.Items.Count - 1].EnsureVisible();
        }

       /// <summary>
       /// Checks if an IP V4 Address is in private address space
       /// </summary>
       /// <param name="ipAddress"></param>
       /// <returns>True if in private address space, else False</returns>
        private bool _IsPrivate(string ipAddress)
        {
            int[] ipParts = ipAddress.Split(new String[] { "." }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(s => int.Parse(s)).ToArray();
            // in private ip range
            if (ipParts[0] == 10 ||
                (ipParts[0] == 192 && ipParts[1] == 168) ||
                (ipParts[0] == 172 && (ipParts[1] >= 16 && ipParts[1] <= 31)))
            {
                return true;
            }

            // IP Address is probably public.
            // This doesn't catch some VPN ranges like OpenVPN and Hamachi.
            return false;
        }

        private void BtnClaimIt_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            PMSUsr = this.tbPlexTVName.Text;
            PMSPwd = this.tbPlexTvPassword.Text;
            PMSIPAddr = mtbIPAddress.Text.Replace(" ", "");
            // Check if address is either loopback or Private
            if (!((PMSIPAddr == "127.0.0.1") || _IsPrivate(PMSIPAddr)))
            {
                UpdateStatus("The IP address entered is not in Private Address Space", Color.Red);
                UpdateStatus("Either '127.0.0.1' or an address in private address space is needed to claim a server", Color.Red);
                UpdateStatus("See: https://en.wikipedia.org/wiki/Private_network", Color.Red);
                FatalError();
            }
            else
            {                               
                // Get IP of PC running this
                IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
                foreach (var IP in localIPs)
                {
                    this.LWStatus.Items.Add(LWItem("This app is running on IP: " + IP.ToString(), Color.Gray));
                }
                UpdateStatus("PMS IP: " + PMSIPAddr, Color.Gray);
                UpdateStatus("Starting to work...", Color.Gray);
                if (ComparePwd())
                {
                    if (GetPMSIdentifier())
                    {
                        if (GetUserToken())
                        {
                            if (GetClaimToken())
                            {
                                if (ClaimIt())
                                {
                                    UpdateStatus("All Done", Color.Green);
                                    UpdateStatus(string.Format("Please close your browser, reopen, and browse to http://{0}:32400/web", PMSIPAddr), Color.Green);
                                }
                                else
                                {
                                    FatalError();
                                }
                            }
                            else
                            {
                                FatalError();
                            }
                        }
                        else
                        {
                            FatalError();
                        }
                    }
                    else
                    {
                        FatalError();
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
}
