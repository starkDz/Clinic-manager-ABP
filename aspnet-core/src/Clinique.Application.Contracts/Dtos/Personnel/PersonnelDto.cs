using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class PersonnelDto : AuditedEntityDto<Guid>
    {
        public PersonnelDto()
        {
            Consultations = new HashSet<ConsultationDto>();
            Ordonnances = new HashSet<OrdonnanceDto>();
            RendezVous = new HashSet<RendezVousDto>();
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

        public virtual EnumerationDto IdCategorieNavigation { get; set; }
        public virtual EnumerationDto SpecialiteNavigation { get; set; }
        public virtual ICollection<ConsultationDto> Consultations { get; set; }
        public virtual ICollection<OrdonnanceDto> Ordonnances { get; set; }
        public virtual ICollection<RendezVousDto> RendezVous { get; set; }
   
        
    }
}