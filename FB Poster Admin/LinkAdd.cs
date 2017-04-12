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
        public LinkAdd()
        {
            InitializeComponent();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PostName.Text))
                url = PostName.Text;
            else
                DialogResult = DialogResult.Cancel;
        }
    }
}
