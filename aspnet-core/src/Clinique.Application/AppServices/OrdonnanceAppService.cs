using System;
using Clinique.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Clinique
{
    public class OrdonnanceAppService :
        CrudAppService<
            Ordonnance, //The Book entity
            OrdonnanceDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateOrdonnanceDto>, //Used to create/update a book
        IOrdonnanceAppService //implement the IBookAppService
    {
        public OrdonnanceAppService(IRepository<Ordonnance, Guid> repository)
            : base(repository)
        { 

        }
    }
    
}
