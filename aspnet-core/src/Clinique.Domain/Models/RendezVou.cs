using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Clinique 
{
    public partial class RendezVou: AuditedAggregateRoot<Guid>
    { 
        public DateTime DateRendezVous { get; set; }
        public Guid IdPatient { get; set; }
        public Guid IdMedecin { get; set; }
        public bool? EstValide { get; set; }
        public string HeureRendezVous { get; set; }

        public virtual Personnel IdMedecinNavigation { get; set; }
        public virtual Patient IdPatientNavigation { get; set; }
    }
}
