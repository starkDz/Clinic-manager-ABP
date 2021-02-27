using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class CreateUpdateEnumerationDto
    {
        public string Code { get; set; }
        public string DisplayFr { get; set; }
        public string DisplayAr { get; set; }
        public Guid? IdParent { get; set; }
        public string Valeur { get; set; }


    }
}