using LibraryManagement.Business.Interfaces;
using LibraryManagement.Data.Interfaces;
using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using LibraryManagement.Data.Models;

namespace LibraryManagement.Business.Implementation
{
    /// <summary>
    /// Implement ILibraryService interface methods
    /// </summary>
    public class LibraryService : ILibraryService
    {
        #region "Private Variables"
        private readonly ILibraryRepository _repository;
        private List<Books> _books = new List<Books>();
        #endregion

        #region "Public Constructor"
        public LibraryService(ILibraryRepository repository)
        {
            _repository = repository;
        }
        #endregion

        #region "Public Methods"
        /// <summary>
        /// Get all the books
        /// </summary>
        /// <returns>Book Object</returns>
        public async Task<List<Books>> Get()
        {
            GetBooks(await _repository.Get(), ref _books);
            return _books;
        }

        /// <summary>
        /// Get book
        /// </summary>
        /// <returns>Book Object</returns>
        public async Task<Books> Get(int id)
        {
            var result = await _repository.Get(id);
            if (result != null)
            {
                return new Books()
                {
                    AuthorName = result.AuthorName,
                    BookId = result.BookId,
                    BookName = result.BookName,
                    Category = result.Category,
                    Edition = result.Edition,
                    Price = result.Price,
                    Publisher = result.Publisher
                };
            }
            return null;
        }

        /// <summary>
        /// Search books by author
        /// </summary>
        /// <param name="searchParam"></param>
        /// <returns>Book List</returns>
        public async Task<List<Books>> SearchBooks(string searchParam)
        {
            GetBooks(await _repository.SearchByAuthor(searchParam), ref _books);
            GetBooks(await _repository.SearchByTitle(searchParam), ref _books);
            GetBooks(await _repository.SearchByPublisher(searchParam), ref _books);
            return _books;
        }

        /// <summary>
        /// Save book details
        /// </summary>
        /// <param name="book"></param>
        /// <returns>Boolean</returns>
        public async Task<bool> Save(Books book)
        {
            return await _repository.Save(new Book()
            {
                AuthorName = book.AuthorName,
                BookId = book.BookId,
                BookName = book.BookName,
                Category = book.Category,
                CreatedBy = "SYS-Created",
                CreatedDate = DateTime.Now,
                Edition = book.Edition,
                ModifiedBy = "SYS-Modified",
                ModifiedDate = DateTime.Now,
                Price = book.Price,
                Publisher = book.Publisher
            });
        }

        /// <summary>
        /// Update book details
        /// </summary>
        /// <param name="book"></param>
        /// <returns>Boolean</returns>
        public async Task<bool> Update(Books book)
        {
            return await _repository.Update(new Book()
            {
                AuthorName = book.AuthorName,
                BookId = book.BookId,
                BookName = book.BookName,
                Category = book.Category,
                Edition = book.Edition,
                ModifiedBy = "SYS-Modified",
                ModifiedDate = DateTime.Now,
                Price = book.Price,
                Publisher = book.Publisher
            });
        }
        #endregion

        #region "Private Methods"
        /// <summary>
        /// Get list of books
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        private void GetBooks(List<Book> result, ref List<Books> books)
        {
            if (result != null && result.Count > 0)
            {
                books.AddRange( result.Select(x => new Books()
                {
                    AuthorName = x.AuthorName,
                    BookId = x.BookId,
                    BookName = x.BookName,
                    Category = x.Category,
                    Edition = x.Edition,
                    Price = x.Price,
                    Publisher = x.Publisher
                }).ToList());
            }
        }
        #endregion
    }
}
