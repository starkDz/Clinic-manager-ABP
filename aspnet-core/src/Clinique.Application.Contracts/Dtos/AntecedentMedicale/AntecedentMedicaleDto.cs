using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class AntecedentMedicaleDto : AuditedEntityDto<Guid>
    {
        public string DesignationFr { get; set; }
        public string DesignationAr { get; set; }

        public virtual ICollection<DetailAntecedentDto> DetailAntecedents { get; set; }

    }
}