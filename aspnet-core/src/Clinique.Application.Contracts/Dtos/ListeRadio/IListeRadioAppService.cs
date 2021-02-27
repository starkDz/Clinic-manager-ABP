using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Clinique.Dtos
{
    public interface IListeRadioAppService :
      ICrudAppService< //Defines CRUD methods
          ListeRadioDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateListeRadioDto> //Used to create/update a book
    {

    }
}