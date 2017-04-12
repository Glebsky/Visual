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

        public GoogleAnalytics(string url) {
            BaseUri = url;
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
                    NameUrl = BaseUri.Substring(i);
                    GoogleAnalyticsUrl = "https://www.googleapis.com/urlshortener/v1/url?shortUrl=https%3A%2F%2Fgoo.gl%2F" + NameUrl + "&projection=ANALYTICS_CLICKS&fields=analytics(day%2Cmonth%2CtwoHours%2Cweek)&key=AIzaSyDb9z0f5DiMDB0_hPm-31JZJLDrYX_D9NI";
                }
                else
                {
                    try { 
                    mask = "//";
                    int i = BaseUri.IndexOf(mask) + mask.Length;
                    mask = "/";
                    int lenght = BaseUri.IndexOf(mask, i);
                    lenght -= i;
                    NameUrl = BaseUri.Substring(i, lenght);
                    }catch(Exception) {
                        NameUrl = BaseUri;
                    }
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
            catch(Exception e)
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
            catch(NullReferenceException ex)
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
            catch (NullReferenceException ex)
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
            catch (NullReferenceException ex)
            {
                return "--";
    }
}
    }
}
