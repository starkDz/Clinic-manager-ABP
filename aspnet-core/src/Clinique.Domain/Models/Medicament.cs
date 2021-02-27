using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Clinique
{
    public partial class Medicament: AuditedAggregateRoot<Guid>
    {
        public Medicament()
        {
            DetailOrdonnances = new HashSet<DetailOrdonnance>();
        }
 
        public string DesignationFr { get; set; }
        public string DesignationAr { get; set; }
        public Guid? IdTypeMedicament { get; set; }
        public string Dci { get; set; }
        public string Forme { get; set; }
        public string Condition { get; set; }
        public long? Dosage { get; set; }

        public virtual Enumeration IdTypeMedicamentNavigation { get; set; }
        public virtual ICollection<DetailOrdonnance> DetailOrdonnances { get; set; }
    }
}
