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
    public partial class PostForm : Form
    {
        public string name;
        public string desc;
        public PostForm()
        {
            InitializeComponent();
        }

        public PostForm(string name, string desc)
        {
            InitializeComponent();
            this.name = name;
            this.desc = desc;
            PostName.Text = name;
            PostDes.Text = desc;
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PostName.Text) || !string.IsNullOrEmpty(PostDes.Text))
            {
                name = PostName.Text;
                desc = PostDes.Text;
            }
            else
                DialogResult = DialogResult.Cancel;
        }
    }
}
