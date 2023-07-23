
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
            this.buttonCetak = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.webViewSIAK = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webViewSIAK)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCetak
            // 
            this.buttonCetak.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCetak.Location = new System.Drawing.Point(580, 141);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(155, 75);
            this.buttonCetak.TabIndex = 0;
            this.buttonCetak.Text = "Cetak";
            this.buttonCetak.UseVisualStyleBackColor = true;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(713, 363);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webViewSIAK);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCetak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webViewSIAK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.Button buttonExit;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewSIAK;
    }
}

