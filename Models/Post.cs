using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ezAspBlog.Models
{
    public class Post
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]

        public string Content { get; set; }
        [Required]

        public string Author { get; set; }
        public List<Comment> Comments { get; set; }

    }
}