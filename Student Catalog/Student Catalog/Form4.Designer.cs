using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CatalogDataBase
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewStudents;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentCatalogDataSet1 = new Student_Catalog.StudentCatalogDataSet1();
            this.studentCatalogTableAdapter = new Student_Catalog.StudentCatalogDataSet1TableAdapters.StudentCatalogTableAdapter();
            this.studentCatalogDataSet2 = new Student_Catalog.StudentCatalogDataSet2();
            this.studentCatalogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentCatalogTableAdapter1 = new Student_Catalog.StudentCatalogDataSet2TableAdapters.StudentCatalogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCatalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCatalogDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCatalogDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCatalogBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonMenu.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonMenu.TabIndex = 0;
            this.buttonMenu.Text = "Back";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.AutoGenerateColumns = false;
            this.dataGridViewStudents.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridViewStudents.DataSource = this.studentCatalogBindingSource1;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(776, 397);
            this.dataGridViewStudents.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 160;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.Width = 80;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 191;
            // 
            // studentCatalogBindingSource
            // 
            this.studentCatalogBindingSource.DataMember = "StudentCatalog";
            this.studentCatalogBindingSource.DataSource = this.studentCatalogDataSet1;
            // 
            // studentCatalogDataSet1
            // 
            this.studentCatalogDataSet1.DataSetName = "StudentCatalogDataSet1";
            this.studentCatalogDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentCatalogTableAdapter
            // 
            this.studentCatalogTableAdapter.ClearBeforeFill = true;
            // 
            // studentCatalogDataSet2
            // 
            this.studentCatalogDataSet2.DataSetName = "StudentCatalogDataSet2";
            this.studentCatalogDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentCatalogBindingSource1
            // 
            this.studentCatalogBindingSource1.DataMember = "StudentCatalog";
            this.studentCatalogBindingSource1.DataSource = this.studentCatalogDataSet2;
            // 
            // studentCatalogTableAdapter1
            // 
            this.studentCatalogTableAdapter1.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.buttonMenu);
            this.Name = "Form4";
            this.Text = "Student Catalog";
            this.Load += new System.EventHandler(this.Form4_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCatalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCatalogDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCatalogDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCatalogBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonMenu;
        private Student_Catalog.StudentCatalogDataSet1 studentCatalogDataSet1;
        private BindingSource studentCatalogBindingSource;
        private Student_Catalog.StudentCatalogDataSet1TableAdapters.StudentCatalogTableAdapter studentCatalogTableAdapter;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private Student_Catalog.StudentCatalogDataSet2 studentCatalogDataSet2;
        private BindingSource studentCatalogBindingSource1;
        private Student_Catalog.StudentCatalogDataSet2TableAdapters.StudentCatalogTableAdapter studentCatalogTableAdapter1;
    }
}