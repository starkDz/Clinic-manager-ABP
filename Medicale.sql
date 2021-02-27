DROP TABLE "Patient";
DROP TABLE "Medicament";
DROP TABLE "ParametreCabinet";
DROP TABLE "Ordonnance";
DROP TABLE "RendezVous";
DROP TABLE "Consultation";
DROP TABLE "Enumeration";
DROP TABLE "Country";
DROP TABLE "Wilaya";
DROP TABLE "Personnel";
DROP TABLE "DetailOrdonnance";
DROP TABLE "AntecedentMedicale";
DROP TABLE "DetailAntecedent";
DROP TABLE "ListeAnalyse";
DROP TABLE "ListeRadio";

CREATE TABLE "Patient" (
"id" TEXT NOT NULL,
"nomFr" TEXT,
"prenomFr" TEXT,
"nomAr" TEXT,
"PrenomAr" TEXT,
"age" INTEGER,
"dateNaissance" TEXT,
"codePersonnel" TEXT,
"numeroCCP" TEXT,
"numeroCN" TEXT,
"numeroCA" TEXT,
"addresse" TEXT,
"telephone" TEXT,
"mobile" TEXT,
"descriptionFr" TEXT,
"descriptionAr" TEXT,
"situationFamilliale" TEXT,
"sexe" TEXT,
"groupage" TEXT,
"email" TEXT,
PRIMARY KEY ("id") 
);

CREATE TABLE "Medicament" (
"id" TEXT NOT NULL,
"designationFr" TEXT,
"designationAr" TEXT,
"idTypeMedicament" TEXT,
"dci" TEXT,
"forme" TEXT,
"condition" TEXT,
"dosage" TEXT,
PRIMARY KEY ("id") ,
CONSTRAINT "fk_Medicament_Enumeration_1" FOREIGN KEY ("idTypeMedicament") REFERENCES "Enumeration" ("id")
);

CREATE TABLE "ParametreCabinet" (
"id" TEXT NOT NULL,
"nomCabinetFr" TEXT,
"abreviationFr" TEXT,
"nomCabinetAr" TEXT,
"abreviationAr" TEXT,
"telephone" TEXT,
"mobile" TEXT,
"addresse" TEXT,
"idWilaya" TEXT,
PRIMARY KEY ("id") ,
CONSTRAINT "fk_ParametreCabinet_Wilaya_1" FOREIGN KEY ("idWilaya") REFERENCES "Wilaya" ("id")
);

CREATE TABLE "Ordonnance" (
"id" TEXT NOT NULL,
"idPatient" TEXT,
"idMedecin" TEXT,
"idConsultation" TEXT,
PRIMARY KEY ("id") ,
CONSTRAINT "fk_Ordonnance_Patient_1" FOREIGN KEY ("idPatient") REFERENCES "Patient" ("id"),
CONSTRAINT "fk_Ordonnance_Consultation_1" FOREIGN KEY ("idConsultation") REFERENCES "Consultation" ("id"),
CONSTRAINT "fk_Ordonnance_Personnel_1" FOREIGN KEY ("idMedecin") REFERENCES "Personnel" ("id")
);

CREATE TABLE "RendezVous" (
"id" TEXT NOT NULL,
"dateRendezVous" TEXT,
"idPatient" TEXT,
"idMedecin" TEXT,
"estValide" INTEGER,
"heureRendezVous" TEXT,
PRIMARY KEY ("id") ,
CONSTRAINT "fk_RendezVous_Personnel_1" FOREIGN KEY ("idMedecin") REFERENCES "Personnel" ("id"),
CONSTRAINT "fk_RendezVous_Patient_1" FOREIGN KEY ("idPatient") REFERENCES "Patient" ("id")
);

CREATE TABLE "Consultation" (
"id" TEXT NOT NULL,
"idPatient" TEXT,
"idMedecin" TEXT,
"dateConsultation" TEXT,
"heureConsultation" TEXT,
"avecRadio" INTEGER,
"avecAnalyse" INTEGER,
"avecOrdonnace" INTEGER,
"poids" TEXT,
"taille" TEXT,
"frequenceCardiaque" TEXT,
"temperature" TEXT,
"glycemie" TEXT,
"observation" TEXT,
"prix" TEXT,
PRIMARY KEY ("id") ,
CONSTRAINT "fk_Consultation_Patient_1" FOREIGN KEY ("idPatient") REFERENCES "Patient" ("id"),
CONSTRAINT "fk_Consultation_Personnel_1" FOREIGN KEY ("idMedecin") REFERENCES "Personnel" ("id")
);

