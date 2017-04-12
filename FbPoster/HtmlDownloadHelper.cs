using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace FbPoster
{
    class HtmlDownloadHelper
    {
        public static string DownloadHtml(string uri)
        {
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.0; ru; rv:1.9.1.5) Gecko/20091102 Firefox/3.5.5 (.NET CLR 3.5.30729)";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            request.Headers.Set("Accept-Language", "ru,en-us;q=0.7,en;q=0.3");
            request.Headers.Set("Accept-Charset", "windows-1251,utf-8;q=0.7,*;q=0.7");
            request.KeepAlive = true;
            StreamReader sr = new StreamReader(response.GetResponseStream());
            string html = sr.ReadToEnd();
            return html;
        }
    }
}
