using BookStoreSample.Data;
using BookStoreSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSample.Repos
{
    public class BookRepo
    {
        private readonly ApplicationDbContext _dbContext;
        public BookRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Book> GetAll()
        {
            return _dbContext.Books.ToList();
        }

        public Book GetById(int id)
        {
            return _dbContext.Books.FirstOrDefault(x => x.Id == id); // && x.IsDeleted == false
        }

        public List<Book> SearchBooks(string title, string author)
        {
            return _dbContext.Books.Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }

        public Book Edit(Book book, int id)
        {
            var existingBook = _dbContext.Books.FirstOrDefault(x => x.Id == id); // && x.IsDeleted == false
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.PuplishYear = book.PuplishYear;
                existingBook.IsDeleted = book.IsDeleted;
                _dbContext.SaveChanges();

            }
            return existingBook;
        }

    }
}
