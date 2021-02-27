using System;
using Clinique.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Clinique
{
    public class DetailAntecedentAppService :
        CrudAppService<
            DetailAntecedent, //The Book entity
            DetailAntecedentDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateDetailAntecedentDto>, //Used to create/update a book
        IDetailAntecedentAppService //implement the IBookAppService
    {
        public DetailAntecedentAppService(IRepository<DetailAntecedent, Guid> repository)
            : base(repository)
        { 

        }
    }
    
}
