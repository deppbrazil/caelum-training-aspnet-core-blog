using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required] [StringLength(50)]
        public string Title { get; set; }

        [Required]
        public string Resume { get; set; }

        public string Category { get; set; }
        public DateTime? PublicationDate { get; set; }
        public bool Publicated { get; set; }
    }
}
