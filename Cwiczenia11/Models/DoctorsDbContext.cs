using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Models
{
    public class DoctorsDbContext : DbContext
    {
        public virtual DbSet<Medicament> Medicaments { get; set; }
        public virtual DbSet<Prescription_Medicament> Prescription_Medicaments { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }

        public DoctorsDbContext()
        {

        }

        public DoctorsDbContext(DbContextOptions<DoctorsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Prescription_Medicament>().HasKey(pm => new { pm.IdMedicament, pm.IdPrescription });

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { IdDoctor = 1, FirstName = "Alva", LastName = "Profit", Email = "aprofit0@ning.com" },
                new Doctor { IdDoctor = 2, FirstName = "Cass", LastName = "Cottem", Email = "ccottem1@examiner.com" },
                new Doctor { IdDoctor = 3, FirstName = "Maressa", LastName = "Sainte Paul", Email = "msaintepaul2@bbb.org" },
                new Doctor { IdDoctor = 4, FirstName = "Arlin", LastName = "Khomin", Email = "akhomin3@reference.com" },
                new Doctor { IdDoctor = 5, FirstName = "Reeva", LastName = "Shapira", Email = "rshapira4@ebay.com" },
                new Doctor { IdDoctor = 6, FirstName = "Saw", LastName = "Dudley", Email = "sdudley5@surveymonkey.com" },
                new Doctor { IdDoctor = 7, FirstName = "Amil", LastName = "Georgiades", Email = "ageorgiades6@linkedin.com" },
                new Doctor { IdDoctor = 8, FirstName = "Alica", LastName = "Bessey", Email = "abessey7@networkadvertising.org" },
                new Doctor { IdDoctor = 9, FirstName = "Adel", LastName = "Semered", Email = "asemered8@washingtonpost.com" },
                new Doctor { IdDoctor = 10, FirstName = "Dieter", LastName = "Lambol", Email = "dlambol9@yellowbook.com" }
            );

            modelBuilder.Entity<Patient>().HasData(
                new Patient { IdPatient = 1, FirstName = "Jania", LastName = "Sherbrook", Date = new DateTime(1965, 1, 30, 0, 0, 0) },
                new Patient { IdPatient = 2, FirstName = "Collie", LastName = "Jenkison", Date = new DateTime(1978, 4, 5, 0, 0, 0) },
                new Patient { IdPatient = 3, FirstName = "Dulcia", LastName = "Alejandre", Date = new DateTime(1970, 3, 2, 0, 0, 0) },
                new Patient { IdPatient = 4, FirstName = "Westleigh", LastName = "McCome", Date = new DateTime(1946, 4, 20, 0, 0, 0) },
                new Patient { IdPatient = 5, FirstName = "Anthe", LastName = "MacDonogh", Date = new DateTime(1976, 4, 8, 0, 0, 0) },
                new Patient { IdPatient = 6, FirstName = "Blair", LastName = "Burtwell", Date = new DateTime(1946, 6, 11, 0, 0, 0) },
                new Patient { IdPatient = 7, FirstName = "Isahella", LastName = "Drepp", Date = new DateTime(1982, 10, 10, 0, 0, 0) },
                new Patient { IdPatient = 8, FirstName = "Freddy", LastName = "Burgoin", Date = new DateTime(1975, 1, 31, 0, 0, 0) },
                new Patient { IdPatient = 9, FirstName = "Bobbie", LastName = "Hayman", Date = new DateTime(1974, 7, 4, 0, 0, 0) },
                new Patient { IdPatient = 10, FirstName = "Dinny", LastName = "Sneesbie", Date = new DateTime(1976, 6, 26, 0, 0, 0) }
            );

            modelBuilder.Entity<Medicament>().HasData(
                new Medicament { IdMedicament = 1, Name = "PHENYLEPHRINE HYDROCHLORIDE", Description = "Cardinal Health", Type = "Phenylephrine Hydrochloride" },
                new Medicament { IdMedicament = 2, Name = "TITANIUM DIOXIDE", Description = "THEFACESHOP CO., LTD.", Type = "PHYTOGENIC INFINITE MAKEUP BASE" },
                new Medicament { IdMedicament = 3, Name = "ceftriaxone", Description = "West-Ward Pharmaceutical Corp", Type = "Ceftriaxone" },
                new Medicament { IdMedicament = 4, Name = "mineral oil, petrolatum, phenylephrine HCl", Description = "Perrigo New York Inc", Type = "Hemorrhoidal" },
                new Medicament { IdMedicament = 5, Name = "Fluorescein Sodium", Description = "Akorn, Inc.", Type = "FUL-GLO" },
                new Medicament { IdMedicament = 6, Name = "Benzalkonium Chloride", Description = "Mason Chemical Company", Type = "Nobac Plus AB-F" },
                new Medicament { IdMedicament = 7, Name = "carbamazepine", Description = "Novartis Pharmaceuticals Corporation", Type = "Tegretol" },
                new Medicament { IdMedicament = 8, Name = "sodium fluoride", Description = "GlaxoSmithKline Consumer Healthcare LP", Type = "BIOTENE" },
                new Medicament { IdMedicament = 9, Name = "anastrozole", Description = "Kremers Urban Pharmaceuticals Inc.", Type = "Anastrozole" },
                new Medicament { IdMedicament = 10, Name = "TRICLOSAN", Description = "Taizhou Xinzhixuan Daily-Use Co., Ltd.", Type = "Healing Waters Mandarin Vanilla Antibacterial Hand Soap" },
                new Medicament { IdMedicament = 11, Name = "Lamotrigine", Description = "Aurobindo Pharma Limited", Type = "Lamotrigine" },
                new Medicament { IdMedicament = 12, Name = "Mineral Oil", Description = "Kinray Inc.", Type = "Mineral Oil" },
                new Medicament { IdMedicament = 13, Name = "Isopropyl alcohol", Description = "QUALITY CHOICE (Chain Drug Marketing Association)", Type = "Isopropyl alcohol" },
                new Medicament { IdMedicament = 14, Name = "Brompheniramine maleate and Pseudoephedrine hydrochloride", Description = "Preferred Pharmaceuticals, Inc", Type = "Q-Tapp" },
                new Medicament { IdMedicament = 15, Name = "orphenadrine citrate", Description = "Graceway Pharmaceuticals, LLC", Type = "Norflex" },
                new Medicament { IdMedicament = 16, Name = "ALLANTOIN GLYCERIN", Description = "ADVANCED BIOMEDICS INC", Type = "NEUTRACETT" },
                new Medicament { IdMedicament = 17, Name = "doxazosin mesylate", Description = "Mylan Institutional Inc.", Type = "doxazosin" },
                new Medicament { IdMedicament = 18, Name = "TRICLOSAN", Description = "Jani-Source, LLC", Type = "High Five" },
                new Medicament { IdMedicament = 19, Name = "TOLNAFTATE", Description = "Avon Products, Inc.", Type = "Foot Works Healthy" },
                new Medicament { IdMedicament = 20, Name = "BENZOYL PEROXIDE", Description = "BioComp Pharma, Inc.", Type = "BP Cleansing" }
            );

            modelBuilder.Entity<Prescription>().HasData(
                new Prescription { IdPrescription = 1, Date = new DateTime(2019, 6, 19, 0, 0, 0), DueDate = new DateTime(2019, 7, 10, 0, 0, 0), IdPatient = 6, IdDoctor = 5 },
                new Prescription { IdPrescription = 2, Date = new DateTime(2019, 5, 23, 0, 0, 0), DueDate = new DateTime(2019, 6, 29, 0, 0, 0), IdPatient = 6, IdDoctor = 2 },
                new Prescription { IdPrescription = 3, Date = new DateTime(2019, 5, 22, 0, 0, 0), DueDate = new DateTime(2019, 7, 14, 0, 0, 0), IdPatient = 9, IdDoctor = 3 },
                new Prescription { IdPrescription = 4, Date = new DateTime(2019, 6, 13, 0, 0, 0), DueDate = new DateTime(2019, 7, 17, 0, 0, 0), IdPatient = 2, IdDoctor = 2 },
                new Prescription { IdPrescription = 5, Date = new DateTime(2019, 5, 25, 0, 0, 0), DueDate = new DateTime(2019, 7, 7, 0, 0, 0), IdPatient = 6, IdDoctor = 3 },
                new Prescription { IdPrescription = 6, Date = new DateTime(2019, 5, 30, 0, 0, 0), DueDate = new DateTime(2019, 7, 18, 0, 0, 0), IdPatient = 2, IdDoctor = 8 },
                new Prescription { IdPrescription = 7, Date = new DateTime(2019, 5, 22, 0, 0, 0), DueDate = new DateTime(2019, 7, 12, 0, 0, 0), IdPatient = 8, IdDoctor = 4 },
                new Prescription { IdPrescription = 8, Date = new DateTime(2019, 6, 10, 0, 0, 0), DueDate = new DateTime(2019, 7, 19, 0, 0, 0), IdPatient = 5, IdDoctor = 9 },
                new Prescription { IdPrescription = 9, Date = new DateTime(2019, 6, 19, 0, 0, 0), DueDate = new DateTime(2019, 7, 14, 0, 0, 0), IdPatient = 8, IdDoctor = 3 },
                new Prescription { IdPrescription = 10, Date = new DateTime(2019, 6, 11, 0, 0, 0), DueDate = new DateTime(2019, 7, 9, 0, 0, 0), IdPatient = 9, IdDoctor = 9 },
                new Prescription { IdPrescription = 11, Date = new DateTime(2019, 6, 2, 0, 0, 0), DueDate = new DateTime(2019, 7, 14, 0, 0, 0), IdPatient = 10, IdDoctor = 7 },
                new Prescription { IdPrescription = 12, Date = new DateTime(2019, 6, 9, 0, 0, 0), DueDate = new DateTime(2019, 7, 17, 0, 0, 0), IdPatient = 1, IdDoctor = 7 },
                new Prescription { IdPrescription = 13, Date = new DateTime(2019, 5, 24, 0, 0, 0), DueDate = new DateTime(2019, 7, 11, 0, 0, 0), IdPatient = 7, IdDoctor = 6 },
                new Prescription { IdPrescription = 14, Date = new DateTime(2019, 6, 19, 0, 0, 0), DueDate = new DateTime(2019, 6, 22, 0, 0, 0), IdPatient = 3, IdDoctor = 5 },
                new Prescription { IdPrescription = 15, Date = new DateTime(2019, 6, 8, 0, 0, 0), DueDate = new DateTime(2019, 6, 29, 0, 0, 0), IdPatient = 3, IdDoctor = 2 },
                new Prescription { IdPrescription = 16, Date = new DateTime(2019, 6, 1, 0, 0, 0), DueDate = new DateTime(2019, 7, 1, 0, 0, 0), IdPatient = 7, IdDoctor = 10 },
                new Prescription { IdPrescription = 17, Date = new DateTime(2019, 6, 16, 0, 0, 0), DueDate = new DateTime(2019, 6, 30, 0, 0, 0), IdPatient = 4, IdDoctor = 3 },
                new Prescription { IdPrescription = 18, Date = new DateTime(2019, 5, 27, 0, 0, 0), DueDate = new DateTime(2019, 7, 4, 0, 0, 0), IdPatient = 3, IdDoctor = 6 },
                new Prescription { IdPrescription = 19, Date = new DateTime(2019, 6, 17, 0, 0, 0), DueDate = new DateTime(2019, 7, 5, 0, 0, 0), IdPatient = 9, IdDoctor = 6 },
                new Prescription { IdPrescription = 20, Date = new DateTime(2019, 6, 3, 0, 0, 0), DueDate = new DateTime(2019, 7, 9, 0, 0, 0), IdPatient = 9, IdDoctor = 5 }
            );

            modelBuilder.Entity<Prescription_Medicament>().HasData(
            new Prescription_Medicament { IdMedicament = 11, IdPrescription = 1, Dose = 79, Details = "cursus id turpis integer aliquet massa id lobortis" },
            new Prescription_Medicament { IdMedicament = 18, IdPrescription = 17, Dose = 76, Details = "turpis nec euismod scelerisque quam turpis adipiscing lorem vitae" },
            new Prescription_Medicament { IdMedicament = 7, IdPrescription = 10, Dose = 61, Details = "id sapien in sapien iaculis congue" },
            new Prescription_Medicament { IdMedicament = 3, IdPrescription = 15, Dose = 50, Details = "non sodales sed tincidunt eu" },
            new Prescription_Medicament { IdMedicament = 14, IdPrescription = 7, Dose = 82, Details = "consequat lectus in est risus auctor" },
            new Prescription_Medicament { IdMedicament = 1, IdPrescription = 19, Dose = 60, Details = "accumsan tellus nisi eu orci mauris lacinia sapien quis" },
            new Prescription_Medicament { IdMedicament = 14, IdPrescription = 11, Dose = 95, Details = "ligula pellentesque ultrices phasellus id sapien in" },
            new Prescription_Medicament { IdMedicament = 16, IdPrescription = 3, Dose = 19, Details = "sed lacus morbi sem mauris laoreet ut rhoncus aliquet pulvinar" },
            new Prescription_Medicament { IdMedicament = 6, IdPrescription = 5, Dose = 8, Details = "aliquam non mauris morbi non lectus aliquam sit amet" },
            new Prescription_Medicament { IdMedicament = 7, IdPrescription = 14, Dose = 26, Details = "dictumst etiam faucibus cursus urna ut tellus" },
            new Prescription_Medicament { IdMedicament = 17, IdPrescription = 1, Dose = 40, Details = "nam tristique tortor eu pede" },
            new Prescription_Medicament { IdMedicament = 4, IdPrescription = 8, Dose = 63, Details = "vestibulum ante ipsum primis in faucibus" },
            new Prescription_Medicament { IdMedicament = 4, IdPrescription = 16, Dose = 12, Details = "pede venenatis non sodales sed tincidunt eu felis fusce posuere" },
            new Prescription_Medicament { IdMedicament = 20, IdPrescription = 8, Dose = 28, Details = "vulputate ut ultrices vel augue vestibulum ante ipsum" },
            new Prescription_Medicament { IdMedicament = 4, IdPrescription = 9, Dose = 8, Details = "libero rutrum ac lobortis vel dapibus at diam nam tristique" },
            new Prescription_Medicament { IdMedicament = 9, IdPrescription = 19, Dose = 12, Details = "orci luctus et ultrices posuere cubilia curae" },
            new Prescription_Medicament { IdMedicament = 15, IdPrescription = 15, Dose = 37, Details = "erat quisque erat eros viverra eget congue eget semper rutrum" },
            new Prescription_Medicament { IdMedicament = 8, IdPrescription = 17, Dose = 8, Details = "sem sed sagittis nam congue risus semper porta" },
            new Prescription_Medicament { IdMedicament = 8, IdPrescription = 18, Dose = 20, Details = "et tempus semper est quam pharetra magna ac consequat" },
            new Prescription_Medicament { IdMedicament = 7, IdPrescription = 2, Dose = 22, Details = "non velit donec diam neque vestibulum eget" }
            );
        }
    }
}
