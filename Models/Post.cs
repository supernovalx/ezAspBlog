using System.Collections.Generic;

namespace temp.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public List<Comment> Comments { get; set; }

    }
}