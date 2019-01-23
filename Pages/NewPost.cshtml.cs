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
    public class NewPostModel : PageModel
    {
        private IPostData _postData;
        [BindProperty]
        public Post Post { set; get; }

        public NewPostModel(IPostData postData)
        {
            _postData = postData;
        }
        public void OnGet()
        {

        }

        public void OnPostNewPost()
        {

        }


    }
}