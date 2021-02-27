using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Clinique.Dtos
{
    public interface IListeAnalyseAppService :
      ICrudAppService< //Defines CRUD methods
          ListeAnalyseDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateListeAnalyseDto> //Used to create/update a book
    {

    }
}