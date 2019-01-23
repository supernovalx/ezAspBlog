using ezAspBlog.Models;
using ezAspBlog.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ezAspBlog.Pages
{
    public class NewPostModel : PageModel
    {
        private IPostData _postData;

        public Post Post { set; get; }

        public NewPostModel(IPostData postData)
        {
            _postData = postData;
        }
        public void OnGet()
        {

        }

        public IActionResult OnPostNewPost(Post post)
        {
            if (!ModelState.IsValid)
                return RedirectToPage();
            _postData.AddPost(post);
            return RedirectToPage("Index");
        }
    }
}