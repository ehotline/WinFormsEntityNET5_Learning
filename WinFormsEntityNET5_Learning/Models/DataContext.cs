using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsEntityNET5_Learning.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Username=postgres;Password=2486;Database=EntityLearning");
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Study> Studies { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Protocol> Protocols { get; set; }
        public DbSet<Sequence> Sequences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Данные для таблиц
            modelBuilder.Entity<Region>().HasData(new Region[]
            {
                new Region { Id = 1, Title = "Регион" }
            });
            modelBuilder.Entity<Serie>().HasData(new Serie[]
            {
                new Serie { Id = 1, StudyId = 1, RegionId = 1, Title = "Последовательность", Time = TimeSpan.Parse("00:06") }
            });
            modelBuilder.Entity<Study>().HasData(new Study[]
            {
                new Study { Id = 1, PatientId = 1, StudyDate = DateTime.Now },
                new Study { Id = 2, PatientId = 1, StudyDate = DateTime.Now.AddDays(-56) },
                new Study { Id = 3, PatientId = 2, StudyDate = DateTime.Now.AddDays(-3) },
                new Study { Id = 4, PatientId = 3, StudyDate = DateTime.Now },
                new Study { Id = 5, PatientId = 4, StudyDate = DateTime.Now.AddDays(-12) },
                new Study { Id = 6, PatientId = 4, StudyDate = DateTime.Now.AddDays(-27) }
            });
            modelBuilder.Entity<Patient>().HasData(new Patient[]
            {
                new Patient { Id = 1, FirstName = "Сергей", LastName = "Иванов", Age = 25 },
                new Patient { Id = 2, FirstName = "Андрей", LastName = "Петров", Age = 43 },
                new Patient { Id = 3, FirstName = "Виталий", LastName = "Пугачёв" },
                new Patient { Id = 4, FirstName = "Ирина", LastName = "Романова", Age = 34 }
            });
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}
