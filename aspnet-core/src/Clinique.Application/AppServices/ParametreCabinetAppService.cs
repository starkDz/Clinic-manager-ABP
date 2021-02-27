using System;
using Clinique.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Clinique
{
    public class ParametreCabinetAppService :
        CrudAppService<
            ParametreCabinet, //The Book entity
            ParametreCabinetDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateParametreCabinetDto>, //Used to create/update a book
        IParametreCabinetAppService //implement the IBookAppService
    {
        public ParametreCabinetAppService(IRepository<ParametreCabinet, Guid> repository)
            : base(repository)
        { 

        }
    }
    
}
