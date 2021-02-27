using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class OrdonnanceDto : AuditedEntityDto<Guid>
    {
        public OrdonnanceDto()
        {
            DetailOrdonnances = new HashSet<DetailOrdonnanceDto>();
        }

        public Guid IdPatient { get; set; }
        public Guid IdMedecin { get; set; }
        public Guid IdConsultation { get; set; }

        public virtual ConsultationDto IdConsultationNavigation { get; set; }
        public virtual PersonnelDto IdMedecinNavigation { get; set; }
        public virtual PatientDto IdPatientNavigation { get; set; }
        public virtual ICollection<DetailOrdonnanceDto> DetailOrdonnances { get; set; }

    }
}