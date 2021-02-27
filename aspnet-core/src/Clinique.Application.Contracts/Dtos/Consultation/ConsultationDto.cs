using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class ConsultationDto : AuditedEntityDto<Guid>
    {
        public ConsultationDto()
        {
            ListeAnalyses = new HashSet<ListeAnalyseDto>();
            ListeRadios = new HashSet<ListeRadioDto>();
            Ordonnances = new HashSet<OrdonnanceDto>();
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

        public virtual PersonnelDto IdMedecinNavigation { get; set; }
        public virtual PatientDto IdPatientNavigation { get; set; }
        public virtual ICollection<ListeAnalyseDto> ListeAnalyses { get; set; }
        public virtual ICollection<ListeRadioDto> ListeRadios { get; set; }
        public virtual ICollection<OrdonnanceDto> Ordonnances { get; set; }

    }
}