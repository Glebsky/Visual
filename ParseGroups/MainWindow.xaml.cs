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
using mshtml;

namespace ParseGroups
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
        }
        private void ProcessElement(IHTMLElement parentElement)
        {
           
            List<string> str = new List<string>();
            foreach (IHTMLElement element in parentElement.children)
            {
                str.Add(element.outerHTML);
            }
        }

        private void RCV(object sender, RoutedEventArgs e)
        {
            HTMLDocument dd = (HTMLDocument)WebBrowser.Document;
            ProcessElement(dd.documentElement);
        }
    }

}
