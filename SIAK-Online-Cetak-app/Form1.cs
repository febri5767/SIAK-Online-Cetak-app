using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIAK_Online_Cetak_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitWebView();
        }

        async void InitWebView()
        {
            await webViewSIAK.EnsureCoreWebView2Async(null);
            webViewSIAK.CoreWebView2.Navigate("https://layananonline.dukcapil.kemendagri.go.id/Terpusat/Cetak");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Dock = DockStyle.Fill;
            this.BringToFront();

            webViewSIAK.Width = Screen.PrimaryScreen.Bounds.Width - 300;
            webViewSIAK.Height = Screen.PrimaryScreen.Bounds.Height;
            webViewSIAK.Focus();
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            if (webViewSIAK != null && webViewSIAK.CoreWebView2 != null)
            {
                webViewSIAK.CoreWebView2.Navigate("https://layananonline.dukcapil.kemendagri.go.id/Terpusat/Cetak");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
