using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SmartLibraries.Books.Dto;
using SmartLibraries.BorrowerTickets;
using System;
using System.Collections.Generic;

namespace SmartLibraries.BookTicket.Dto
{
    [AutoMap(typeof(BorrowerTicket))]
    public class BorrowerTicketDto: EntityDto<long>
    {
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public long UserId { get; set; }
        public List<BookDto> Books { get; set; }
    }
}