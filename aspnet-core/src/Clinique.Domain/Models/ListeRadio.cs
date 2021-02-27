using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Clinique
{
    public partial class ListeRadio: AuditedAggregateRoot<Guid>
    { 
        public Guid IdConsulatation { get; set; }
        public Guid IdRadio { get; set; }

        public virtual Consultation IdConsulatationNavigation { get; set; }
        public virtual Enumeration IdRadioNavigation { get; set; }
    }
}
