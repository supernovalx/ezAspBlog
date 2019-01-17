using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using temp.Models;

namespace temp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BlogContext _context;

        public IndexModel(BlogContext context)
        {
            _context = context;
        }

        public IList<Post> Posts { get; set; }


        public void OnGet()
        {
            Posts = _context.Posts.Include(p => p.Comments).ToList();
        }

        public IActionResult OnPostNewComment(int postId, string author, string content)
        {
            var post = _context.Posts.Include(p => p.Comments).FirstOrDefault(p => p.ID == postId);
            if (post != null)
            {
                if (post.Comments == null)
                {
                    post.Comments = new List<Comment>();
                }

                post.Comments.Add(new Comment
                {
                    Author = author,
                    Content = content
                });
                _context.SaveChanges();
            }

            return RedirectToPage('/');
        }

        public IActionResult OnPostDeleteComment(int commentId)
        {
            _context.Comments.Remove(_context.Comments.FirstOrDefault(c => c.ID == commentId));
            _context.SaveChanges();

            return RedirectToPage('/');
        }
    }
}
