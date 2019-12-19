namespace LibraryManagement.Models
{
    /// <summary>
    ///  Represents a model for Author
    /// </summary>
    public class Authors
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
    }
}
