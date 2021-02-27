using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Clinique
{
    public partial class AntecedentMedicale: AuditedAggregateRoot<Guid>
    {
        public AntecedentMedicale()
        {
            DetailAntecedents = new HashSet<DetailAntecedent>();
        }
 
        public string DesignationFr { get; set; }
        public string DesignationAr { get; set; }

        public virtual ICollection<DetailAntecedent> DetailAntecedents { get; set; }
    }
}
