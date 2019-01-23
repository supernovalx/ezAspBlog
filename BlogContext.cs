using Microsoft.EntityFrameworkCore;
using ezAspBlog.Models;

namespace ezAspBlog
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public BlogContext(DbContextOptions<BlogContext> options):base(options)
        {
        }


    }
}