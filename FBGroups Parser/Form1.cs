using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBGroups_Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = "lsd=AVpsS8tD&email=needforpost%40gmail.com&pass=Zp416690jh&timezone=-180&lgndim=eyJ3IjoxMzY2LCJoIjo3NjgsImF3IjoxMzY2LCJhaCI6NzI4LCJjIjoyNH0%3D&lgnrnd=043822_n2ql&lgnjs=1493293100&ab_test_data=AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA&locale=ru_RU&next=https%3A%2F%2Fwww.facebook.com%2F%3Fstype%3Dlo%26jlou%3DAff9BjTJvVtmDBeV9bMMedUd1gVKvXLDj-mpTAgKimOHHmK2NUL9hm54hmH7HKOXLih3Qr_J0Kmacl6V8SLRFXp3W3eDYsNMDvhJ8yuBU968JA%26smuh%3D26516%26lh%3DAc8wV0jhxvoCnvtm&login_source=login_bluebar";
            WB.Navigate("https://www.facebook.com/login.php?login_attempt=1&lwv=110", "_self", ASCIIEncoding.ASCII.GetBytes(data), "content-type:application/x-www-form-urlencoded");
            WB.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WB_DocumentCompleted);
            WB.Navigate("https://www.facebook.com/profile.php?id=100009753484757&lst=100009753484757%3A100009753484757%3A1493294187&sk=groups");
            WB.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WB_DocumentCompleted);

        }

        private void WB_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WB.Document.Window.ScrollTo(0, WB.Document.Window.Size.Height);
       
        }

        private void WB_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            MessageBox.Show("2");
        }
    }
}
