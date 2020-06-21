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

        }
    }
}
