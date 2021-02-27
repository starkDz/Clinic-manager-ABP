using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Clinique.Dtos
{
    public interface IEnumerationAppService :
      ICrudAppService< //Defines CRUD methods
          EnumerationDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateEnumerationDto> //Used to create/update a book
    {

    }
}