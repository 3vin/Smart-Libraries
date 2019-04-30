using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartLibraries.Books
{
    [Table("Books")]
    public class Book : Entity
    {
        public string Author { get; set; }
        public long Barcode { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long ISBN { get; set; }
        public BookStatus Status { get; set; }
    }
}