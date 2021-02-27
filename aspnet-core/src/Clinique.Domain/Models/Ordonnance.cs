using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Clinique 
{
    public partial class Ordonnance: AuditedAggregateRoot<Guid>
    {
        public Ordonnance()
        {
            DetailOrdonnances = new HashSet<DetailOrdonnance>();
        }
 
        public Guid IdPatient { get; set; }
        public Guid IdMedecin { get; set; }
        public Guid IdConsultation { get; set; }

        public virtual Consultation IdConsultationNavigation { get; set; }
        public virtual Personnel IdMedecinNavigation { get; set; }
        public virtual Patient IdPatientNavigation { get; set; }
        public virtual ICollection<DetailOrdonnance> DetailOrdonnances { get; set; }
    }
}
