using System;

namespace LibraryManagement.Data.Models
{
    /// <summary>
    /// Represents a model for Category
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or sets the category id
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the category name
        /// </summary>
        public string CategoryName { get; set; }

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
