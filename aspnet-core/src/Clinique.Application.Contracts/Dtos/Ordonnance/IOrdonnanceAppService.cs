using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Clinique.Dtos
{
    public interface IOrdonnanceAppService :
      ICrudAppService< //Defines CRUD methods
          OrdonnanceDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateOrdonnanceDto> //Used to create/update a book
    {

    }
}