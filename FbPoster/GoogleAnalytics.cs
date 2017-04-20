using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows;

namespace FbPoster
{
    class GoogleAnalytics
    {
        private string html;
        public string BaseUri;
        public string GoogleAnalyticsUrl;
        public string NameUrl;

        public GoogleAnalytics(string url, string name) {
            BaseUri = url;
            NameUrl = name;
            GoogleAnalyticsUrl = "";
            ParseGAUrl();
            DownloadHtml();
        }

        private void ParseGAUrl()
        {
            try
            {
                string mask = "https://goo.gl/";
                if (BaseUri.Contains(mask))
                {
                    int i = BaseUri.IndexOf(mask) + mask.Length;
                    string tempUrl = BaseUri.Substring(i);
                    GoogleAnalyticsUrl = "https://www.googleapis.com/urlshortener/v1/url?shortUrl=https%3A%2F%2Fgoo.gl%2F" + tempUrl + "&projection=ANALYTICS_CLICKS&fields=analytics(day%2Cmonth%2CtwoHours%2Cweek)&key=AIzaSyDb9z0f5DiMDB0_hPm-31JZJLDrYX_D9NI";
                }
            }
            catch (Exception er) { MessageBox.Show(er.Message, "Неудалось распарсить ссылки"); }
        }

        public bool DownloadHtml()
        {
            try { 
            html = HtmlDownloadHelper.DownloadHtml(GoogleAnalyticsUrl);
            return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public string GetDayStat()
        {
            try { 
            string mask = "day";
            int pos = html.IndexOf(mask);
            pos += 30;
            string res = html.Substring(pos,5);
            pos = res.IndexOf("\"", 1);
            res = res.Substring(0, pos);
            return res;
            }
            catch(NullReferenceException)
            {
                return "--";
            }
        }

        public string GetWeekStat()
        {
            try { 
            int pos = html.IndexOf("week", 1);
            pos += 31;
            string res = html.Substring(pos, 5);
            pos = res.IndexOf("\"", 1);
            res = res.Substring(0, pos);
            return res;
            }
            catch (NullReferenceException)
            {
                return "--";
            }
        }

        public string GetMonthStat()
        {
            try { 
            int pos = html.IndexOf("month", 1);
            pos += 32;
            string res = html.Substring(pos, 5);
            pos = res.IndexOf("\"", 1);
            res = res.Substring(0, pos);
            return res;
        }
            catch (NullReferenceException )
            {
                return "--";
    }
}
    }
}
