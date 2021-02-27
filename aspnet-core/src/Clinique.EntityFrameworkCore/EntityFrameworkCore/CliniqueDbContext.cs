using Microsoft.EntityFrameworkCore;
using Clinique.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore; 
namespace Clinique.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See CliniqueMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class CliniqueDbContext : AbpDbContext<CliniqueDbContext>
    {
        public DbSet<AppUser> Users { get; set; }
        public virtual DbSet<AntecedentMedicale> AntecedentMedicales { get; set; }
        public virtual DbSet<Consultation> Consultations { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<DetailAntecedent> DetailAntecedents { get; set; }
        public virtual DbSet<DetailOrdonnance> DetailOrdonnances { get; set; }
        public virtual DbSet<Enumeration> Enumerations { get; set; }
        public virtual DbSet<ListeAnalyse> ListeAnalyses { get; set; }
        public virtual DbSet<ListeRadio> ListeRadios { get; set; }
        public virtual DbSet<Medicament> Medicaments { get; set; }
        public virtual DbSet<Ordonnance> Ordonnances { get; set; }
        public virtual DbSet<ParametreCabinet> ParametreCabinets { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Personnel> Personnel { get; set; }
        public virtual DbSet<RendezVou> RendezVous { get; set; }
        public virtual DbSet<Wilaya> Wilayas { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside CliniqueDbContextModelCreatingExtensions.ConfigureClinique
         */

        public CliniqueDbContext(DbContextOptions<CliniqueDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /* Configure the shared tables (with included modules) here */

            modelBuilder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser
                
                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the CliniqueEfCoreEntityExtensionMappings class
                 */
            });
            

            /* Configure your own tables/entities inside the ConfigureClinique method */

            modelBuilder.ConfigureClinique();
        }
    }
}
