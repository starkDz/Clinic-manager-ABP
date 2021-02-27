using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Clinique
{
    public partial class Enumeration: AuditedAggregateRoot<Guid>
    { 
 
        public string Code { get; set; }
        public string DisplayFr { get; set; }
        public string DisplayAr { get; set; }
        public Guid? IdParent { get; set; }
        public string Valeur { get; set; }

        public virtual Enumeration IdParentNavigation { get; set; }
        public virtual ICollection<Enumeration> InverseIdParentNavigation { get; set; }
        public virtual ICollection<ListeAnalyse> ListeAnalyses { get; set; }
        public virtual ICollection<ListeRadio> ListeRadios { get; set; }
        public virtual ICollection<Medicament> Medicaments { get; set; }
        public virtual ICollection<Personnel> PersonnelIdCategorieNavigations { get; set; }
        public virtual ICollection<Personnel> PersonnelSpecialiteNavigations { get; set; }
    }
}
