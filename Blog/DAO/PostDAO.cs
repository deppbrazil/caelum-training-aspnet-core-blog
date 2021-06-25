using Blog.Infra;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DAO
{
    public class PostDAO
    {
        // list the posts
        public IList<Post> List()

        {
            using (BlogContext context = new BlogContext())
            {
                var list = context.Posts.ToList();                
                return list;
            }
        }

        public void AddPost(Post post)
        {
            using (BlogContext context = new BlogContext())
            {
                context.Posts.Add(post);
                context.SaveChanges();
            }
        }

        public IList<Post> FilterForCategory(string category)
        {
            using (BlogContext context = new BlogContext())
            {
                var list = context.Posts.Where(p => p.Category.Contains(category)).ToList();
                return list;
            }
        }

        public void DeletePost(int id)
        {
            using (BlogContext context = new BlogContext())
            {
                // Recovery post
                var post = context.Posts.Find(id);
                context.Posts.Remove(post);
                context.SaveChanges();
            }
        }

        public Post FindForId(int id)
        {
            using (BlogContext context = new BlogContext())
            {
                var post = context.Posts.Find(id);
                return post;
            }
        }

        public void UpdatePost(Post post)
        {
            using (BlogContext context = new BlogContext())
            {
                // Update post
                context.Posts.Update(post);
                context.SaveChanges();
            }
        }
    }
}
