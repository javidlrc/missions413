using Microsoft.EntityFrameworkCore;

namespace missions413.Models
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options) : base(options) { }

        public DbSet<Books> Books { get; set; }
    }
}