CREATE TABLE "Enumeration" (
"id" TEXT NOT NULL,
"code" TEXT,
"displayFr" TEXT,
"displayAr" TEXT,
"idParent" TEXT,
"valeur" TEXT,
PRIMARY KEY ("id") ,
CONSTRAINT "fk_Enumeration_Enumeration_1" FOREIGN KEY ("idParent") REFERENCES "Enumeration" ("id")
);

CREATE TABLE "Country" (
"id" TEXT NOT NULL,
"designationFr" TEXT,
"designationAr" TEXT,
PRIMARY KEY ("id") 
);

CREATE TABLE "Wilaya" (
"id" TEXT NOT NULL,
"designationFr" TEXT,
"designationAr" TEXT,
"idCountry" TEXT,
"codeWilaya" TEXT,
PRIMARY KEY ("id") ,
CONSTRAINT "fk_Wilaya_Country_1" FOREIGN KEY ("idCountry") REFERENCES "Country" ("id")
);

CREATE TABLE "Personnel" (
"id" TEXT NOT NULL,
"idCategorie" TEXT,
"nomFr" TEXT,
"nomAr" TEXT,
"prenomFr" TEXT,
"prenomAr" TEXT,
"adresse" TEXT,
"telephone" TEXT,
"mobile" TEXT,
"specialite" TEXT,
"age" INTEGER,
"situationFamilliale" TEXT,
"sexe" TEXT,
"groupage" TEXT,
"email" TEXT,
PRIMARY KEY ("id") ,
CONSTRAINT "fk_Personnel_Enumeration_1" FOREIGN KEY ("idCategorie") REFERENCES "Enumeration" ("id"),
CONSTRAINT "fk_Personnel_Enumeration_2" FOREIGN KEY ("specialite") REFERENCES "Enumeration" ("id")
);

CREATE TABLE "DetailOrdonnance" (
"id" TEXT NOT NULL,
"idOrdonnance" TEXT,
"idMedicament" TEXT,
"quantite" INTEGER,
"descriptionFr" TEXT,
"descriptionAr" TEXT,
PRIMARY KEY ("id") ,
CONSTRAINT "fk_DetailOrdonnance_Ordonnance_1" FOREIGN KEY ("idOrdonnance") REFERENCES "Ordonnance" ("id"),
CONSTRAINT "fk_DetailOrdonnance_Medicament_1" FOREIGN KEY ("idMedicament") REFERENCES "Medicament" ("id")
);

CREATE TABLE "AntecedentMedicale" (
"id" TEXT NOT NULL,
"designationFr" TEXT,
"designationAr" TEXT,
PRIMARY KEY ("id") 
);

CREATE TABLE "DetailAntecedent" (
"id" INTEGER NOT NULL,
"idPatient" TEXT,
"idAntecedent" TEXT,
PRIMARY KEY ("id") ,
CONSTRAINT "fk_DetailAntecedent_Patient_1" FOREIGN KEY ("idPatient") REFERENCES "Patient" ("id"),
CONSTRAINT "fk_DetailAntecedent_AntecedentMedicale_1" FOREIGN KEY ("idAntecedent") REFERENCES "AntecedentMedicale" ("id")
);

CREATE TABLE "ListeAnalyse" (
"id" INTEGER NOT NULL,
"idConsultation" TEXT,
"idAnalyse" TEXT,
PRIMARY KEY ("id") ,
CONSTRAINT "fk_ListeAnalyse_Consultation_1" FOREIGN KEY ("idConsultation") REFERENCES "Consultation" ("id"),
CONSTRAINT "fk_ListeAnalyse_Enumeration_1" FOREIGN KEY ("idAnalyse") REFERENCES "Enumeration" ("id")
);

CREATE TABLE "ListeRadio" (
"id" INTEGER NOT NULL,
"idConsulatation" TEXT,
"idRadio" TEXT,
PRIMARY KEY ("id") ,
CONSTRAINT "fk_ListeRadio_Consultation_1" FOREIGN KEY ("idConsulatation") REFERENCES "Consultation" ("id"),
CONSTRAINT "fk_ListeRadio_Enumeration_1" FOREIGN KEY ("idRadio") REFERENCES "Enumeration" ("id")
);

