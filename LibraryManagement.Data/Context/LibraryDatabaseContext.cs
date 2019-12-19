using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data.Context
{
    public class LibraryDatabaseContext : DbContext
    {
        public LibraryDatabaseContext()
        {
        }

        public LibraryDatabaseContext(DbContextOptions<LibraryDatabaseContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Do nothing with this context
        }
    }
}
