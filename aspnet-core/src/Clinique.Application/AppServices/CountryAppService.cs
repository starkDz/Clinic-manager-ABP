using System;
using Clinique.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Clinique
{
    public class CountryAppService :
        CrudAppService<
            Country, //The Book entity
            CountryDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateCountryDto>, //Used to create/update a book
        ICountryAppService //implement the IBookAppService
    {
        public CountryAppService(IRepository<Country, Guid> repository)
            : base(repository)
        { 

        }
    }
    
}
