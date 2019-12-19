using LibraryManagement.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Interfaces
{
    /// <summary>
    /// Define the methods which need to be implemented in the repository class
    /// </summary>
    public interface ILibraryRepository
    {
        /// <summary>
        /// Get all the books
        /// </summary>
        /// <returns>Book Object</returns>
        Task<List<Book>> Get();

        /// <summary>
        /// Get book
        /// </summary>
        /// <returns>Book Object</returns>
        Task<Book> Get(int id);

        /// <summary>
        /// Search books by author
        /// </summary>
        /// <param name="searchParam"></param>
        /// <returns>Book List</returns>
        Task<List<Book>> SearchByAuthor(string searchParam);

        /// <summary>
        /// Search books by title
        /// </summary>
        /// <param name="searchParam"></param>
        /// <returns>Book List</returns>
        Task<List<Book>> SearchByTitle(string searchParam);

        /// <summary>
        /// Search books by publisher
        /// </summary>
        /// <param name="searchParam"></param>
        /// <returns>Book List</returns>
        Task<List<Book>> SearchByPublisher(string searchParam);

        /// <summary>
        /// Save book details
        /// </summary>
        /// <param name="book"></param>
        /// <returns>Boolean</returns>
        Task<bool> Save(Book book);

        /// <summary>
        /// Update book details
        /// </summary>
        /// <param name="book"></param>
        /// <returns>Boolean</returns>
        Task<bool> Update(Book book);
    }
}
