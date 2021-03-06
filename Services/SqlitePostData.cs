﻿using ezAspBlog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ezAspBlog.Services
{
    public class SqlPostData : IPostData
    {
        private BlogContext _blogContext;

        public SqlPostData(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public Comment AddComment(int postId, Comment comment)
        {
            var post = this.Get(postId);
            if (post != null)
            {
                if (post.Comments == null)
                {
                    post.Comments = new List<Comment>();
                }

                post.Comments.Add(comment);
                _blogContext.SaveChanges();
            }
            return comment;
        }

        public void AddPost(Post post)
        {
            _blogContext.Add(post);
            _blogContext.SaveChanges();
        }

        public void DeleteComment(int commentId)
        {
            _blogContext.Comments.Remove(_blogContext.Comments.FirstOrDefault(c => c.ID == commentId));
            _blogContext.SaveChanges();
        }

        public Post Get(int? Id)
        {
            return Id == null ? null : _blogContext.Posts.Include(p => p.Comments).FirstOrDefault(x => x.ID == Id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _blogContext.Posts.Include(p => p.Comments);
        }

        public void Remove(int Id)
        {
            _blogContext.Posts.Remove(this.Get(Id));
            _blogContext.SaveChanges();
        }

        public Post Update(Post post)
        {
            _blogContext.Posts.Attach(post);
            _blogContext.SaveChanges();
            return post;
        }
    }
}
