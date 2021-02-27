using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Clinique.Dtos
{
    public interface IMedicamentAppService :
      ICrudAppService< //Defines CRUD methods
          MedicamentDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateMedicamentDto> //Used to create/update a book
    {

    }
}