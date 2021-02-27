using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Clinique
{
    public partial class DetailAntecedent: AuditedAggregateRoot<Guid>
    { 
        public Guid IdPatient { get; set; }
        public Guid IdAntecedent { get; set; }

        public virtual AntecedentMedicale IdAntecedentNavigation { get; set; }
        public virtual Patient IdPatientNavigation { get; set; }
    }
}
