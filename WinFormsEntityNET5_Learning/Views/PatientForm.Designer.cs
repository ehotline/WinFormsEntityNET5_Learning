namespace WinFormsEntityNET5_Learning.Views
{
    partial class PatientForm
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
            this.ResetBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.AgeTB = new System.Windows.Forms.RichTextBox();
            this.PatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FirstNameTB = new System.Windows.Forms.RichTextBox();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.LastNameTB = new System.Windows.Forms.RichTextBox();
            this.MainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 3;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.Controls.Add(this.ResetBtn, 1, 4);
            this.MainLayout.Controls.Add(this.OkBtn, 2, 4);
            this.MainLayout.Controls.Add(this.AgeTB, 1, 2);
            this.MainLayout.Controls.Add(this.FirstNameTB, 1, 0);
            this.MainLayout.Controls.Add(this.AgeLbl, 0, 2);
            this.MainLayout.Controls.Add(this.LastNameLbl, 0, 1);
            this.MainLayout.Controls.Add(this.FirstNameLbl, 0, 0);
            this.MainLayout.Controls.Add(this.LastNameTB, 1, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 5;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainLayout.Size = new System.Drawing.Size(489, 397);
            this.MainLayout.TabIndex = 0;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetBtn.Location = new System.Drawing.Point(155, 352);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(159, 40);
            this.ResetBtn.TabIndex = 4;
            this.ResetBtn.Text = "Сбросить";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OkBtn.Location = new System.Drawing.Point(324, 352);
            this.OkBtn.Margin = new System.Windows.Forms.Padding(5);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(160, 40);
            this.OkBtn.TabIndex = 3;
            this.OkBtn.Text = "Ок";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // AgeTB
            // 
            this.MainLayout.SetColumnSpan(this.AgeTB, 2);
            this.AgeTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PatientBindingSource, "Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AgeTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgeTB.Location = new System.Drawing.Point(153, 103);
            this.AgeTB.Multiline = false;
            this.AgeTB.Name = "AgeTB";
            this.AgeTB.Size = new System.Drawing.Size(333, 44);
            this.AgeTB.TabIndex = 2;
            this.AgeTB.Text = "";
            // 
            // PatientBindingSource
            // 
            this.PatientBindingSource.DataSource = typeof(WinFormsEntityNET5_Learning.Models.Patient);
            // 
            // FirstNameTB
            // 
            this.MainLayout.SetColumnSpan(this.FirstNameTB, 2);
            this.FirstNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PatientBindingSource, "FirstName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FirstNameTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstNameTB.Location = new System.Drawing.Point(153, 3);
            this.FirstNameTB.Multiline = false;
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(333, 44);
            this.FirstNameTB.TabIndex = 0;
            this.FirstNameTB.Text = "";
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgeLbl.Location = new System.Drawing.Point(5, 105);
            this.AgeLbl.Margin = new System.Windows.Forms.Padding(5);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Padding = new System.Windows.Forms.Padding(5);
            this.AgeLbl.Size = new System.Drawing.Size(140, 40);
            this.AgeLbl.TabIndex = 2;
            this.AgeLbl.Text = "Возраст";
            this.AgeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastNameLbl.Location = new System.Drawing.Point(5, 55);
            this.LastNameLbl.Margin = new System.Windows.Forms.Padding(5);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Padding = new System.Windows.Forms.Padding(5);
            this.LastNameLbl.Size = new System.Drawing.Size(140, 40);
            this.LastNameLbl.TabIndex = 1;
            this.LastNameLbl.Text = "Фамилия";
            this.LastNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstNameLbl.Location = new System.Drawing.Point(5, 5);
            this.FirstNameLbl.Margin = new System.Windows.Forms.Padding(5);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Padding = new System.Windows.Forms.Padding(5);
            this.FirstNameLbl.Size = new System.Drawing.Size(140, 40);
            this.FirstNameLbl.TabIndex = 0;
            this.FirstNameLbl.Text = "Имя";
            this.FirstNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LastNameTB
            // 
            this.MainLayout.SetColumnSpan(this.LastNameTB, 2);
            this.LastNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PatientBindingSource, "LastName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LastNameTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastNameTB.Location = new System.Drawing.Point(153, 53);
            this.LastNameTB.Multiline = false;
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(333, 44);
            this.LastNameTB.TabIndex = 1;
            this.LastNameTB.Text = "";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 397);
            this.Controls.Add(this.MainLayout);
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пациент";
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.RichTextBox AgeTB;
        private System.Windows.Forms.RichTextBox FirstNameTB;
        private System.Windows.Forms.RichTextBox LastNameTB;
        private System.Windows.Forms.BindingSource PatientBindingSource;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button OkBtn;
    }
}