using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CatalogDataBase
{
    public partial class Form4 : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Albin\Desktop\Student Catalog\StudentCatalog.accdb"";";
        private DataTable studentCatalogTable;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            studentCatalogTable = new DataTable();

            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM StudentCatalog";

                using (var adapter = new OleDbDataAdapter(query, connection))
                {
                    adapter.Fill(studentCatalogTable);
                }
            }

            dataGridViewStudents.DataSource = studentCatalogTable;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        // Auto-generated code related to dataset and table adapters
        private void Form4_Load_1(object sender, EventArgs e)
        {
            this.studentCatalogTableAdapter1.Fill(this.studentCatalogDataSet2.StudentCatalog);
            this.studentCatalogTableAdapter.Fill(this.studentCatalogDataSet1.StudentCatalog);
        }
    }
}
