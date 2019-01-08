using Cesi.IntroCS.CoreDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;

namespace Cesi.IntroCS.CoreDataAccess
{
    public class PostDAL : IDAL<Post>
    {
        public List<Post> Find(Expression<Func<Post, bool>> findExpression)
        {
            using (var context = new BloggingContext())
            {
                return context.Posts.Where(findExpression).ToList();
            }
        }

        public List<Post> GetAll()
        {
            using (var context = new BloggingContext())
            {
                return context.Posts.ToList();
            }
        }

        public Post GetById(int id)
        {
            using (var context = new BloggingContext())
            {
                var post = context.Posts.SingleOrDefault(p => p.Id == id);
                return post;
            }
        }

        public void Add(Post post)
        {
            using (var context = new BloggingContext())
            {
                context.Posts.Add(post);
                context.SaveChanges();
            }
        }

        public void Update(Post post)
        {
            using (var context = new BloggingContext())
            {
                context.Posts.Update(post);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new BloggingContext())
            {
                var post = context.Posts.SingleOrDefault(p => p.Id == id);
                context.Posts.Remove(post);
                context.SaveChanges();
            }
        }

        public void Dispose()
        {
        }
    }
}
