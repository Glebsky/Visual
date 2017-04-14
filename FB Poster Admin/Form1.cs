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
        List<Post> links;
        Ftp myftp;
        public Form1()
        {
            links = Download.DownloadLinks("http://organicplant.ucoz.org/FbPoster/links.txt");
            posts = Download.ParsePost("http://organicplant.ucoz.org/FbPoster/Posts/Posts.txt");
            InitializeComponent();

            //Add Posts
            for (int i = 0; i < posts.Count; i++)
                PostBox.Items.Add(posts[i].name);
            //Add Links 
            for (int i = 0; i < links.Count; i++)
                LinkBox.Items.Add(links[i].name);
        }

        private void DeletePost_Click(object sender, EventArgs e)
        {

            if (PostBox.SelectedIndex != -1)
            {
                PostBox.Items.RemoveAt(PostBox.SelectedIndex);
            }
        }

        private void DeleteLink(object sender, EventArgs e)
        {
            LinkBox.Items.Remove(LinkBox.SelectedItem);
        }

        private void AddLink(object sender, EventArgs e)
        {
            LinkAdd pf = new LinkAdd();
            pf.ShowDialog();
            if (pf.DialogResult == DialogResult.OK)
            {
                Post link = new Post(pf.name, pf.url);
                LinkBox.Items.Add(link.name);
                links.Add(link);
            }
        }

        private void ApplyChanges(object sender, EventArgs e)
        {
            myftp = new Ftp();
            List<Post> TempPost = new List<Post>();
            List<Post> Templinks = new List<Post>();

            // Make Posts
            for (int i = 0; i < PostBox.Items.Count; i++)
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
                for (int j = 0; j < links.Count; j++)
                {
                    if (LinkBox.Items[i].ToString() == links[j].name)
                    {
                        Templinks.Add(new Post(links[j].name, links[j].content));
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

            File.Delete("links.txt");
            File.Delete("Posts.txt");
        }

        private void AddPost(object sender, EventArgs e)
        {
            PostForm pf = new PostForm();
            pf.ShowDialog();
            if (pf.DialogResult == DialogResult.OK)
            {
                Post tempPost = new Post(pf.name, pf.desc);
                posts.Add(tempPost);
                PostBox.Items.Add(tempPost.name);
            }
        }

        private void EditLink(object sender, EventArgs e)
        {
            int index = LinkBox.SelectedIndex;
            if (index != -1)
            {

                string str = LinkBox.SelectedItem.ToString();
                int linkId = -1;
                for (int i = 0; i < links.Count; i++)
                {
                    if (str == links[i].name)
                    {
                        linkId = i;
                    }
                }
                LinkAdd editForm = new LinkAdd(links[linkId].content,links[linkId].name);
                editForm.ShowDialog();
                if (editForm.DialogResult == DialogResult.OK && linkId != -1)
                {
                    LinkBox.Items.RemoveAt(index);
                    LinkBox.Items.Insert(index, editForm.name);
                    links[linkId].content = editForm.url;
                    links[linkId].name = editForm.name;
                }
            }
        }

        private void EditPost(object sender, EventArgs e)
        {
            int index = PostBox.SelectedIndex;
            if (index != -1)
            {
                string str = PostBox.SelectedItem.ToString();
                int linkId = -1;
                for (int i = 0; i < posts.Count; i++)
                {
                    if (str == posts[i].name)
                    {
                        linkId = i;
                    }
                }
                PostForm editForm = new PostForm(str, posts[linkId].content);
                editForm.ShowDialog();
                if (editForm.DialogResult == DialogResult.OK && linkId != -1)
                {
                    PostBox.Items.RemoveAt(index);
                    PostBox.Items.Insert(index, editForm.name);
                    posts[index].content = editForm.desc;
                    posts[index].name = editForm.name;

                }
            }
        }

        private void DownPost(object sender, EventArgs e)
        {
            ListBox tmpList;
            if (sender.Equals(PostDownBtn))
                tmpList = PostBox;
            else
                tmpList = LinkBox;

            if (tmpList.SelectedIndex != -1 && tmpList.SelectedIndex != tmpList.Items.Count - 1)
            {
                int select = tmpList.SelectedIndex;
                string selectstr = tmpList.SelectedItem.ToString();
                string newstr = tmpList.Items[select + 1].ToString();
                tmpList.Items.RemoveAt(select);
                tmpList.Items.Insert(select, newstr);
                tmpList.Items.RemoveAt(select + 1);
                tmpList.Items.Insert(select + 1, selectstr);
                tmpList.SelectedIndex = select + 1;
            }
        }
        private void UpPost(object sender, EventArgs e)
        {
            ListBox tmpList;
            if (sender.Equals(UpPostBtn))
                tmpList = PostBox;
            else
                tmpList = LinkBox;

            if (tmpList.SelectedIndex != -1 && tmpList.SelectedIndex != 0)
            {
                int select = tmpList.SelectedIndex;
                string selectstr = tmpList.SelectedItem.ToString();
                string newstr = tmpList.Items[select - 1].ToString();
                tmpList.Items.RemoveAt(select);
                tmpList.Items.Insert(select, newstr);
                tmpList.Items.RemoveAt(select - 1);
                tmpList.Items.Insert(select - 1, selectstr);
                tmpList.SelectedIndex = select - 1;
            }
        }
    }
}