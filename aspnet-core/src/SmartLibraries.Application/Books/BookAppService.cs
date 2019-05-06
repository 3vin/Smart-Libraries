using Abp.AppFactory.Interfaces;
using Abp.Domain.Repositories;
using SmartLibraries.Books.Dto;

namespace SmartLibraries.Books
{
    public class BookAppService : SmartLibrariesAsyncCrudAppServiceBase<Book, BookDto, long>
    {
        public BookAppService
            (
                IRepository<Book, long> repository,
                ISyncHub syncHub
            ) : base(repository, syncHub)
        {
        }
    }
}