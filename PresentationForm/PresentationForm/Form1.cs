using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChallengeOne_Click(object sender, EventArgs e)
        {
            //Reversing a string. Challenge One.
            ReverseString swap = new ReverseString();
            lblDescription.Text = swap.description;
            txtOutput.Text = swap.Reverse(txtInput.Text);
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
        }

        private void btnChallengeTwo_Click(object sender, EventArgs e)
        {

        }
    }
}
