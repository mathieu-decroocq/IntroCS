using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Cesi.IntroCS.CoreDataAccess
{
    public class GenericDal<T> : IDAL<T> where T : class 
    {
        private BloggingContext context;

        public GenericDal()
        {
            context = new BloggingContext();
        }
        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> Find(Expression<Func<T, bool>> findExpression)
        {
            return context.Set<T>().Where(findExpression).ToList();
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = context.Set<T>().Find(id);
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context?.Dispose();
        }
    }
}
