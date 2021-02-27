using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class CountryDto : AuditedEntityDto<Guid>
    {
        public CountryDto()
        {
            Wilayas = new HashSet<WilayaDto>();
        }

        public string DesignationFr { get; set; }
        public string DesignationAr { get; set; }

        public virtual ICollection<WilayaDto> Wilayas { get; set; }
        
    }
}