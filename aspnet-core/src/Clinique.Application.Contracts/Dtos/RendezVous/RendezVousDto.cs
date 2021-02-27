using System;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class RendezVousDto : AuditedEntityDto<Guid>
    {
        public DateTime DateRendezVous { get; set; }
        public Guid IdPatient { get; set; }
        public Guid IdMedecin { get; set; }
        public bool? EstValide { get; set; }
        public string HeureRendezVous { get; set; }

        public virtual PersonnelDto IdMedecinNavigation { get; set; }
        public virtual PatientDto IdPatientNavigation { get; set; }


    }
}