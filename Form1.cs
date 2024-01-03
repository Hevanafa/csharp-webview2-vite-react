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
            InitAsync();
        }

        async void InitAsync() {
            await MainWebView.EnsureCoreWebView2Async();

            MainWebView.NavigationStarting += MainWebView_NavigationStarting;

            // This requires the React project to be built first.
            MainWebView.CoreWebView2.SetVirtualHostNameToFolderMapping(
                "react_webview", "dist", CoreWebView2HostResourceAccessKind.Deny);

            MainWebView.CoreWebView2.Navigate("https://react_webview/index.html");
        }

        private void MainWebView_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            var nativeClass = new NativeClass();

            // This will be accessible in JS as:
            //   const frame = (window as any).chrome.webview.hostObjects.frame;
            // Which is derived from:
            //   window.chrome.webview.hostObjects.{name}

            // to call the Add method, use:
            //   await frame.Add(a, b);

            MainWebView.CoreWebView2.AddHostObjectToScript("nativeClass", nativeClass);
        }
    }
}
