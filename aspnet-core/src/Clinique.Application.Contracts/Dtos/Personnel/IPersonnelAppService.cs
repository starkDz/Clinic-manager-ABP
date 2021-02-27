using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Clinique.Dtos
{
    public interface IPersonnelAppService :
      ICrudAppService< //Defines CRUD methods
        PersonnelDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdatePersonnelDto> //Used to create/update a book
    {

    }
}