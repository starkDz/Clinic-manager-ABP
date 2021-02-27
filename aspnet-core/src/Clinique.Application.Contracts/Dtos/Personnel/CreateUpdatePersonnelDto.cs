using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Clinique.Dtos
{
    public class CreateUpdatePersonnelDto
    {


        public Guid IdCategorie { get; set; }
        public string NomFr { get; set; }
        public string NomAr { get; set; }
        public string PrenomFr { get; set; }
        public string PrenomAr { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public Guid? Specialite { get; set; }
        public long? Age { get; set; }
        public string SituationFamilliale { get; set; }
        public string Sexe { get; set; }
        public string Groupage { get; set; }
        public string Email { get; set; }



    }
}