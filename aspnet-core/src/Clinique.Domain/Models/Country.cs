using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Clinique
{
    public partial class Country: AuditedAggregateRoot<Guid>
    {
        public Country()
        {
            Wilayas = new HashSet<Wilaya>();
        }

        public string DesignationFr { get; set; }
        public string DesignationAr { get; set; }

        public virtual ICollection<Wilaya> Wilayas { get; set; }
    }
}
