using System;
using Clinique.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Clinique
{
    public class ListeRadioAppService :
        CrudAppService<
            ListeRadio, //The Book entity
            ListeRadioDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateListeRadioDto>, //Used to create/update a book
        IListeRadioAppService //implement the IBookAppService
    {
        public ListeRadioAppService(IRepository<ListeRadio, Guid> repository)
            : base(repository)
        { 

        }
    }
    
}
