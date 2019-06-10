using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace SmartLibraries.Books.Dto
{
    [AutoMap(typeof(Book))]
    public class BookDto : EntityDto<long>
    {
        public string Author { get; set; }
        public long Barcode { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long ISBN { get; set; }
        public BookStatus Status { get; set; }
    }
}