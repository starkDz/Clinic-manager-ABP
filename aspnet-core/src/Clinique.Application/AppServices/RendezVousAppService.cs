using System;
using Clinique.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Clinique
{
    public class RendezVousAppService :
        CrudAppService<
            RendezVou, //The Book entity
            RendezVousDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateRendezVousDto>, //Used to create/update a book
        IRendezVousAppService //implement the IBookAppService
    {
        public RendezVousAppService(IRepository<RendezVou, Guid> repository)
            : base(repository)
        { 

        }
    }
    
}
