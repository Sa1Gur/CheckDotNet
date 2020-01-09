using System;
using System.Diagnostics;
using System.Windows.Forms;
using CheckDotNet.Properties;

namespace CheckDotNet
{
    public partial class InfoWnd : Form
    {
        public InfoWnd()
        {
            InitializeComponent();

            lblInfo.Text = Resources.InfoWnd_InfoWnd;

            lblProduct.Text = Resources.InfoWnd_Product;
            lblVersion.Text = Resources.InfoWnd_Version + Application.ProductVersion;
            lblFirma.Text = Resources.InfoWnd_Firma;
            lblCopyright.Text = Resources.InfoWnd_Copyright;

            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://leochapiro.de";
            linkLabel.Links.Add(link);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }
    }
}
