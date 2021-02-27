using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Clinique 
{
    public partial class ParametreCabinet: AuditedAggregateRoot<Guid>
    { 
        public string NomCabinetFr { get; set; }
        public string AbreviationFr { get; set; }
        public string NomCabinetAr { get; set; }
        public string AbreviationAr { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Addresse { get; set; }
        public Guid? IdWilaya { get; set; }

        public virtual Wilaya IdWilayaNavigation { get; set; }
    }
}
