using AutoMapper;
using Clinique.Dtos;

namespace Clinique
{
    public class CliniqueApplicationAutoMapperProfile : Profile
    {
        public CliniqueApplicationAutoMapperProfile()
        {

            CreateMap<AntecedentMedicale, AntecedentMedicaleDto>();
            CreateMap<CreateUpdateAntecedentMedicaleDto, AntecedentMedicale>();
            CreateMap<Consultation, ConsultationDto>();
            CreateMap<CreateUpdateConsultationDto, Consultation>();
            CreateMap<Country, CountryDto>();
            CreateMap<CreateUpdateCountryDto, Country>();
            CreateMap<DetailAntecedent, DetailAntecedentDto>();
            CreateMap<CreateUpdateDetailAntecedentDto, DetailAntecedent>();
            CreateMap<DetailOrdonnance, DetailOrdonnanceDto>();
            CreateMap<CreateUpdateDetailOrdonnanceDto, DetailOrdonnance>();
            CreateMap<Enumeration, EnumerationDto>();
            CreateMap<CreateUpdateEnumerationDto, Enumeration>();
            CreateMap<ListeAnalyse, ListeAnalyseDto>();
            CreateMap<CreateUpdateListeAnalyseDto, ListeAnalyse>();
            CreateMap<ListeRadio, ListeRadioDto>();
            CreateMap<CreateUpdateListeRadioDto, ListeRadio>();
            CreateMap<Medicament, MedicamentDto>();
            CreateMap<CreateUpdateMedicamentDto, Medicament>();
            CreateMap<Ordonnance, OrdonnanceDto>();
            CreateMap<CreateUpdateOrdonnanceDto, Ordonnance>();
            CreateMap<ParametreCabinet, ParametreCabinetDto>();
            CreateMap<CreateUpdateParametreCabinetDto, ParametreCabinet>();
            CreateMap<Patient, PatientDto>();
            CreateMap<CreateUpdatePatientDto, Patient>();
            CreateMap<Personnel, PersonnelDto>();
            CreateMap<CreateUpdatePersonnelDto, Personnel>();
            CreateMap<RendezVou, RendezVousDto>();
            CreateMap<CreateUpdateRendezVousDto, RendezVou>();
            CreateMap<Wilaya, WilayaDto>();
            CreateMap<CreateUpdateWilayaDto, Wilaya>();

            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
        }
    }
}
