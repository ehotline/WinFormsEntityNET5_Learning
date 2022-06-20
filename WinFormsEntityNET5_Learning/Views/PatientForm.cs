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
    public partial class PatientForm : Form
    {
        //DataContext m_Context;
        Patient m_Patient;
        PatientFormMode m_Mode;
        bool m_ResetBtnVisibility
        {
            set
            {
                ResetBtn.Visible = value;
            }
        }
        public PatientForm(PatientFormMode mode, int? patientId)//DataContext context, )
        {
            //m_Context = context;
            m_Mode = mode;
            InitializeComponent();
            if (mode == PatientFormMode.Edit && null != patientId)
            {
                //m_Patient = m_Context.Patients.Find(patientId);
                m_ResetBtnVisibility = true;
            }
            else
            {
                m_Patient = new Patient();
                m_ResetBtnVisibility = false;
            }
            PatientBindingSource.DataSource = m_Patient;
        }

        private void PatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //m_Context.SaveChanges();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (m_Mode == PatientFormMode.Create)
            {
               // m_Context.Patients.Add(m_Patient);
                //m_Context.SaveChanges();
            }
            this.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            //m_Patient = m_Context.Patients.Find(m_Patient.Id);
        }
    }
}
