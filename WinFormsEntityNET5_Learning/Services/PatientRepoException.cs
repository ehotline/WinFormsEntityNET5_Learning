using System;
using WinFormsEntityNET5_Learning.Models;

namespace WinFormsEntityNET5_Learning.Services
{
    public class PatientRepoException : Exception
    {
        public Patient Patient { get; }

        public PatientRepoException(string message, Patient patient)
                : base(message)
        {
            Patient = patient;
        }
    }
}