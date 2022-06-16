using Microsoft.EntityFrameworkCore;
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
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Study> Studies { get; set; }
        public DataContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConfigurationManager.ConnectionStrings["PSQL"].ConnectionString);
            //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["LocalDb"].ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Данные для таблиц
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
