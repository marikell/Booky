using Booky.Data;
using Booky.Models;
using System.Collections.Generic;
using System.Linq;

namespace Booky.Core
{
    public class BookCore : BaseCore<Book>
    {       
        public BookCore(BookRepository bookRepository): base(bookRepository)
        {            
        }

        public BookCore()
        {
            Repository = new BookRepository();
        }

        public void Delete(int id)
        {
            Repository.Delete(o=> o.IdBook == id);
        }

        public Book Get(int id)
        {
           return Repository.Get(o => o.IdBook == id).FirstOrDefault();
        }
    }
}
