using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class WilayaDto : AuditedEntityDto<Guid>
    {
        public WilayaDto()
        {
            ParametreCabinets = new HashSet<ParametreCabinetDto>();
        }

        public string DesignationFr { get; set; }
        public string DesignationAr { get; set; }
        public Guid IdCountry { get; set; }
        public string CodeWilaya { get; set; }

        public virtual CountryDto IdCountryNavigation { get; set; }
        public virtual ICollection<ParametreCabinetDto> ParametreCabinets { get; set; }

    }
}