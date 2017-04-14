using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FB_Poster_Admin
{
    class FormDoc
    {
        public FormDoc() { }

        public static void FormLinks(List<Post> links)
        {
            StreamWriter sr = new StreamWriter("links.txt");
            string res;
            try
            {
                for (int i = 0; i < links.Count; i++) {
                    res = links[i].name;
                    if (i == links.Count - 1) ;
                    else {
                        res = links[i].name + "\n";
                    }
                    sr.Write(links[i].content+"###"+ res);
                }
                sr.Flush();
                sr.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Не удалось записать файл");
            }
        }

        public static void FormPosts(List<Post> posts)
        {
            StreamWriter sr = new StreamWriter("Posts.txt");
            
            try
            {
                string res;
                for (int i = 0; i < posts.Count; i++)
                {
                    if(i == posts.Count-1)
                    res = posts[i].name + "#\n" + posts[i].content;
                    else
                        res = posts[i].name + "#\n" + posts[i].content + "---\n";
                    sr.Write(res);
                }
                sr.Flush();
                sr.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Не удалось записать файл");
            }
        }
    }
}
