using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class EnumerationDto : AuditedEntityDto<Guid>
    {
   
        public string Code { get; set; }
        public string DisplayFr { get; set; }
        public string DisplayAr { get; set; }
        public Guid? IdParent { get; set; }
        public string Valeur { get; set; }

        public virtual EnumerationDto IdParentNavigation { get; set; } 
    }
}