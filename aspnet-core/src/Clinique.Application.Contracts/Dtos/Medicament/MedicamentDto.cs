using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class MedicamentDto : AuditedEntityDto<Guid>
    {
        public MedicamentDto()
        {
            DetailOrdonnances = new HashSet<DetailOrdonnanceDto>();
        }

        public string DesignationFr { get; set; }
        public string DesignationAr { get; set; }
        public Guid? IdTypeMedicament { get; set; }
        public string Dci { get; set; }
        public string Forme { get; set; }
        public string Condition { get; set; }
        public long? Dosage { get; set; }

        public virtual EnumerationDto IdTypeMedicamentNavigation { get; set; }
        public virtual ICollection<DetailOrdonnanceDto> DetailOrdonnances { get; set; }

    }
}