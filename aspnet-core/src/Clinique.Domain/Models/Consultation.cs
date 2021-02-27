using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Clinique
{
    public partial class Consultation: AuditedAggregateRoot<Guid>
    {
        public Consultation()
        {
            ListeAnalyses = new HashSet<ListeAnalyse>();
            ListeRadios = new HashSet<ListeRadio>();
            Ordonnances = new HashSet<Ordonnance>();
        }
 
        public Guid IdPatient { get; set; }
        public Guid IdMedecin { get; set; }
        public DateTime DateConsultation { get; set; }
        public string HeureConsultation { get; set; }
        public bool? AvecRadio { get; set; }
        public bool? AvecAnalyse { get; set; }
        public bool? AvecOrdonnace { get; set; }
        public long? Poids { get; set; }
        public long? Taille { get; set; }
        public long? FrequenceCardiaque { get; set; }
        public long? Temperature { get; set; }
        public double? Glycemie { get; set; }
        public string Observation { get; set; }
        public long? Prix { get; set; }

        public virtual Personnel IdMedecinNavigation { get; set; }
        public virtual Patient IdPatientNavigation { get; set; }
        public virtual ICollection<ListeAnalyse> ListeAnalyses { get; set; }
        public virtual ICollection<ListeRadio> ListeRadios { get; set; }
        public virtual ICollection<Ordonnance> Ordonnances { get; set; }
    }
}
