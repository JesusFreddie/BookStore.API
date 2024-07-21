using BookStore.Core.Models;
using BookStore.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Services
{
    public class BooksService : IBooksService
    {
        private readonly IBooksRepositories _booksRepositories;

        public BooksService(IBooksRepositories booksRepositories)
        {
            _booksRepositories = booksRepositories;
        }
        public async Task<List<Book>> GetAllBooks()
        {
            return await _booksRepositories.Get();
        }
        public async Task<Guid> CreateBook(Book book)
        {
            return await _booksRepositories.Create(book);
        }
        public async Task<Guid> UpdateBook(Guid id, string title, string description, uint price)
        {
            return await _booksRepositories.Update(id, title, description, price);
        }
        public async Task<Guid> DeleteBook(Guid id)
        {
            return await _booksRepositories.Delete(id);
        }
    }
}
