using System;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class ListeAnalyseDto : AuditedEntityDto<Guid>
    {
        public Guid IdConsultation { get; set; }
        public Guid IdAnalyse { get; set; }

        public virtual EnumerationDto IdAnalyseNavigation { get; set; }
        public virtual ConsultationDto IdConsultationNavigation { get; set; }
   
        
    }
}