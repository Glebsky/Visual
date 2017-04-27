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
        public List<Post> ParseLinks(string link)
        {
            List<Post> ResLinks = new List<Post>();
            string[] links;
            HttpWebRequest rew = (HttpWebRequest)WebRequest.Create(link);
            // Отправить запрос и получить ответ
            HttpWebResponse resp = (HttpWebResponse)rew.GetResponse();
            // Получить поток
            StreamReader str = new StreamReader(resp.GetResponseStream(),Encoding.UTF8);
           int ch =0;
            string chstring = "";
            for (int i = 1; ; i++)
            {
                ch = str.Read();
                if (ch == -1) break;
                chstring += (char)ch;
                
            }
            // Закрыть поток
            str.Close();
            string[] temp = { "\n" };
            string[] reslink;
            links = chstring.Split(temp, StringSplitOptions.None);
            temp[0] = "###";
            for (int i = 0; i < links.Length; i++)
            {
                reslink = links[i].Split(temp, StringSplitOptions.None);
                Post tmpl = new Post(reslink[1], reslink[0]);
                ResLinks.Add(tmpl);
            }
            return ResLinks;
        }

        public List<Post> ParsePost(string link)
        {
            HttpWebRequest rew = (HttpWebRequest)WebRequest.Create(link);
            // Отправить запрос и получить ответ
            HttpWebResponse resp = (HttpWebResponse)rew.GetResponse();

            // Получить поток
            StreamReader str = new StreamReader(resp.GetResponseStream(), Encoding.UTF8);

            int ch;
            string chstring = "";
            for (int i = 1; ; i++)
            {
                ch = str.Read();
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
