using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using System.Diagnostics;

namespace SIAK_Online_Cetak_app
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection captureDevices;
        private VideoCaptureDevice captureDevice;
        private Process onscreenProcess;
        public Form1()
        {
            InitializeComponent();
            InitWebView();
        }

        async void InitWebView()
        {
            await webViewSIAK.EnsureCoreWebView2Async(null);
            webViewSIAK.CoreWebView2.Navigate("https://layananonline.dukcapil.kemendagri.go.id/Terpusat/Cetak/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Resize windows
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Dock = DockStyle.Fill;
            this.BringToFront();

            //Resize webview
            webViewSIAK.Width = Screen.PrimaryScreen.Bounds.Width - 350;
            webViewSIAK.Height = Screen.PrimaryScreen.Bounds.Height;

            //Cek camera
            captureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (captureDevices.Count <= 0)
            {
                MessageBox.Show("no camera detected", "SIAK Cetak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                foreach (FilterInfo device in captureDevices)
                {
                    textBoxCamDevice.Text = device.Name;
                }

                SetCamera();
                StartCamera();
            }
            
            webViewSIAK.Focus();
        }

        private void SetCamera()
        {
            captureDevice = new VideoCaptureDevice(captureDevices[0].MonikerString);//hardcode first camera
            captureDevice.NewFrame += new NewFrameEventHandler(CaptureDevice_NewFrame);
            //Cek camera capabilities
            for (int i = 0; i < captureDevice.VideoCapabilities.Length; i++)
            {
                string resolution = "Resolution Number " + Convert.ToString(i);
                string resolutionSize = captureDevice.VideoCapabilities[i].FrameSize.ToString();
                Debug.WriteLine(resolution + " " + resolutionSize);
            }
            //for Logi C270
            //Resolution Number 0 { Width = 640, Height = 480}
            //Resolution Number 1 { Width = 160, Height = 120}
            //Resolution Number 2 { Width = 176, Height = 144}
            //Resolution Number 3 { Width = 320, Height = 176}
            //Resolution Number 4 { Width = 320, Height = 240}
            //Resolution Number 5 { Width = 352, Height = 288}
            //Resolution Number 6 { Width = 432, Height = 240}
            //Resolution Number 7 { Width = 544, Height = 288}
            //Resolution Number 8 { Width = 640, Height = 360}
            //Resolution Number 9 { Width = 752, Height = 416}
            //Resolution Number 10 { Width = 800, Height = 448}
            //Resolution Number 11 { Width = 800, Height = 600}
            //Resolution Number 12 { Width = 864, Height = 480}
            //Resolution Number 13 { Width = 960, Height = 544}
            //Resolution Number 14 { Width = 960, Height = 720}
            //Resolution Number 15 { Width = 1024, Height = 576}
            //Resolution Number 16 { Width = 1184, Height = 656}
            //Resolution Number 17 { Width = 1280, Height = 720}
            //Resolution Number 18 { Width = 1280, Height = 960}
            //captureDevice.VideoResolution = captureDevice.VideoCapabilities[4];
        }

        private void StartCamera() 
        {
            captureDevice.Start();
            timerCam.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs) 
        {
            pictureBoxCam.Image = (Bitmap)eventArgs.Frame.Clone();
        }


        private void buttonCetak_Click(object sender, EventArgs e)
        {
            CloseOnScreenKeyboard();
            if (webViewSIAK != null && webViewSIAK.CoreWebView2 != null)
            {
                webViewSIAK.CoreWebView2.Navigate("https://layananonline.dukcapil.kemendagri.go.id/Terpusat/Cetak/");
                StartCamera();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null && captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }

        private void timerCam_Tick(object sender, EventArgs e)
        {
            if (pictureBoxCam.Image != null) 
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBoxCam.Image);
                if (result != null) 
                {
                    timerCam.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                    
                    webViewSIAK.ExecuteScriptAsync("document.getElementById('PIN').value=" + '\'' + result.ToString() + '\'');
                    webViewSIAK.Focus();
                    pictureBoxCam.Image = null;
                    ShowOnScreenKeyboard();
                }
            }
        }

        private void buttonSettingCam_Click(object sender, EventArgs e)
        {
            if (captureDevice != null)
            {
                captureDevice.DisplayPropertyPage(IntPtr.Zero);
            }
        }

        private void ShowOnScreenKeyboard() 
        {
            //string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            //string onScreenKeyboardPath = System.IO.Path.Combine(progFiles, "TabTip.exe");
            //onscreenProcess = System.Diagnostics.Process.Start(onScreenKeyboardPath);
            onscreenProcess = System.Diagnostics.Process.Start("osk.exe");
        }

        private void CloseOnScreenKeyboard() 
        {
            if (onscreenProcess != null)
            {
                if (!onscreenProcess.HasExited)
                {
                    onscreenProcess.Kill();
                }
                onscreenProcess = null;
            }
        }

        private void buttonKeyboard_Click(object sender, EventArgs e)
        {
            if (onscreenProcess != null)
            {
                CloseOnScreenKeyboard();
            }
            else 
            {
                ShowOnScreenKeyboard();
            }
        }
    }
}
