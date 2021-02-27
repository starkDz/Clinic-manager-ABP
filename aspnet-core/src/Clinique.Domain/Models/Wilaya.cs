using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Clinique
{
    public partial class Wilaya: AuditedAggregateRoot<Guid>
    {
        public Wilaya()
        {
            ParametreCabinets = new HashSet<ParametreCabinet>();
        }
 
        public string DesignationFr { get; set; }
        public string DesignationAr { get; set; }
        public Guid IdCountry { get; set; }
        public string CodeWilaya { get; set; }

        public virtual Country IdCountryNavigation { get; set; }
        public virtual ICollection<ParametreCabinet> ParametreCabinets { get; set; }
    }
}
