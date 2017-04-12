using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FB_Poster_Admin
{
    public partial class Form1 : Form
    {
        List<Post> posts;
        string[] links;
        Ftp myftp;
        public Form1()
        {
            links = Download.DownloadLinks("http://organicplant.ucoz.org/FbPoster/links.txt");
            posts = Download.ParsePost("http://organicplant.ucoz.org/FbPoster/Posts/Posts.txt");
            InitializeComponent();

            //Add Posts
            for(int i =0;i<posts.Count;i++)
            PostBox.Items.Add(posts[i].name);
            //Add Links
            for (int i = 0; i < links.Length; i++)
                LinkBox.Items.Add(links[i]);
        }

        private void PostBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeletePost_Click(object sender, EventArgs e)
        {
            
            if(PostBox.SelectedIndex != -1)
            {
                PostBox.Items.RemoveAt(PostBox.SelectedIndex);
            }
        }

        private void LinkBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteLink(object sender, EventArgs e)
        {
            LinkBox.Items.Remove(LinkBox.SelectedItem);
        }

        private void AddLink(object sender, EventArgs e)
        {
            LinkAdd pf = new LinkAdd();
            pf.ShowDialog();
            if(pf.DialogResult == DialogResult.OK) { 
            string tlink = pf.url;
            string[] tlinks = new string[links.Length + 1];
            links.CopyTo(tlinks, 0);
            tlinks[links.Length] = tlink;
            links = tlinks;
            LinkBox.Items.Add(tlink);
            }
        }

        private void ApplyChanges(object sender, EventArgs e)
        {
            myftp = new Ftp();
            List<Post> TempPost = new List<Post>();
            string[] Templinks = new string[LinkBox.Items.Count];

            // Make Posts
            for(int i = 0; i< PostBox.Items.Count;i++)
            {
                for (int j = 0; j < posts.Count; j++)
                {
                    if (PostBox.Items[i].ToString() == posts[j].name)
                    {
                        TempPost.Add(posts[j]);
                    }
                }
            }
            // Make Links
            for (int i = 0; i < LinkBox.Items.Count; i++)
            {
                for (int j = 0; j < links.Length; j++)
                {
                    if (LinkBox.Items[i].ToString() == links[j])
                    {
                        Templinks[i] = links[j];
                    }
                }
            }
            links = Templinks;
            posts = TempPost;
            FormDoc.FormLinks(links);
            FormDoc.FormPosts(posts);

            myftp.CompleteDPath = "ftp://forganicplant@organicplant.ucoz.org/FbPoster/";
            myftp.UploadFile("links.txt");
            myftp.CompleteDPath = "ftp://forganicplant@organicplant.ucoz.org/FbPoster/Posts/";
            myftp.UploadFile("Posts.txt");

           
            File.Delete("Posts.txt");
        }

        private void AddPost(object sender, EventArgs e)
        {
            PostForm pf = new PostForm();
            pf.ShowDialog();
            if(pf.DialogResult == DialogResult.OK) { 
            Post tempPost = new Post(pf.name, pf.desc);
            posts.Add(tempPost);
            PostBox.Items.Add(tempPost.name);
            }
        }
    }
    }