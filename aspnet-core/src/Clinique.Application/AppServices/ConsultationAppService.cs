using System;
using Clinique.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Clinique
{
    public class ConsultationAppService :
        CrudAppService<
            Consultation, //The Book entity
            ConsultationDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateConsultationDto>, //Used to create/update a book
        IConsultationAppService //implement the IBookAppService
    {
        public ConsultationAppService(IRepository<Consultation, Guid> repository)
            : base(repository)
        { 

        }
    }
    
}
