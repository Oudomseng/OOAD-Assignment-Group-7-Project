using System.ComponentModel.DataAnnotations;

namespace LMSWebAPIProject.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string AccessionNo { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public string Aurthor { get; set; } 
        public DateTime DatePublish { get; set; }
        public string Publisher { get; set; }
        public string Category { get; set; }
        public string DeweyDecimal { get; set; }
        public string BookType { get; set; }
    }
}
