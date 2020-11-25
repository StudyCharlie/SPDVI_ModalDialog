using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalDialog
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void createNewDialogButton_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Age = int.Parse(ageTextBox.Text)
        };

            DetailsForm df = new DetailsForm(person);
            
            if(df.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("Dialog returned with OK");
            }
            else if(df.ShowDialog() == DialogResult.Cancel)
            {
                Console.WriteLine("Dialog returned with Cancel");
            }
            else
            {
                Console.WriteLine("Dialog returned " + df.ShowDialog());
            }
        }
    }
}
