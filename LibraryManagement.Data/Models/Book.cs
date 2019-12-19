﻿using System;

namespace LibraryManagement.Data.Models
{
    /// <summary>
    /// Represents a model for Book
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the book id
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Gets or sets the book name
        /// </summary>
        public string BookName { get; set; }

        /// <summary>
        /// Gets or sets the author id
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or sets the category id
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the edition
        /// </summary>
        public string Edition { get; set; }

        /// <summary>
        /// Gets or sets the book price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets the book publisher
        /// </summary>
        public string Publisher { get; set; }

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
