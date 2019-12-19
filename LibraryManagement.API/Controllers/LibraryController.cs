using LibraryManagement.API.CustomFilters;
using LibraryManagement.Business.Interfaces;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LibraryManagement.API.Controllers
{
    [Route("api/library")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        #region " Private Variables"
        private readonly ILibraryService _libraryService;
        #endregion

        #region "Public Constructor"
        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }
        #endregion

        #region "API Methods"
        /// <summary>
        /// Get all the books
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _libraryService.Get();
                if (result != null && result.Count > 0)
                    return Ok(result);
                else
                    return NoContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
            return BadRequest();
        }

        /// <summary>
        /// Search book by author,publisher or title
        /// </summary>
        /// <returns></returns>
        [HttpGet("{keyword}/search")]
        public async Task<IActionResult> Search(string keyword)
        {
            try
            {
                var result = await _libraryService.SearchBooks(keyword.ToLower());
                if (result != null && result.Count > 0)
                    return Ok(result);
                else
                    return NoContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
            return BadRequest();
        }

        /// <summary>
        /// Save book
        /// </summary>
        /// <returns></returns>
        [ServiceFilter(typeof(CustomActionFilter))]
        [HttpPost]
        public async Task<IActionResult> Post(Books book)
        {
            try
            {
                var result = await _libraryService.Save(book);
                if (result)
                    return Ok("Saved Successfully");
                else
                    return BadRequest("Error in saving");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
            return BadRequest();
        }

        /// <summary>
        /// Save book
        /// </summary>
        /// <returns></returns>
        [ServiceFilter(typeof(CustomActionFilter))]
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Books book)
        {
            try
            {
                var result = await _libraryService.Update(book);
                if (result)
                    return Ok("Updated Successfully");
                else
                    return BadRequest("Error in saving");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
            return BadRequest();
        }
        #endregion
    }
}
