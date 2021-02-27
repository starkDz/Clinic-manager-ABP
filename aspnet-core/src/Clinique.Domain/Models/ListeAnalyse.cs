using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Clinique
{
    public partial class ListeAnalyse: AuditedAggregateRoot<Guid>
    { 
        public Guid IdConsultation { get; set; }
        public Guid IdAnalyse { get; set; }

        public virtual Enumeration IdAnalyseNavigation { get; set; }
        public virtual Consultation IdConsultationNavigation { get; set; }
    }
}
