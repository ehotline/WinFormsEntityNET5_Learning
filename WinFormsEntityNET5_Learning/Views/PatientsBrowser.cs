using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinFormsEntityNET5_Learning.Models;
using WinFormsEntityNET5_Learning.Services;

namespace WinFormsEntityNET5_Learning.Views
{
    public partial class PatientsBrowser : Form
    {
        private IPatientRepo _patientRepo;

        List<Patient> patients
        {
            get
            {
                return _patientRepo.GetPatients();
            }
        }
        Patient? selectedPatient
        {
            get { return null != PatientsDGV.CurrentRow ? (Patient)PatientsDGV.CurrentRow.DataBoundItem : null; }
        }
        public PatientsBrowser(IPatientRepo patientRepo)
        {
            _patientRepo = patientRepo;

            InitializeComponent();
            PatientsDGV.DataSource = patients;
        }

        private void OpenPatientWindow(PatientFormMode mode)
        {
            var patientForm = new PatientForm(_patientRepo, mode, selectedPatient?.Id);

            patientForm.ShowDialog();
            switch (mode)
            {
                case PatientFormMode.Edit:
                    RefreshPatientsDGV(selectedPatient?.Id);
                    break;
                case PatientFormMode.Create:
                    RefreshPatientsDGV(null);
                    break;
            }
        }
        private void RefreshPatientsDGV(int? selectedId)
        {
            PatientsDGV.DataSource = null;
            PatientsDGV.DataSource = patients;
            //Сохраняем выбранную строку после перезагрузки данных
            if (null != selectedId)
            {
                var row = PatientsDGV.Rows
                            .Cast<DataGridViewRow>()
                            .Where(r => r.Cells[$"{nameof(Patient.Id)}"].Value.Equals(selectedId))
                            .FirstOrDefault();
                if (null != row)
                {
                    PatientsDGV.Rows[row.Index].Selected = true;
                }
            }
            else
            {
                PatientsDGV.Rows[PatientsDGV.Rows.Count - 1].Selected = true;
            }
        }
        private void DeletePatient()
        {
            if (null == selectedPatient) return;
            int selectedId = selectedPatient.Id;

            _patientRepo.DeletePatient(selectedPatient);

            RefreshPatientsDGV(selectedId + 1);
        }

        #region Control Events
        private void PatientsDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OpenPatientWindow(PatientFormMode.Edit);
        }
        private void CreatePatientBtn_Click(object sender, EventArgs e)
        {
            OpenPatientWindow(PatientFormMode.Create);
        }
        private void EditPatientBtn_Click(object sender, EventArgs e)
        {
            OpenPatientWindow(PatientFormMode.Edit);
        }
        private void DeletePatientBtn_Click(object sender, EventArgs e)
        {
            DeletePatient();
        }
        #endregion
    }
}
