using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CatalogDataBase
{
    public partial class Form2 : Form
    {
        // Establishing a connection to the DataBase
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Albin\Desktop\Student Catalog\StudentCatalog.accdb"";";

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            // Get the student details from text boxes
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            string studentClass = textBoxClass.Text;
            string email = textBoxEmail.Text;

            // Insert the student into the DataBase
            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                var query = $"INSERT INTO StudentCatalog ([First Name], [Last Name], [Phone Number], [Class], [Email]) " +
                            $"VALUES ('{firstName}', '{lastName}', '{phoneNumber}', '{studentClass}', '{email}')";

                using (var command = new OleDbCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            // Clear the text boxes
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNumber.Clear();
            textBoxClass.Clear();
            textBoxEmail.Clear();

            MessageBox.Show("Student added successfully!");
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            // Go back to Form1 (start screen)
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}

