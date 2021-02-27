using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Clinique.Dtos
{
    public interface IParametreCabinetAppService :
      ICrudAppService< //Defines CRUD methods
          ParametreCabinetDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateParametreCabinetDto> //Used to create/update a book
    {

    }
}