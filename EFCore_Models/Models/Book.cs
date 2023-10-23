using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_Models.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public BookDetail BookDetail { get; set; }
        [ForeignKey("Publisher")]
        public int PublisherId {  get; set; }
        public Publisher Publisher { get; set; }
        public List<AuthorBook> AuthorBookMap { get; set; }
    }
}