using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class CreateUpdateWilayaDto
    {
        public string DesignationFr { get; set; }
        public string DesignationAr { get; set; }
        public Guid IdCountry { get; set; }
        public string CodeWilaya { get; set; }
    }
}