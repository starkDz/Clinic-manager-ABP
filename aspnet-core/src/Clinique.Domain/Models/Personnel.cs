using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Clinique 
{
    public partial class Personnel: AuditedAggregateRoot<Guid>
    {
        public Personnel()
        {
            Consultations = new HashSet<Consultation>();
            Ordonnances = new HashSet<Ordonnance>();
            RendezVous = new HashSet<RendezVou>();
        }
 
        public Guid IdCategorie { get; set; }
        public string NomFr { get; set; }
        public string NomAr { get; set; }
        public string PrenomFr { get; set; }
        public string PrenomAr { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public Guid? Specialite { get; set; }
        public long? Age { get; set; }
        public string SituationFamilliale { get; set; }
        public string Sexe { get; set; }
        public string Groupage { get; set; }
        public string Email { get; set; }

        public virtual Enumeration IdCategorieNavigation { get; set; }
        public virtual Enumeration SpecialiteNavigation { get; set; }
        public virtual ICollection<Consultation> Consultations { get; set; }
        public virtual ICollection<Ordonnance> Ordonnances { get; set; }
        public virtual ICollection<RendezVou> RendezVous { get; set; }
    }
}
