using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace missions413.Models
{
    [Table("Books")]
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public string? Isbn { get; set; }
        public string? Classification { get; set; }
        public string? Category { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }
    }
}