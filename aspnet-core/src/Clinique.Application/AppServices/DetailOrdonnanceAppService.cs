using System;
using Clinique.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Clinique
{
    public class DetailOrdonnanceAppService :
        CrudAppService<
            DetailOrdonnance, //The Book entity
            DetailOrdonnanceDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateDetailOrdonnanceDto>, //Used to create/update a book
        IDetailOrdonnanceAppService //implement the IBookAppService
    {
        public DetailOrdonnanceAppService(IRepository<DetailOrdonnance, Guid> repository)
            : base(repository)
        { 

        }
    }
    
}
