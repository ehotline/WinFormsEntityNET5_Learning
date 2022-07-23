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
using WinFormsEntityNET5_Learning.Services;

namespace WinFormsEntityNET5_Learning.Views
{
    public partial class PatientForm : Form
    {
        IPatientRepo _patientRepo;
        Patient patient;
        PatientFormMode _mode;
        bool m_ResetBtnVisibility
        {
            set
            {
                ResetBtn.Visible = value;
            }
        }
        public PatientForm(IPatientRepo patientRepo, PatientFormMode mode, int? patientId)
        {
            _patientRepo = patientRepo;
            _mode = mode;
            InitializeComponent();
            if (mode == PatientFormMode.Edit && null != patientId)
            {
                patient = _patientRepo.GetPatient((int)patientId);
                m_ResetBtnVisibility = true;
            }
            else
            {
                patient = new Patient();
                m_ResetBtnVisibility = false;
            }
            PatientBindingSource.DataSource = patient;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (_mode == PatientFormMode.Create)
            {
                _patientRepo.AddPatient(patient);
            }
            else if (_mode == PatientFormMode.Edit)
            {
                _patientRepo.UpdatePatient(patient);
            }
            this.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            patient = _patientRepo.GetPatient(patient.Id);
        }
    }
}
