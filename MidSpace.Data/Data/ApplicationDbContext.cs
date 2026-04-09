using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MidSpace.Data.Models;

namespace MidSpace.Data.Data
{
    internal class ApplicationDbContext : DbContext
    {
        DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; } 
        public DbSet<Doctor> Doctors { get; set; } 
        public DbSet<Patient> Patients { get; set; } 
        public DbSet<DoctorCertificate> DoctorCertificates { get; set; }
        public DbSet<DoctorAvailability> DoctorAvailabilities { get; set; } 
        public DbSet<PatientAllergy> PatientAllergies { get; set; } 
        public DbSet<PatientChronicDisease> PatientChronicDiseases { get; set; } 
        public DbSet<UserPhone> UserPhones { get; set; }
        public DbSet<Admin> Admins { get; set; }
        DbSet<Subscription> Subscriptions { get; set; }
        DbSet<Plan> Plans { get; set; }
        DbSet<PlanFeature> PlanFeatures { get; set; }
        DbSet<Payment> Payments { get; set; }
        DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=db47147.public.databaseasp.net;Initial Catalog=db47147;User Id=db47147;Password=7Qq_N@4o!eF2;Encrypt=False;");
        }
        

    }
}
