using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsEntityNET5_Learning.Models;

namespace WinFormsEntityNET5_Learning.Views
{
    public partial class PatientsBrowser : Form
    {
        DataContext m_Context;
        List<Patient> m_Patients
        {
            get
            {
                return m_Context.Patients.OrderBy(p => p.Id).ToList();
            }
        }
        Patient? m_SelectedPatient
        {
            get { return null != PatientsDGV.CurrentRow ? (Patient)PatientsDGV.CurrentRow.DataBoundItem : null; }
        }
        public PatientsBrowser(DataContext context)
        {
            m_Context = context;
            m_Context.Patients.Load();
            InitializeComponent();
            PatientsDGV.DataSource = m_Patients;
        }

        private void OpenPatientWindow(PatientFormMode mode)
        {
            var patientForm = new PatientForm(m_Context, mode, m_SelectedPatient?.Id);
            
            patientForm.ShowDialog();
            switch(mode)
            {
                case PatientFormMode.Edit:
                    RefreshPatientsDGV(m_SelectedPatient?.Id);
                    break;
                case PatientFormMode.Create:
                    RefreshPatientsDGV(null);
                    break;
            }
        }
        private void RefreshPatientsDGV(int? selectedId)
        {
            PatientsDGV.DataSource = null;
            PatientsDGV.DataSource = m_Patients;
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
            if (null == m_SelectedPatient) return;
            int selectedId = m_SelectedPatient.Id;
            m_Context.Patients.Remove(m_SelectedPatient);
            m_Context.SaveChanges();
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
