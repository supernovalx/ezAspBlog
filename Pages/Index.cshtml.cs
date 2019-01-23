using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ezAspBlog.Models;
using ezAspBlog.Services;

namespace ezAspBlog.Pages
{
    public class IndexModel : PageModel
    {
        private IPostData _postData;

        public IndexModel(IPostData postData)
        {
            _postData = postData;
        }

        public List<Post> Posts { get; set; }

        public void OnGet()
        {
            Posts = _postData.GetAll().ToList();
        }

        public IActionResult OnPostNewComment(int postId, Comment comment)
        {
            _postData.AddComment(postId, comment);
            return RedirectToPage('/');
        }

        public IActionResult OnPostDeleteComment(int commentId)
        {
            _postData.DeleteComment(commentId);

            return RedirectToPage('/');
        }
    }
}
