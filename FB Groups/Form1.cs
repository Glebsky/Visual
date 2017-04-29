using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FB_Groups
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser WB;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            string url = "https://www.facebook.com/";
            WB = new ChromiumWebBrowser(url);
            this.pContainer.Controls.Add(WB);
            WB.Dock = DockStyle.Fill;
        }
    }
}
