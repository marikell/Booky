using System;
using System.Collections.Generic;
using System.Linq;

namespace Booky.Interfaces
{
    public interface IBaseRepository<T> where T:class
    {
        void Add(T entity);
        void Delete(Func<T, bool> predicate);
        void Edit(T entity);
        IQueryable<T> Get(Func<T, bool> predicate);
        void Save();
        List<T> GetAll();
        
    }
}
