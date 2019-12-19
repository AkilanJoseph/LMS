using LibraryManagement.Data.Context;
using LibraryManagement.Data.Interfaces;
using LibraryManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Repository
{
    /// <summary>
    /// Implement ILibraryService interface methods
    /// </summary>
    public class LibraryRepository : ILibraryRepository
    {
        #region "Private Variables"
        private readonly LibraryDatabaseContext _context;
        #endregion

        #region "Public Constructor"
        public LibraryRepository(LibraryDatabaseContext context)
        {
            _context = context;
        }

        public LibraryRepository()
        {
        }
        #endregion

        #region "Public Methods"
        /// <summary>
        /// Get all the books
        /// </summary>
        /// <returns>Book Object</returns>
        public async Task<List<Book>> Get()
        {
            return await Task.FromResult(_context.Books.ToList());
        }

        /// <summary>
        /// Get book
        /// </summary>
        /// <returns>Book Object</returns>
        public async Task<Book> Get(int id)
        {
            return await Task.FromResult(_context.Books.FirstOrDefault(x => x.BookId == id));
        }

        /// <summary>
        /// Search books by author
        /// </summary>
        /// <param name="searchParam"></param>
        /// <returns>Book List</returns>
        public async Task<List<Book>> SearchByAuthor(string searchParam)
        {
            return await Task.FromResult(_context.Books.Where(x => x.AuthorName.ToLower().Contains(searchParam)).ToList());
        }

        /// <summary>
        /// Search books by title
        /// </summary>
        /// <param name="searchParam"></param>
        /// <returns>Book List</returns>
        public async Task<List<Book>> SearchByTitle(string searchParam)
        {
            return await Task.FromResult(_context.Books.Where(x => x.BookName.ToLower().Contains(searchParam)).ToList());
        }

        /// <summary>
        /// Search books by publisher
        /// </summary>
        /// <param name="searchParam"></param>
        /// <returns>Book List</returns>
        public async Task<List<Book>> SearchByPublisher(string searchParam)
        {
            return await Task.FromResult(_context.Books.Where(x => x.Publisher.ToLower().Contains(searchParam)).ToList());
        }

        /// <summary>
        /// Save book details
        /// </summary>
        /// <param name="book"></param>
        /// <returns>Boolean</returns>
        public async Task<bool> Save(Book book)
        {
            try
            {
                await Task.FromResult(_context.Add(book));
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        /// <summary>
        /// Update book details
        /// </summary>
        /// <param name="book"></param>
        /// <returns>Boolean</returns>
        public async Task<bool> Update(Book book)
        {
            try
            {
                var existBookObject = await Task.FromResult(_context.Books.FirstOrDefault(x => x.BookId == book.BookId));
                if (existBookObject != null)
                {
                    existBookObject.AuthorName = book.AuthorName;
                    existBookObject.BookName = book.BookName;
                    existBookObject.Category = book.Category;
                    existBookObject.Edition = book.Edition;
                    existBookObject.Price = book.Price;
                    existBookObject.Publisher = book.Publisher;
                    existBookObject.ModifiedBy = book.ModifiedBy;
                    existBookObject.ModifiedDate = book.ModifiedDate;
                    _context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
            }
            return false;
        }
        #endregion
    }
}
