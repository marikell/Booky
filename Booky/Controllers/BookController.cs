using Booky.Core;
using Booky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Booky.Controllers
{
    public class BookController : Controller
    {
        private BookCore Core;
        public BookController()
        {
            Core = new BookCore();
        }
        public ActionResult Index()
        {
            List<Book> books = Core.ListAll().OrderBy(o => o.Title).ToList();
            ViewBag.Books = books;
            ViewBag.Filters = new List<SelectListItem> { new SelectListItem { Text = "Autor", Value = "Author" } };
            return View();
        }

       

        public ActionResult Edit(int id)
        {
            Book book = Core.Get(id);

            return View(book);
            
        }

        // GET: Book
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            Core.Delete(id);
            return new HttpStatusCodeResult(HttpStatusCode.OK);

        }

        [HttpPost]
        public ActionResult CreateBook(Book book)
        {
            Core.Add(book);
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        [HttpPost]
        public ActionResult EditBook(Book book)
        {
            Core.Edit(book);
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}