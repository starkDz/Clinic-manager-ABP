using System;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class ListeRadioDto : AuditedEntityDto<Guid>
    {
        public Guid IdConsulatation { get; set; }
        public Guid IdRadio { get; set; }

        public virtual ConsultationDto IdConsulatationNavigation { get; set; }
        public virtual EnumerationDto IdRadioNavigation { get; set; }
    
        
    }
}