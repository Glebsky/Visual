using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FbPoster
{
    class Post
    {
        public string Name;
        public string Content;
        public Post() { }

        public Post(string name, string content)
        {
            Name = name;
            Content = content;
        }
    }
}
