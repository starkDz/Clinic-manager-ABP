using System;
using Clinique.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Clinique
{
    public class WilayaAppService :
        CrudAppService<
            Wilaya, //The Book entity
            WilayaDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateWilayaDto>, //Used to create/update a book
        IWilayaAppService //implement the IBookAppService
    {
        public WilayaAppService(IRepository<Wilaya, Guid> repository)
            : base(repository)
        { 

        }
    }
    
}
