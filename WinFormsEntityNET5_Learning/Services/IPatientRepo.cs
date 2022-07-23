using System.Collections.Generic;
using WinFormsEntityNET5_Learning.Models;

namespace WinFormsEntityNET5_Learning.Services
{
    public interface IPatientRepo
    {
        List<Patient> GetPatients();
        Patient GetPatient(int patientId);
        void AddPatient(Patient patient);
        void UpdatePatient(Patient patient);
        void DeletePatient(Patient patient);
    }
}