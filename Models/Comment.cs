using System.ComponentModel.DataAnnotations;

namespace ezAspBlog.Models
{
    public class Comment
    {
        public int ID { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string Author { get; set; }
    }
}