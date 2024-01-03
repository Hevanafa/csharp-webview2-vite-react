using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace CSharpReact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitDebugAsync();
            //InitAsync();
        }

        /// <summary>
        /// Use this for debugging.
        /// </summary>
        async void InitDebugAsync()
        {
            await MainWebView.EnsureCoreWebView2Async();

            MainWebView.NavigationStarting += MainWebView_NavigationStarting;

            // you can change this depending on how you setup the Vite project
            MainWebView.CoreWebView2.Navigate("http://localhost:5173/");
        }

        /// <summary>
        /// This requires the distributable version of the React project (built first).
        /// </summary>
        async void InitAsync() {
            await MainWebView.EnsureCoreWebView2Async();

            MainWebView.NavigationStarting += MainWebView_NavigationStarting;

            MainWebView.CoreWebView2.SetVirtualHostNameToFolderMapping(
                "react_webview", "dist", CoreWebView2HostResourceAccessKind.Deny);

            MainWebView.CoreWebView2.Navigate("https://react_webview/index.html");
        }

        private void MainWebView_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            var nativeClass = new NativeClass();

            // This will be accessible in React as:
            //   const { nativeClass } = window.chrome.webview.hostObjects as CustomHostObjects;
            // Which is derived from:
            //   window.chrome.webview.hostObjects.{name}

            MainWebView.CoreWebView2.AddHostObjectToScript("nativeClass", nativeClass);
        }
    }
}
