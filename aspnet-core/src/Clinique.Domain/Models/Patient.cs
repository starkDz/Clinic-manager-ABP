using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Clinique 
{
    public partial class Patient: AuditedAggregateRoot<Guid>
    {
        public Patient()
        {
            Consultations = new HashSet<Consultation>();
            DetailAntecedents = new HashSet<DetailAntecedent>();
            Ordonnances = new HashSet<Ordonnance>();
            RendezVous = new HashSet<RendezVou>();
        } 
        public string NomFr { get; set; }
        public string PrenomFr { get; set; }
        public string NomAr { get; set; }
        public string PrenomAr { get; set; }
        public long? Age { get; set; }
        public DateTime DateNaissance { get; set; }
        public string CodePersonnel { get; set; }
        public string NumeroCcp { get; set; }
        public string NumeroCn { get; set; }
        public string NumeroCa { get; set; }
        public string Addresse { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string DescriptionFr { get; set; }
        public string DescriptionAr { get; set; }
        public string SituationFamilliale { get; set; }
        public string Sexe { get; set; }
        public string Groupage { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Consultation> Consultations { get; set; }
        public virtual ICollection<DetailAntecedent> DetailAntecedents { get; set; }
        public virtual ICollection<Ordonnance> Ordonnances { get; set; }
        public virtual ICollection<RendezVou> RendezVous { get; set; }
    }
}
