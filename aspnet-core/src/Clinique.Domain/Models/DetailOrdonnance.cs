using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Clinique
{
    public partial class DetailOrdonnance: AuditedAggregateRoot<Guid>
    { 
        public Guid IdOrdonnance { get; set; }
        public Guid IdMedicament { get; set; }
        public long? Quantite { get; set; }
        public string DescriptionFr { get; set; }
        public string DescriptionAr { get; set; }

        public virtual Medicament IdMedicamentNavigation { get; set; }
        public virtual Ordonnance IdOrdonnanceNavigation { get; set; }
    }
}
