using BookStoreSample.Models;
using BookStoreSample.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSample.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepo _bookRepo;

        public BookController(BookRepo bookRepo)
        {
            _bookRepo = bookRepo;
        }

        public IActionResult GetAllBooks()
        {
            var books = _bookRepo.GetAll();
            return View(books);
        }

        public Book GetBook(int id)
        {
            return _bookRepo.GetById(id);
        }

        public Book Edit(int id)
        {
            return _bookRepo.GetById(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public Book Edit(Book model, int id)
        {
            return _bookRepo.Edit(model, id);
        }


        public List<Book> SearchBooks(string name, string author)
        {
            return _bookRepo.SearchBooks(name, author);
        }
    }
}
