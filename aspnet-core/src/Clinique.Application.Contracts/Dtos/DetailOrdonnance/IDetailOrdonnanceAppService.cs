using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Clinique.Dtos
{
    public interface IDetailOrdonnanceAppService :
      ICrudAppService< //Defines CRUD methods
          DetailOrdonnanceDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateDetailOrdonnanceDto> //Used to create/update a book
    {

    }
}