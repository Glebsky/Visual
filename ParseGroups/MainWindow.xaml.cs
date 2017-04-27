using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ParseGroups
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HtmlParser parser;
        bool isload = false;
        public MainWindow()
        {
            
            InitializeComponent();
            parser = new HtmlParser();
        }
        private void ProcessElement()
        {
            
            /*List<string> str = new List<string>();
            foreach (IHTMLElement element in parentElement.children)
            {
                str.Add(element.outerHTML);
            }*/
        }

        private void RCV(object sender, RoutedEventArgs e)
        {
            var data = "lsd=AVoV_H3H&display=&enable_profile_selector=&isprivate=&legacy_return=0&profile_selector_ids=&return_session=&skip_api_login=&signed_next=&trynum=1&timezone=-180&lgndim=eyJ3IjoxOTIwLCJoIjoxMDgwLCJhdyI6MTkyMCwiYWgiOjEwNDAsImMiOjI0fQ%3D%3D&lgnrnd=000724_qZJV&lgnjs=1493190448&email=needforpost%40gmail.com&pass=Zp416690jh";
            WebBrowser.Navigate("https://www.facebook.com/login.php?login_attempt=1&next=https%3A%2F%2Fwww.facebook.com%2F%3Fstype%3Dlo%26jlou%3DAffVQpP2XFlXr89IuwoSUsgu49jigao2IR6licjEnjHYDnBTqBLOSWLyDuvny0q2H2RV31XbLx3sGQ1kmEe-sDh5DHOjFtGz3Vg7AfslOLgmHQ%26smuh%3D26516%26lh%3DAc9Ngyw7Li9TWH1q&lwv=101", "_self", System.Text.Encoding.ASCII.GetBytes(data), "content-type:application/x-www-form-urlencoded");
            isload = false;
            WebBrowser.Navigate("https://www.facebook.com/bookmarks/groups/");
        }

        private void LoadCompleted(object sender, NavigationEventArgs e)
        {
            
            dynamic doc = WebBrowser.Document;
            parser.strHtml = doc.documentElement.InnerHtml;
            parser.FromTextToHtml();
            HtmlAgilityPack.HtmlNodeCollection nodes = parser.html.DocumentNode.SelectNodes("//a");
            if (nodes != null)
            {
                foreach (HtmlAgilityPack.HtmlNode item in nodes)
                {
                    //MessageBox.Show(item.InnerHtml);
                }
            }
            isload = true;
            /*MessageBox.Show("OK");
            var html = WebBrowser.Document as mshtml.HTMLDocument;
               html.parentWindow.scroll(0, 10000000);*/
        }
    }

}
