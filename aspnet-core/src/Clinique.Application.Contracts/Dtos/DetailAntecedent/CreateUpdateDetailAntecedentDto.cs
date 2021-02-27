using System;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class CreateUpdateDetailAntecedentDto
    {
        public Guid IdPatient { get; set; }
        public Guid IdAntecedent { get; set; } 

    }
}