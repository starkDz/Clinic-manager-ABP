using System;
using Clinique.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Clinique
{
    public class PersonnelAppService :
        CrudAppService<
            Personnel, //The Book entity
            PersonnelDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdatePersonnelDto>, //Used to create/update a book
        IPersonnelAppService //implement the IBookAppService
    {
        public PersonnelAppService(IRepository<Personnel, Guid> repository)
            : base(repository)
        { 

        }
    }
    
}
