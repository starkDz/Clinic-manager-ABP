using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Clinique.Dtos
{
    public interface IPatientAppService :
      ICrudAppService< //Defines CRUD methods
          PatientDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdatePatientDto> //Used to create/update a book
    {

    }
}