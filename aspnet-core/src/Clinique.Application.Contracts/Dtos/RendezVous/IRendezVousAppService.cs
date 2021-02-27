using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Clinique.Dtos
{
    public interface IRendezVousAppService :
      ICrudAppService< //Defines CRUD methods
        RendezVousDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateRendezVousDto> //Used to create/update a book
    {

    }
}