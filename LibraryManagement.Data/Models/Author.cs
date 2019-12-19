using System;

namespace LibraryManagement.Data.Models
{
    /// <summary>
    ///  Represents a model for Author
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Gets or sets the author id
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the author name
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or sets about the author
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the created date
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets who created it
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the modified date
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets who modified it
        /// </summary>
        public string ModifiedBy { get; set; }
    }
}
