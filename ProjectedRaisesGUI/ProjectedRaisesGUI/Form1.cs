﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double salary;
            double increase = 1.4;
            double nextYearsSalary;

            salary = Convert.ToDouble(txtSalary.Text);

            nextYearsSalary = salary * increase;

            lblNextYearsSalary.Text = "Next years salary will be: " + nextYearsSalary;
        }
    }
}
