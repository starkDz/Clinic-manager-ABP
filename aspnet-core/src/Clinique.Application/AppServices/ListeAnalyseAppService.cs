using System;
using Clinique.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Clinique
{
    public class ListeAnalyseAppService :
        CrudAppService<
            ListeAnalyse, //The Book entity
            ListeAnalyseDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateListeAnalyseDto>, //Used to create/update a book
        IListeAnalyseAppService //implement the IBookAppService
    {
        public ListeAnalyseAppService(IRepository<ListeAnalyse, Guid> repository)
            : base(repository)
        { 

        }
    }
    
}
