using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;

namespace ParseGroups
{
    class HtmlParser
    {
        public HtmlDocument html;
        public string strHtml;

        public HtmlParser()
        {
            html = new HtmlDocument();
            
        }

        public void LoadDoc(string url)
        {
            WebClient web = new WebClient();
            web.Encoding = Encoding.GetEncoding(1251);
            html.LoadHtml(web.DownloadString(url));
            html.LoadHtml(strHtml);
        }

        public void FromTextToHtml() {
            html.LoadHtml(strHtml);
        }
       
    }
}
