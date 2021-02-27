using System;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class CreateUpdateRendezVousDto 
    {
        public DateTime DateRendezVous { get; set; }
        public Guid IdPatient { get; set; }
        public Guid IdMedecin { get; set; }
        public bool? EstValide { get; set; }
        public string HeureRendezVous { get; set; }

 

    }
}