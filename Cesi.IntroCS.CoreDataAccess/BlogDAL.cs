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
        private readonly BloggingContext context;
        public BlogDAL(BloggingContext context)
        {
            this.context = context;
        }
        public List<Blog> Find(Expression<Func<Blog, bool>> findExpression)
        {
            return context.Blogs.Where(findExpression).ToList();
        }

        public List<Blog> GetAll()
        {
            return context.Blogs.ToList();
        }

        public Blog GetById(int id)
        {
            var blog = context.Blogs.SingleOrDefault(p => p.Id == id);
            return blog;
        }

        public void Add(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
        }

        public void Update(Blog blog)
        {
            context.Blogs.Update(blog);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var blog = context.Blogs.SingleOrDefault(p => p.Id == id);
            context.Blogs.Remove(blog);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context?.Dispose();
        }
    }
}
