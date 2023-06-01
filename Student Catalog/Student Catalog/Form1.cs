using Student_Catalog;
using System;
using System.Windows.Forms;

namespace CatalogDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Open Form2 for adding a student
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // Open Form3 for removing a student by first name and last name
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void buttonCatalog_Click(object sender, EventArgs e)
        {
            // Open Form4 to display the student catalog
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
