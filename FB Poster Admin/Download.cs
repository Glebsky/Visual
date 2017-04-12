using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace FB_Poster_Admin
{
    class Download
    {
        public static List<Post> ParsePost(string link)
        {
            String[] raws;
            HttpWebRequest rew = (HttpWebRequest)WebRequest.Create(link);
            // Отправить запрос и получить ответ
            HttpWebResponse resp = (HttpWebResponse)rew.GetResponse();

            // Получить поток
            Stream str = resp.GetResponseStream();

            int ch;
            string chstring = "";
            for (int i = 1; ; i++)
            {
                ch = str.ReadByte();
                if (ch == -1) break;
                chstring += (char)ch;
            }
            // Закрыть поток
            str.Close();
            string[] temp = { "---\n", "#\n" };
            raws = chstring.Split(temp, StringSplitOptions.None);
            List<Post> post = new List<Post>();
            for (int i = 0; i < raws.Length; i += 2)
            {
                post.Add(new Post(raws[i], raws[i + 1]));
            }
            return post;
        }
        public static string[] DownloadLinks(string link)
        {
            String[] raws;
            HttpWebRequest rew = (HttpWebRequest)WebRequest.Create(link);
            // Отправить запрос и получить ответ
            HttpWebResponse resp = (HttpWebResponse)rew.GetResponse();

            // Получить поток
            Stream str = resp.GetResponseStream();

            int ch;
            string chstring = "";
            for (int i = 1; ; i++)
            {
                ch = str.ReadByte();
                if (ch == -1) break;
                chstring += (char)ch;
            }
            // Закрыть поток
            str.Close();
            string[] temp = { "\n" };
            raws = chstring.Split(temp, StringSplitOptions.None);
            return raws;
        }
    }
}
