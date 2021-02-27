using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Clinique.Dtos
{
    public interface IConsultationAppService :
        ICrudAppService< //Defines CRUD methods
            ConsultationDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateConsultationDto> //Used to create/update a book
    {
        
    }
}