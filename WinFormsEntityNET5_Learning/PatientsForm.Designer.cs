namespace WinFormsEntityNET5_Learning
{
    partial class PatientsForm
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
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PatientsGV = new System.Windows.Forms.DataGridView();
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.DeletePatientButton = new System.Windows.Forms.Button();
            this.MainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.52937F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.47063F));
            this.MainLayout.Controls.Add(this.PatientsGV, 1, 0);
            this.MainLayout.Controls.Add(this.AddPatientButton, 0, 0);
            this.MainLayout.Controls.Add(this.DeletePatientButton, 0, 1);
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.Padding = new System.Windows.Forms.Padding(5);
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Size = new System.Drawing.Size(1277, 662);
            this.MainLayout.TabIndex = 0;
            // 
            // PatientsGV
            // 
            this.PatientsGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsGV.Location = new System.Drawing.Point(166, 8);
            this.PatientsGV.Name = "PatientsGV";
            this.PatientsGV.RowHeadersWidth = 51;
            this.MainLayout.SetRowSpan(this.PatientsGV, 3);
            this.PatientsGV.RowTemplate.Height = 29;
            this.PatientsGV.Size = new System.Drawing.Size(1103, 646);
            this.PatientsGV.TabIndex = 0;
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPatientButton.Location = new System.Drawing.Point(8, 8);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.Size = new System.Drawing.Size(152, 44);
            this.AddPatientButton.TabIndex = 1;
            this.AddPatientButton.Text = "Добавить";
            this.AddPatientButton.UseVisualStyleBackColor = true;
            // 
            // DeletePatientButton
            // 
            this.DeletePatientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePatientButton.Location = new System.Drawing.Point(8, 58);
            this.DeletePatientButton.Name = "DeletePatientButton";
            this.DeletePatientButton.Size = new System.Drawing.Size(152, 44);
            this.DeletePatientButton.TabIndex = 2;
            this.DeletePatientButton.Text = "Удалить";
            this.DeletePatientButton.UseVisualStyleBackColor = true;
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1277, 662);
            this.Controls.Add(this.MainLayout);
            this.Name = "PatientsForm";
            this.Text = "Форма пациентов";
            this.MainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.DataGridView PatientsGV;
        private System.Windows.Forms.Button AddPatientButton;
        private System.Windows.Forms.Button DeletePatientButton;
    }
}