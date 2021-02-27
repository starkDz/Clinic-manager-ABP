using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Clinique.Dtos
{
    public interface IAntecedentMedicaleAppService :
        ICrudAppService< //Defines CRUD methods
            AntecedentMedicaleDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateAntecedentMedicaleDto> //Used to create/update a book
    {
        
    }
}