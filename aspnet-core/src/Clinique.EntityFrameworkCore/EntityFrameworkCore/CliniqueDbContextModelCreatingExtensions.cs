using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Clinique.EntityFrameworkCore
{
    public static class CliniqueDbContextModelCreatingExtensions
    {
        public static void ConfigureClinique(this ModelBuilder modelBuilder)
        {
            Check.NotNull(modelBuilder, nameof(modelBuilder));
            modelBuilder.Entity<AntecedentMedicale>(entity =>
                        {
                            entity.ToTable("AntecedentMedicale");

                            entity.Property(e => e.Id).HasColumnName("id");

                            entity.Property(e => e.DesignationAr).HasColumnName("designationAr");

                            entity.Property(e => e.DesignationFr).HasColumnName("designationFr");
                            entity.ConfigureByConvention();
                        });

            modelBuilder.Entity<Consultation>(entity =>
           {
               entity.ToTable("Consultation");

               entity.Property(e => e.Id).HasColumnName("id");

               entity.Property(e => e.AvecAnalyse).HasColumnName("avecAnalyse");

               entity.Property(e => e.AvecOrdonnace).HasColumnName("avecOrdonnace");

               entity.Property(e => e.AvecRadio).HasColumnName("avecRadio");

               entity.Property(e => e.DateConsultation).HasColumnName("dateConsultation");

               entity.Property(e => e.FrequenceCardiaque).HasColumnName("frequenceCardiaque");

               entity.Property(e => e.Glycemie).HasColumnName("glycemie");

               entity.Property(e => e.HeureConsultation).HasColumnName("heureConsultation");

               entity.Property(e => e.IdMedecin).HasColumnName("idMedecin");

               entity.Property(e => e.IdPatient).HasColumnName("idPatient");

               entity.Property(e => e.Observation).HasColumnName("observation");

               entity.Property(e => e.Poids).HasColumnName("poids");

               entity.Property(e => e.Prix).HasColumnName("prix");

               entity.Property(e => e.Taille).HasColumnName("taille");

               entity.Property(e => e.Temperature).HasColumnName("temperature");

               entity.HasOne(d => d.IdMedecinNavigation)
                   .WithMany(p => p.Consultations)
                   .HasForeignKey(d => d.IdMedecin);

               entity.HasOne(d => d.IdPatientNavigation)
                   .WithMany(p => p.Consultations)
                   .HasForeignKey(d => d.IdPatient);
               entity.ConfigureByConvention();
           });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DesignationAr).HasColumnName("designationAr");

                entity.Property(e => e.DesignationFr).HasColumnName("designationFr");
                entity.ConfigureByConvention();
            });

            modelBuilder.Entity<DetailAntecedent>(entity =>
            {
                entity.ToTable("DetailAntecedent");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdAntecedent).HasColumnName("idAntecedent");

                entity.Property(e => e.IdPatient).HasColumnName("idPatient");

                entity.HasOne(d => d.IdAntecedentNavigation)
                    .WithMany(p => p.DetailAntecedents)
                    .HasForeignKey(d => d.IdAntecedent);

                entity.HasOne(d => d.IdPatientNavigation)
                    .WithMany(p => p.DetailAntecedents)
                    .HasForeignKey(d => d.IdPatient);
                entity.ConfigureByConvention();
            });

            modelBuilder.Entity<DetailOrdonnance>(entity =>
            {
                entity.ToTable("DetailOrdonnance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DescriptionAr).HasColumnName("descriptionAr");

                entity.Property(e => e.DescriptionFr).HasColumnName("descriptionFr");

                entity.Property(e => e.IdMedicament).HasColumnName("idMedicament");

                entity.Property(e => e.IdOrdonnance).HasColumnName("idOrdonnance");

                entity.Property(e => e.Quantite).HasColumnName("quantite");

                entity.HasOne(d => d.IdMedicamentNavigation)
                    .WithMany(p => p.DetailOrdonnances)
                    .HasForeignKey(d => d.IdMedicament);

                entity.HasOne(d => d.IdOrdonnanceNavigation)
                    .WithMany(p => p.DetailOrdonnances)
                    .HasForeignKey(d => d.IdOrdonnance);
                entity.ConfigureByConvention();
            });

            modelBuilder.Entity<Enumeration>(entity =>
            {
                entity.ToTable("Enumeration");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.DisplayAr).HasColumnName("displayAr");

                entity.Property(e => e.DisplayFr).HasColumnName("displayFr");

                entity.Property(e => e.IdParent).HasColumnName("idParent");

                entity.Property(e => e.Valeur).HasColumnName("valeur");

                entity.HasOne(d => d.IdParentNavigation)
                    .WithMany(p => p.InverseIdParentNavigation)
                    .HasForeignKey(d => d.IdParent);
                entity.ConfigureByConvention();
            });

            modelBuilder.Entity<ListeAnalyse>(entity =>
            {
                entity.ToTable("ListeAnalyse");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdAnalyse).HasColumnName("idAnalyse");

                entity.Property(e => e.IdConsultation).HasColumnName("idConsultation");

                entity.HasOne(d => d.IdAnalyseNavigation)
                    .WithMany(p => p.ListeAnalyses)
                    .HasForeignKey(d => d.IdAnalyse);

                entity.HasOne(d => d.IdConsultationNavigation)
                    .WithMany(p => p.ListeAnalyses)
                    .HasForeignKey(d => d.IdConsultation);
                entity.ConfigureByConvention();
            });

            modelBuilder.Entity<ListeRadio>(entity =>
            {
                entity.ToTable("ListeRadio");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdConsulatation).HasColumnName("idConsulatation");

                entity.Property(e => e.IdRadio).HasColumnName("idRadio");

                entity.HasOne(d => d.IdConsulatationNavigation)
                    .WithMany(p => p.ListeRadios)
                    .HasForeignKey(d => d.IdConsulatation);

                entity.HasOne(d => d.IdRadioNavigation)
                    .WithMany(p => p.ListeRadios)
                    .HasForeignKey(d => d.IdRadio);
                entity.ConfigureByConvention();
            });

            modelBuilder.Entity<Medicament>(entity =>
            {
                entity.ToTable("Medicament");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Condition).HasColumnName("condition");

                entity.Property(e => e.Dci).HasColumnName("dci");

                entity.Property(e => e.DesignationAr).HasColumnName("designationAr");

                entity.Property(e => e.DesignationFr).HasColumnName("designationFr");

                entity.Property(e => e.Dosage).HasColumnName("dosage");

                entity.Property(e => e.Forme).HasColumnName("forme");

                entity.Property(e => e.IdTypeMedicament).HasColumnName("idTypeMedicament");

                entity.HasOne(d => d.IdTypeMedicamentNavigation)
                    .WithMany(p => p.Medicaments)
                    .HasForeignKey(d => d.IdTypeMedicament);
                entity.ConfigureByConvention();
            });

            modelBuilder.Entity<Ordonnance>(entity =>
            {
                entity.ToTable("Ordonnance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdConsultation).HasColumnName("idConsultation");

                entity.Property(e => e.IdMedecin).HasColumnName("idMedecin");

                entity.Property(e => e.IdPatient).HasColumnName("idPatient");

                entity.HasOne(d => d.IdConsultationNavigation)
                    .WithMany(p => p.Ordonnances)
                    .HasForeignKey(d => d.IdConsultation);

                entity.HasOne(d => d.IdMedecinNavigation)
                    .WithMany(p => p.Ordonnances)
                    .HasForeignKey(d => d.IdMedecin);

                entity.HasOne(d => d.IdPatientNavigation)
                    .WithMany(p => p.Ordonnances)
                    .HasForeignKey(d => d.IdPatient);
                entity.ConfigureByConvention();
            });

            modelBuilder.Entity<ParametreCabinet>(entity =>
            {
                entity.ToTable("ParametreCabinet");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbreviationAr).HasColumnName("abreviationAr");

                entity.Property(e => e.AbreviationFr).HasColumnName("abreviationFr");

                entity.Property(e => e.Addresse).HasColumnName("addresse");

                entity.Property(e => e.IdWilaya).HasColumnName("idWilaya");

                entity.Property(e => e.Mobile).HasColumnName("mobile");

                entity.Property(e => e.NomCabinetAr).HasColumnName("nomCabinetAr");

                entity.Property(e => e.NomCabinetFr).HasColumnName("nomCabinetFr");

                entity.Property(e => e.Telephone).HasColumnName("telephone");

                entity.HasOne(d => d.IdWilayaNavigation)
                    .WithMany(p => p.ParametreCabinets)
                    .HasForeignKey(d => d.IdWilaya);
                entity.ConfigureByConvention();
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Addresse).HasColumnName("addresse");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.CodePersonnel).HasColumnName("codePersonnel");

                entity.Property(e => e.DateNaissance).HasColumnName("dateNaissance");

                entity.Property(e => e.DescriptionAr).HasColumnName("descriptionAr");

                entity.Property(e => e.DescriptionFr).HasColumnName("descriptionFr");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Groupage).HasColumnName("groupage");

                entity.Property(e => e.Mobile).HasColumnName("mobile");

                entity.Property(e => e.NomAr).HasColumnName("nomAr");

                entity.Property(e => e.NomFr).HasColumnName("nomFr");

                entity.Property(e => e.NumeroCa).HasColumnName("numeroCA");

                entity.Property(e => e.NumeroCcp).HasColumnName("numeroCCP");

                entity.Property(e => e.NumeroCn).HasColumnName("numeroCN");

                entity.Property(e => e.PrenomFr).HasColumnName("prenomFr");

                entity.Property(e => e.Sexe).HasColumnName("sexe");

                entity.Property(e => e.SituationFamilliale).HasColumnName("situationFamilliale");

                entity.Property(e => e.Telephone).HasColumnName("telephone");
                entity.ConfigureByConvention();
            });

            modelBuilder.Entity<Personnel>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adresse).HasColumnName("adresse");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Groupage).HasColumnName("groupage");

                entity.Property(e => e.IdCategorie).HasColumnName("idCategorie");

                entity.Property(e => e.Mobile).HasColumnName("mobile");

                entity.Property(e => e.NomAr).HasColumnName("nomAr");

                entity.Property(e => e.NomFr).HasColumnName("nomFr");

                entity.Property(e => e.PrenomAr).HasColumnName("prenomAr");

                entity.Property(e => e.PrenomFr).HasColumnName("prenomFr");

                entity.Property(e => e.Sexe).HasColumnName("sexe");

                entity.Property(e => e.SituationFamilliale).HasColumnName("situationFamilliale");

                entity.Property(e => e.Specialite).HasColumnName("specialite");

                entity.Property(e => e.Telephone).HasColumnName("telephone");

                entity.HasOne(d => d.IdCategorieNavigation)
                    .WithMany(p => p.PersonnelIdCategorieNavigations)
                    .HasForeignKey(d => d.IdCategorie);

                entity.HasOne(d => d.SpecialiteNavigation)
                    .WithMany(p => p.PersonnelSpecialiteNavigations)
                    .HasForeignKey(d => d.Specialite);
                entity.ConfigureByConvention();
            });

            modelBuilder.Entity<RendezVou>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateRendezVous).HasColumnName("dateRendezVous");

                entity.Property(e => e.EstValide).HasColumnName("estValide");

                entity.Property(e => e.HeureRendezVous).HasColumnName("heureRendezVous");

                entity.Property(e => e.IdMedecin).HasColumnName("idMedecin");

                entity.Property(e => e.IdPatient).HasColumnName("idPatient");

                entity.HasOne(d => d.IdMedecinNavigation)
                    .WithMany(p => p.RendezVous)
                    .HasForeignKey(d => d.IdMedecin);

                entity.HasOne(d => d.IdPatientNavigation)
                    .WithMany(p => p.RendezVous)
                    .HasForeignKey(d => d.IdPatient);
                entity.ConfigureByConvention();
            });

            modelBuilder.Entity<Wilaya>(entity =>
            {
                entity.ToTable("Wilaya");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeWilaya).HasColumnName("codeWilaya");

                entity.Property(e => e.DesignationAr).HasColumnName("designationAr");

                entity.Property(e => e.DesignationFr).HasColumnName("designationFr");

                entity.Property(e => e.IdCountry).HasColumnName("idCountry");

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.Wilayas)
                    .HasForeignKey(d => d.IdCountry);
                entity.ConfigureByConvention();
            });

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(CliniqueConsts.DbTablePrefix + "YourEntities", CliniqueConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}