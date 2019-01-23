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

        public Post Post;
        public ShowPostModel(IPostData postData)
        {
            _postData = postData;
        }
        public void OnGet(int id)
        {
            Post = _postData.Get(id);
        }
    }
}