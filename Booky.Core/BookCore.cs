using Booky.Data;
using Booky.Models;

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

    }
}
