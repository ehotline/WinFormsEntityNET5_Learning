using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WinFormsEntityNET5_Learning.Models;

namespace WinFormsEntityNET5_Learning.Services
{
    public class PatientRepo : IPatientRepo
    {
        private IDbContextFactory<DataContext> _contextFactory;

        public PatientRepo(IDbContextFactory<DataContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public List<Patient> GetPatients()
        {
            using var db = _contextFactory.CreateDbContext();
            return db.Patients.OrderBy(p => p.Id).ToList();
        }

        public void DeletePatient(Patient deletingPatient)
        {
            using var db = _contextFactory.CreateDbContext();
            var patient = db.Patients.FirstOrDefault(b => b.Id == deletingPatient.Id);
            if (patient == null)
            {
                throw new PatientRepoException($"Не найден пациент {deletingPatient}", deletingPatient);
            }
            db.Patients.Remove(patient);
            db.SaveChanges();
        }
    }
}
