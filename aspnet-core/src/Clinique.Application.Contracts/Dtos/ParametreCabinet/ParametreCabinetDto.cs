using System;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class ParametreCabinetDto : AuditedEntityDto<Guid>
    {
        public string NomCabinetFr { get; set; }
        public string AbreviationFr { get; set; }
        public string NomCabinetAr { get; set; }
        public string AbreviationAr { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Addresse { get; set; }
        public Guid? IdWilaya { get; set; }

        public virtual WilayaDto IdWilayaNavigation { get; set; }
        
    }
}