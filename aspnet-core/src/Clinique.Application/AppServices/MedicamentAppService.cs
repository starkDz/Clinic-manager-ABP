using System;
using Clinique.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Clinique
{
    public class MedicamentAppService :
        CrudAppService<
            Medicament, //The Book entity
            MedicamentDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateMedicamentDto>, //Used to create/update a book
        IMedicamentAppService //implement the IBookAppService
    {
        public MedicamentAppService(IRepository<Medicament, Guid> repository)
            : base(repository)
        { 

        }
    }
    
}
