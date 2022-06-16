namespace WinFormsEntityNET5_Learning.Views
{
    partial class PatientsBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DeletePatientBtn = new System.Windows.Forms.Button();
            this.EditPatientBtn = new System.Windows.Forms.Button();
            this.PatientsDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CreatePatientBtn = new System.Windows.Forms.Button();
            this.PatientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainLayout.Controls.Add(this.DeletePatientBtn, 0, 2);
            this.MainLayout.Controls.Add(this.EditPatientBtn, 0, 1);
            this.MainLayout.Controls.Add(this.PatientsDGV, 1, 0);
            this.MainLayout.Controls.Add(this.CreatePatientBtn, 0, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 4;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.Size = new System.Drawing.Size(982, 553);
            this.MainLayout.TabIndex = 0;
            // 
            // DeletePatientBtn
            // 
            this.DeletePatientBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeletePatientBtn.Location = new System.Drawing.Point(5, 105);
            this.DeletePatientBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DeletePatientBtn.Name = "DeletePatientBtn";
            this.DeletePatientBtn.Size = new System.Drawing.Size(190, 40);
            this.DeletePatientBtn.TabIndex = 3;
            this.DeletePatientBtn.Text = "Удалить";
            this.DeletePatientBtn.UseVisualStyleBackColor = true;
            this.DeletePatientBtn.Click += new System.EventHandler(this.DeletePatientBtn_Click);
            // 
            // EditPatientBtn
            // 
            this.EditPatientBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditPatientBtn.Location = new System.Drawing.Point(5, 55);
            this.EditPatientBtn.Margin = new System.Windows.Forms.Padding(5);
            this.EditPatientBtn.Name = "EditPatientBtn";
            this.EditPatientBtn.Size = new System.Drawing.Size(190, 40);
            this.EditPatientBtn.TabIndex = 2;
            this.EditPatientBtn.Text = "Изменить";
            this.EditPatientBtn.UseVisualStyleBackColor = true;
            this.EditPatientBtn.Click += new System.EventHandler(this.EditPatientBtn_Click);
            // 
            // PatientsDGV
            // 
            this.PatientsDGV.AutoGenerateColumns = false;
            this.PatientsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.Age});
            this.PatientsDGV.DataSource = this.PatientBindingSource;
            this.PatientsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientsDGV.Location = new System.Drawing.Point(203, 3);
            this.PatientsDGV.MultiSelect = false;
            this.PatientsDGV.Name = "PatientsDGV";
            this.PatientsDGV.ReadOnly = true;
            this.PatientsDGV.RowHeadersWidth = 51;
            this.MainLayout.SetRowSpan(this.PatientsDGV, 4);
            this.PatientsDGV.RowTemplate.Height = 29;
            this.PatientsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientsDGV.Size = new System.Drawing.Size(776, 547);
            this.PatientsDGV.TabIndex = 0;
            this.PatientsDGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PatientsDGV_CellMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // PatientBindingSource
            // 
            this.PatientBindingSource.DataSource = typeof(WinFormsEntityNET5_Learning.Models.Patient);
            // 
            // CreatePatientBtn
            // 
            this.CreatePatientBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreatePatientBtn.Location = new System.Drawing.Point(5, 5);
            this.CreatePatientBtn.Margin = new System.Windows.Forms.Padding(5);
            this.CreatePatientBtn.Name = "CreatePatientBtn";
            this.CreatePatientBtn.Size = new System.Drawing.Size(190, 40);
            this.CreatePatientBtn.TabIndex = 1;
            this.CreatePatientBtn.Text = "Создать";
            this.CreatePatientBtn.UseVisualStyleBackColor = true;
            this.CreatePatientBtn.Click += new System.EventHandler(this.CreatePatientBtn_Click);
            // 
            // PatientsBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.MainLayout);
            this.Name = "PatientsBrowser";
            this.Text = "Список пациентов";
            this.MainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.DataGridView PatientsDGV;
        private System.Windows.Forms.Button DeletePatientBtn;
        private System.Windows.Forms.Button EditPatientBtn;
        private System.Windows.Forms.Button CreatePatientBtn;
        private System.Windows.Forms.BindingSource PatientsBindingSource;
        private System.Windows.Forms.BindingSource PatientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
    }
}