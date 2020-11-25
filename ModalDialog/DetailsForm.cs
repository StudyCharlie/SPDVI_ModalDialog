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
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }

        // Constructor who pass a string to the DetailsForm.
        public DetailsForm(string message)
        {
            InitializeComponent();
            textBox1.AppendText(message + Environment.NewLine);
        }

        // Constructor who pass a entire personModel data to the DetailsForm.
        public DetailsForm(PersonModel personData)
        {
            InitializeComponent();
            textBox1.AppendText($"{personData.FirstName}, {personData.LastName} is {personData.Age} years old ");
        }
    }
}
