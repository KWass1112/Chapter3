using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMixItUp_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(txtNumber1.Text) - Convert.ToDouble(txtNumber2.Text);

            lblResult.Text = "The " + txtColor.Text + " dragon is the " + txtWordEndingInEst.Text + " dragon of all. It has "
                + num + " " + txtBodyPartPlural.Text + ", and a "
                + txtAnimal.Text + " shapped like a " + txtNoun.Text + ", although it will feast on nearly anything.";
        }

    }
}
