using Cesi.IntroCS.CoreDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Cesi.IntroCS.CoreDataAccess
{
    public class BlogDAL : IDAL<Blog>
    {
        public List<Blog> Find(Expression<Func<Blog, bool>> findExpression)
        {
            using (var context = new BloggingContext())
            {
                return context.Blogs.Where(findExpression).ToList();
            }
        }

        public List<Blog> GetAll()
        {
            using (var context = new BloggingContext())
            {
                return context.Blogs.ToList();
            }
        }

        public Blog GetById(int id)
        {
            using (var context = new BloggingContext())
            {
                var Blog = context.Blogs.SingleOrDefault(p => p.Id == id);
                return Blog;
            }
        }

        public void Add(Blog Blog)
        {
            using (var context = new BloggingContext())
            {
                context.Blogs.Add(Blog);
                context.SaveChanges();
            }
        }

        public void Update(Blog Blog)
        {
            using (var context = new BloggingContext())
            {
                context.Blogs.Update(Blog);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new BloggingContext())
            {
                var Blog = context.Blogs.SingleOrDefault(p => p.Id == id);
                context.Blogs.Remove(Blog);
                context.SaveChanges();
            }
        }
    }
}
