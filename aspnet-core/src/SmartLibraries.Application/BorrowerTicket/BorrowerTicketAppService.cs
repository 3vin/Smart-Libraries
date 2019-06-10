using Abp.AppFactory.Interfaces;
using Abp.Domain.Repositories;
using SmartLibraries.BookTicket.Dto;
using SmartLibraries.BorrowerTickets;

namespace SmartLibraries.BookTicket
{
    public class BorrowerTicketAppService : SmartLibrariesAsyncCrudAppServiceBase<BorrowerTicket, BorrowerTicketDto, long>
    {
        public BorrowerTicketAppService(
            IRepository<BorrowerTicket, long> repository,
            ISyncHub syncHub
            ) : base(repository, syncHub)
        {
        }
    }
}