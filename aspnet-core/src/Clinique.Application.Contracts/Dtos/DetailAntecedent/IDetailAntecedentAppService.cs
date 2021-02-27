using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Clinique.Dtos
{
    public interface IDetailAntecedentAppService :
        ICrudAppService< //Defines CRUD methods
            DetailAntecedentDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateDetailAntecedentDto> //Used to create/update a book
    {

    }
}