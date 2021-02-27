using System;
using Clinique.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Clinique
{
    public class AntecedentMedicaleAppService :
        CrudAppService<
            AntecedentMedicale, //The Book entity
            AntecedentMedicaleDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateAntecedentMedicaleDto>, //Used to create/update a book
        IAntecedentMedicaleAppService //implement the IBookAppService
    {
        public AntecedentMedicaleAppService(IRepository<AntecedentMedicale, Guid> repository)
            : base(repository)
        { 

        }
    }
    
}
