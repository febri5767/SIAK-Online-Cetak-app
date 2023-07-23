
namespace SIAK_Online_Cetak_app
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
            this.components = new System.ComponentModel.Container();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.webViewSIAK = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.textBoxCamDevice = new System.Windows.Forms.TextBox();
            this.pictureBoxCam = new System.Windows.Forms.PictureBox();
            this.timerCam = new System.Windows.Forms.Timer(this.components);
            this.buttonSettingCam = new System.Windows.Forms.PictureBox();
            this.buttonKeyboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webViewSIAK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSettingCam)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCetak
            // 
            this.buttonCetak.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCetak.Location = new System.Drawing.Point(834, 80);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(200, 75);
            this.buttonCetak.TabIndex = 0;
            this.buttonCetak.Text = "Cetak";
            this.buttonCetak.UseVisualStyleBackColor = true;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(990, 483);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 75);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // webViewSIAK
            // 
            this.webViewSIAK.AllowExternalDrop = true;
            this.webViewSIAK.CreationProperties = null;
            this.webViewSIAK.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewSIAK.Location = new System.Drawing.Point(1, 1);
            this.webViewSIAK.Name = "webViewSIAK";
            this.webViewSIAK.Size = new System.Drawing.Size(75, 23);
            this.webViewSIAK.TabIndex = 2;
            this.webViewSIAK.ZoomFactor = 1D;
            // 
            // textBoxCamDevice
            // 
            this.textBoxCamDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCamDevice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCamDevice.Enabled = false;
            this.textBoxCamDevice.Location = new System.Drawing.Point(834, 545);
            this.textBoxCamDevice.Name = "textBoxCamDevice";
            this.textBoxCamDevice.Size = new System.Drawing.Size(150, 13);
            this.textBoxCamDevice.TabIndex = 3;
            // 
            // pictureBoxCam
            // 
            this.pictureBoxCam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCam.Location = new System.Drawing.Point(745, 237);
            this.pictureBoxCam.Name = "pictureBoxCam";
            this.pictureBoxCam.Size = new System.Drawing.Size(320, 240);
            this.pictureBoxCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCam.TabIndex = 4;
            this.pictureBoxCam.TabStop = false;
            // 
            // timerCam
            // 
            this.timerCam.Interval = 1000;
            this.timerCam.Tick += new System.EventHandler(this.timerCam_Tick);
            // 
            // buttonSettingCam
            // 
            this.buttonSettingCam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettingCam.Location = new System.Drawing.Point(1015, 12);
            this.buttonSettingCam.Name = "buttonSettingCam";
            this.buttonSettingCam.Size = new System.Drawing.Size(50, 50);
            this.buttonSettingCam.TabIndex = 5;
            this.buttonSettingCam.TabStop = false;
            this.buttonSettingCam.Click += new System.EventHandler(this.buttonSettingCam_Click);
            // 
            // buttonKeyboard
            // 
            this.buttonKeyboard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonKeyboard.Location = new System.Drawing.Point(834, 183);
            this.buttonKeyboard.Name = "buttonKeyboard";
            this.buttonKeyboard.Size = new System.Drawing.Size(200, 50);
            this.buttonKeyboard.TabIndex = 6;
            this.buttonKeyboard.Text = "Keyboard";
            this.buttonKeyboard.UseVisualStyleBackColor = true;
            this.buttonKeyboard.Click += new System.EventHandler(this.buttonKeyboard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 570);
            this.Controls.Add(this.buttonKeyboard);
            this.Controls.Add(this.buttonSettingCam);
            this.Controls.Add(this.pictureBoxCam);
            this.Controls.Add(this.textBoxCamDevice);
            this.Controls.Add(this.webViewSIAK);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCetak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webViewSIAK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSettingCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.Button buttonExit;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewSIAK;
        private System.Windows.Forms.TextBox textBoxCamDevice;
        private System.Windows.Forms.PictureBox pictureBoxCam;
        private System.Windows.Forms.Timer timerCam;
        private System.Windows.Forms.PictureBox buttonSettingCam;
        private System.Windows.Forms.Button buttonKeyboard;
    }
}

