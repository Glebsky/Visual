using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FB_Poster_Admin
{
    public partial class LinkAdd : Form
    {
        public string url;
        public string name;
        public LinkAdd()
        {
            InitializeComponent();
        }

        public LinkAdd(string link,string name)
        {
            InitializeComponent();
            PostName.Text = link;
            LinkDesFld.Text = name;
            url = link;
            this.name = name;
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PostName.Text) && !string.IsNullOrEmpty(LinkDesFld.Text)) { 
                url = PostName.Text;
                name = LinkDesFld.Text;
            }
            else
                DialogResult = DialogResult.Cancel;
        }
    }
}
