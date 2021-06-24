using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Post
    {
        public int Id { get; internal set; }
        public string Title { get; set; }
        public string Resume { get; set; }
        public string Category { get; set; }
    }
}
