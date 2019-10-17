﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        protected Calculator calculator = new Calculator();
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtCurentValue.Text += "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtCurentValue.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtCurentValue.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtCurentValue.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtCurentValue.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtCurentValue.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtCurentValue.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtCurentValue.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtCurentValue.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtCurentValue.Text += "9";
        }

        private void BtnPeriod_Click(object sender, EventArgs e)
        {
            if(txtCurentValue.Text.IndexOf(".") == -1)
                txtCurentValue.Text += ".";
        }
    }
}
