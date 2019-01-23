using ezAspBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ezAspBlog.Services
{
    public interface IPostData
    {
        IEnumerable<Post> GetAll();
        Post Get(int Id);
        void Remove(int Id);
        Post Update(Post post);
        Comment AddComment(int postId, Comment comment);
        void DeleteComment(int commentId);
    }
}
