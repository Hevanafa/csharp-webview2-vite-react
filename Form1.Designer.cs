﻿namespace CSharpReact
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
            this.MainWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.MainWebView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainWebView
            // 
            this.MainWebView.AllowExternalDrop = true;
            this.MainWebView.CreationProperties = null;
            this.MainWebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.MainWebView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWebView.Location = new System.Drawing.Point(0, 0);
            this.MainWebView.Name = "MainWebView";
            this.MainWebView.Size = new System.Drawing.Size(784, 561);
            this.MainWebView.TabIndex = 0;
            this.MainWebView.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainWebView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainWebView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 MainWebView;
    }
}

