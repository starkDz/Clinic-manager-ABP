using System;
using Clinique.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Clinique
{
    public class PatientAppService :
        CrudAppService<
            Patient, //The Book entity
            PatientDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdatePatientDto>, //Used to create/update a book
        IPatientAppService //implement the IBookAppService
    {
        public PatientAppService(IRepository<Patient, Guid> repository)
            : base(repository)
        { 

        }
    }
    
}
