using System.Collections.Generic;
using WinFormsEntityNET5_Learning.Models;

namespace WinFormsEntityNET5_Learning.Services
{
    public interface IPatientRepo
    {
        void DeletePatient(Patient patient);
        List<Patient> GetPatients();
    }
}