using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ezAspBlog.Models;
using ezAspBlog.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ezAspBlog.Pages
{
    public class ShowPostModel : PageModel
    {
        private IPostData _postData;
        
        public Post Post { set; get; }
        public Comment Comment { set; get; }
        public ShowPostModel(IPostData postData)
        {
            _postData = postData;
        }
        public IActionResult OnGet(int ?id)
        {
            Post = _postData.Get(id);
            if(Post==null)
                return RedirectToPage("/Index");
            return Page();
        }

        public IActionResult OnPostNewComment(int postId, Comment comment)
        {
            if (!ModelState.IsValid) return RedirectToPage();
            _postData.AddComment(postId, comment);
            return RedirectToPage();
        }

        public IActionResult OnPostDeleteComment(int commentId)
        {
            _postData.DeleteComment(commentId);
            return RedirectToPage();
        }
    }
}