using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClaimIt
{
    public partial class Form1 : Form
    {
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
    }
}
