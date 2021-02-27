using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class CreateUpdatePatientDto 
    {   
        public string NomFr { get; set; }
        public string PrenomFr { get; set; }
        public string NomAr { get; set; }
        public string PrenomAr { get; set; }
        public long? Age { get; set; }
        public DateTime DateNaissance { get; set; }
        public string CodePersonnel { get; set; }
        public string NumeroCcp { get; set; }
        public string NumeroCn { get; set; }
        public string NumeroCa { get; set; }
        public string Addresse { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string DescriptionFr { get; set; }
        public string DescriptionAr { get; set; }
        public string SituationFamilliale { get; set; }
        public string Sexe { get; set; }
        public string Groupage { get; set; }
        public string Email { get; set; }
    
    }
}