using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
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

        public IList<Post> Posts { get;set; }


        public void OnGet()
        {
            Posts=_context.Posts.Include(p=>p.Comments).ToList();
        }

        public IActionResult OnPostComment(int postId, string author, string content)
        {
            _context.Posts.FirstOrDefault(p=>p.ID==postId).Comments.Append(new Comment{
                Author = author,
                Content = content
            });
            _context.SaveChanges();

            return RedirectToPage('/');
        }


    }
}
