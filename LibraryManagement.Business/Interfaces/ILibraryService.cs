using LibraryManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryManagement.Business.Interfaces
{
    /// <summary>
    /// Define the methods which needs to be implemented in the LibraryService class
    /// </summary>
    public interface ILibraryService
    {
        /// <summary>
        /// Get all the books
        /// </summary>
        /// <returns>Book Object</returns>
        Task<List<Books>> Get();

        /// <summary>
        /// Get book
        /// </summary>
        /// <returns>Book Object</returns>
        Task<Books> Get(int id);

        /// <summary>
        /// Search books by author
        /// </summary>
        /// <param name="searchParam"></param>
        /// <returns>Book List</returns>
        Task<List<Books>> SearchBooks(string searchParam);

        /// <summary>
        /// Save book details
        /// </summary>
        /// <param name="book"></param>
        /// <returns>Boolean</returns>
        Task<bool> Save(Books book);

        /// <summary>
        /// Update book details
        /// </summary>
        /// <param name="book"></param>
        /// <returns>Boolean</returns>
        Task<bool> Update(Books book);
    }
}
