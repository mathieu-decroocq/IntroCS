using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Cesi.IntroCS.CoreDataAccess
{
    public interface IDAL<T>
    {
        List<T> GetAll();

        T GetById(int id);

        List<T> Find(Expression<Func<T, bool>> findExpression);

        void Add(T entity);

        void Update(T entity);

        void Delete(int id);
    }
}
