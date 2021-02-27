using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class CreateUpdateOrdonnanceDto
    {
        public Guid IdPatient { get; set; }
        public Guid IdMedecin { get; set; }
        public Guid IdConsultation { get; set; }

    }
}