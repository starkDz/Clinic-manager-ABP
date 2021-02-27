using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Clinique.Dtos
{
    public interface IWilayaAppService :
      ICrudAppService< //Defines CRUD methods
        WilayaDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateWilayaDto> //Used to create/update a book
    {

    }
}