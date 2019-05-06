using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using SmartLibraries.Authorization.Users;
using SmartLibraries.Books;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartLibraries.BorrowerTickets
{
    [Table("BorrowerTickets")]
    public class BorrowerTicket : FullAuditedEntity<long>, IMustHaveTenant
    {
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        //Foreign Keys
        public int BookId { get; set; }

        public Book Book { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public int TenantId { get; set; }
    }
}