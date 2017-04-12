using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace FbPoster
{
    class TextParser
    {
        public string[] raws;
        private string link;

        public TextParser(string link)
        {
            this.link = link;
        }
        public string[] ParseLinks(string link)
        {
            HttpWebRequest rew = (HttpWebRequest)WebRequest.Create(link);
            // Отправить запрос и получить ответ
            HttpWebResponse resp = (HttpWebResponse)rew.GetResponse();

            // Получить поток
            Stream str = resp.GetResponseStream();

            int ch;
            int arr = 0;
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

        public List<Post> ParsePost(string link)
        {
            HttpWebRequest rew = (HttpWebRequest)WebRequest.Create(link);
            // Отправить запрос и получить ответ
            HttpWebResponse resp = (HttpWebResponse)rew.GetResponse();

            // Получить поток
            Stream str = resp.GetResponseStream();

            int ch;
            int arr = 0;
            string chstring = "";
            for (int i = 1; ; i++)
            {
                ch = str.ReadByte();
                if (ch == -1) break;
                chstring += (char)ch;
            }
            // Закрыть поток
            str.Close();
            string[] temp = { "---\n","#\n"};
            raws = chstring.Split(temp, StringSplitOptions.None);
            List<Post> post = new List<Post>();
            for(int i = 0;i< raws.Length; i+=2)
            {
                post.Add(new Post(raws[i], raws[i + 1]));
            }
            return post;
        }
    }
    }
