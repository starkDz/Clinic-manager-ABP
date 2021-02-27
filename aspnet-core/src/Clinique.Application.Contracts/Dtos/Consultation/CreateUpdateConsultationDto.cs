using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class CreateUpdateConsultationDto  
    { 
        public Guid IdPatient { get; set; }
        public Guid IdMedecin { get; set; }
        public DateTime DateConsultation { get; set; }
        public string HeureConsultation { get; set; }
        public bool? AvecRadio { get; set; }
        public bool? AvecAnalyse { get; set; }
        public bool? AvecOrdonnace { get; set; }
        public long? Poids { get; set; }
        public long? Taille { get; set; }
        public long? FrequenceCardiaque { get; set; }
        public long? Temperature { get; set; }
        public double? Glycemie { get; set; }
        public string Observation { get; set; }
        public long? Prix { get; set; } 

    }
}