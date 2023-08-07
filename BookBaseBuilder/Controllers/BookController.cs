using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookBaseBuilder.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository repo;

        public BookController(IBookRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var books = repo.GetAllBooks();

            return View(books);
        }

        public IActionResult ViewBook(int id)
        {
            var book = repo.GetBook(id);

            return View(book);
        }

        public IActionResult UpdateBook(int id)
        {
            Book book = repo.GetBook(id);

            if (book == null)
            {
                return View("BookNotFound");
            }

            return View(book);
        }
        public IActionResult UpdateBookToDatabase(Book book)
        {
            repo.UpdateBook(book);

            return RedirectToAction("ViewBook", new { id = book.BookID });
        }

        public IActionResult InsertBook()
        {
            var novel = new Book();

            return View();
        }

        public IActionResult InsertBookToDatabase(Book bookToInsert)
        {
            repo.InsertBook(bookToInsert);

            return RedirectToAction("Index");
        }
    }
}

