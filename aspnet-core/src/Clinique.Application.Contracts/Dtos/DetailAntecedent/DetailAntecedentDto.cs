using System;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class DetailAntecedentDto : AuditedEntityDto<Guid>
    {
        public Guid IdPatient { get; set; }
        public Guid IdAntecedent { get; set; }

        public virtual AntecedentMedicaleDto IdAntecedentNavigation { get; set; }
        public virtual PatientDto IdPatientNavigation { get; set; }

    }
}