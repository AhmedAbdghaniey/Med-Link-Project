using Microsoft.EntityFrameworkCore;
using MidSpace.Data.Models;
using MidSpace.Data.Models.Appointments_Medical;
using MidSpace.Data.Models.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
      
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<JobOpportunity> jobOpportunities { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<DoctorJobRecommendation> DoctorJobRecommendations { get; set; }
      
        internal DbSet<Drug> Drugs { get; set; }
       
        internal DbSet<Appointment> Appointments { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<MedicalAttachment> MedicalAttachments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<PrescriptionItem> PrescriptionItems { get; set; }

        internal DbSet<DoctorRecommendation> DoctorRecommendations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=db47147.public.databaseasp.net;Initial Catalog=db47147;User Id=db47147;Password=7Qq_N@4o!eF2;Encrypt=False;");
        }


    }
}
