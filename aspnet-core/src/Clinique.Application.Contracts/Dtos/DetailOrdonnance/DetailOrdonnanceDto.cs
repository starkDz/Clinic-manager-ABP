using System;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class DetailOrdonnanceDto : AuditedEntityDto<Guid>
    {
        public Guid IdOrdonnance { get; set; }
        public Guid IdMedicament { get; set; }
        public long? Quantite { get; set; }
        public string DescriptionFr { get; set; }
        public string DescriptionAr { get; set; }
        public virtual MedicamentDto IdMedicamentNavigation { get; set; }
        public virtual OrdonnanceDto IdOrdonnanceNavigation { get; set; }

    }
}