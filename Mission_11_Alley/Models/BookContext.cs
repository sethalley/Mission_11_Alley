using Microsoft.EntityFrameworkCore;

namespace Mission_11_Alley.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

        public DbSet<Book>  Books { get; set; }
    }
}
