using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CatalogDataBase
{
    public partial class Form3 : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Albin\Desktop\Student Catalog\StudentCatalog.accdb"";";

        public Form3()
        {
            InitializeComponent();
        }

        private void buttonRemoveStudent_Click(object sender, EventArgs e)
        {
            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbTransaction transaction = null;

                try
                {
                    // Begin a transaction
                    transaction = connection.BeginTransaction();

                    // Construct the query to delete the student from the database
                    string query = "DELETE FROM StudentCatalog WHERE [First Name] = @FirstName";
                    using (var command = new OleDbCommand(query, connection))
                    {
                        command.Transaction = transaction;
                        command.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Clear the text box
                            textBoxFirstName.Clear();
                            // Commit the transaction
                            transaction.Commit();
                            MessageBox.Show("Student successfully removed.");
                        }
                        else
                        {
                            // Rollback the transaction
                            transaction.Rollback();
                            MessageBox.Show("No student found with the given name in the catalog.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                        transaction.Rollback();

                    MessageBox.Show("An error occurred while removing the student: " + ex.Message);
                }
                finally
                {
                    if (transaction != null)
                        transaction.Dispose();

                    connection.Close();
                }
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
