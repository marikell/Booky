using Booky.Data;
using Booky.Models;
using System;
using System.Collections.Generic;

namespace Booky.Core
{
    public class BaseCore<T>:IDisposable where T:class
    {
        protected BaseRepository<T> Repository;

        public BaseCore(BaseRepository<T> repository)
        {
            this.Repository = repository;
        }

        public BaseCore()
        {

        }

        public void Add(T entity)
        {
            Repository.Add(entity);
        }
      
        public List<T> ListAll()
        {
            return Repository.GetAll();
        }

        public void Dispose()
        {
            Repository.Dispose();
        }

        public void Edit(T entity)
        {
            Repository.Edit(entity);
        }
    }
}
