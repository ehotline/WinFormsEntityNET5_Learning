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
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.LastNameTB = new System.Windows.Forms.RichTextBox();
            this.FirstNameTB = new System.Windows.Forms.RichTextBox();
            this.AgeTB = new System.Windows.Forms.RichTextBox();
            this.MainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 3;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainLayout.Controls.Add(this.AgeTB, 1, 2);
            this.MainLayout.Controls.Add(this.FirstNameTB, 1, 0);
            this.MainLayout.Controls.Add(this.AgeLbl, 0, 2);
            this.MainLayout.Controls.Add(this.LastNameLbl, 0, 1);
            this.MainLayout.Controls.Add(this.FirstNameLbl, 0, 0);
            this.MainLayout.Controls.Add(this.LastNameTB, 1, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 4;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.Size = new System.Drawing.Size(441, 391);
            this.MainLayout.TabIndex = 0;
            this.MainLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.MainLayout_Paint);
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
            // LastNameTB
            // 
            this.LastNameTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastNameTB.Location = new System.Drawing.Point(153, 53);
            this.LastNameTB.Multiline = false;
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(244, 44);
            this.LastNameTB.TabIndex = 4;
            this.LastNameTB.Text = "";
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstNameTB.Location = new System.Drawing.Point(153, 3);
            this.FirstNameTB.Multiline = false;
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(244, 44);
            this.FirstNameTB.TabIndex = 5;
            this.FirstNameTB.Text = "";
            // 
            // AgeTB
            // 
            this.AgeTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgeTB.Location = new System.Drawing.Point(153, 103);
            this.AgeTB.Multiline = false;
            this.AgeTB.Name = "AgeTB";
            this.AgeTB.Size = new System.Drawing.Size(244, 44);
            this.AgeTB.TabIndex = 6;
            this.AgeTB.Text = "";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 391);
            this.Controls.Add(this.MainLayout);
            this.Name = "PatientForm";
            this.Text = "Пациент";
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
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
    }
}