using System;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class CreateUpdateDetailOrdonnanceDto 
    {
        public Guid IdOrdonnance { get; set; }
        public Guid IdMedicament { get; set; }
        public long? Quantite { get; set; }
        public string DescriptionFr { get; set; }
        public string DescriptionAr { get; set; } 

    }
}