using lap2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lap2.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult ListBook()
        {
            var books = new List<string>();
            books.Add("Book 1");
            books.Add("Book 2");
            books.Add("Book 3");
            ViewBag.Books = books;
            return View();
        }
        public ActionResult ListBookModel()
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5", "Author book 1", "/Content/image/book1.jpg"));
            books.Add(new Book(2, "HTML5&CSS", "Author book 2", "/Content/image/book2.jpg"));
            books.Add(new Book(3, "MVC5", "Author book 3", "/Content/image/book3.jpg"));
            return View(books);
        }
        public ActionResult EditBook(int id, string Title, string Author, string Cover)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5", "Author book 1", "/Content/image/book1.jpg"));
            books.Add(new Book(2, "HTML5&CSS", "Author book 2", "/Content/image/book2.jpg"));
            books.Add(new Book(3, "MVC5", "Author book 3", "/Content/image/book3.jpg"));
            Book book = new Book();
            foreach (Book b in books)
            {
                if (b.ID == id)
                {
                    book = b;
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
            //if (id == null)
            //{
            //    return HttpNotFound();
            //}
            //foreach (Book b in books)
            //{
            //    if (b.ID == id)
            //    {
            //        b.Title = Title;
            //        b.Author = Author;
            //        b.Cover = Cover;
            //        break;
            //    }
            //}
            //if (id == null)
            //{
            //    return HttpNotFound();
            //}
            //return View("ListBookModel", books);
        }
        public ActionResult CreateBook()
        {
            return View();
        }
        public ActionResult Contact([Bind(Include = "ID,Title,Author,Cover")] Book book)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5", "Author book 1", "/Content/image/book1.jpg"));
            books.Add(new Book(2, "HTML5&CSS", "Author book 2", "/Content/image/book2.jpg"));
            books.Add(new Book(3, "MVC5", "Author book 3", "/Content/image/book3.jpg"));
            try
            {
                if (ModelState.IsValid)
                {
                    books.Add(book);
                }
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("", "Error Save Data");
            }
            return View("ListBookModel", books);
        }
    } 
}
    
