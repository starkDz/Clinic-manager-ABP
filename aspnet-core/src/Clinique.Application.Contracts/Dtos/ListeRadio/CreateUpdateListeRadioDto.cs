using System;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class CreateUpdateListeRadioDto
    {
        public Guid IdConsultation { get; set; }
        public Guid IdAnalyse { get; set; } 

    }
}