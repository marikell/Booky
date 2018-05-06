using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Booky.Interfaces;

namespace Booky.Data
{
    public class BaseRepository<T> : IBaseRepository<T>, IDisposable where T : class
    {
        private BookyContext context;
        public BaseRepository()
        {
            context = new BookyContext();
        }
        public BaseRepository(BookyContext context)
        {
            this.context = context;
        }
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            Save();
        }

        public void Delete(Func<T,bool> predicate)
        {
            context.Set<T>().Where(predicate).ToList().ForEach(o => context.Set<T>().Remove(o));
            Save();
        }

        public void Edit(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            Save();
        }

        public ICollection<T> Get(Func<T,bool> predicate)
        {
            return context.Set<T>().Where(predicate).ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
