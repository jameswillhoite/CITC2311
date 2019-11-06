using System;
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
        protected MemoryCalculator calculator = new MemoryCalculator();

        protected bool clear = false;
        public frmCalculator()
        {
            InitializeComponent();
            this.calculator.ValueStoredInMemory += this.OnValueInMemory;
            this.calculator.ValueNotInMemory += this.OnValueNotInMemory;
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            //If a calculation has been preformed and user presses another digit, 
            //then clear the form
            if (clear)
            {
                this.ClearForm();
            }

            

            //Test to see if the "0" will be the first number, if so, don't write it
            //Just makes is 1 instead of 01
            if ((this.calculator.input + "0").IndexOf("0") > 0)
            {
                //Make sure the Text box is clear
                txtCurentValue.Text = "";

                //Add to the input
                this.calculator.input += "0";

                //Write out the current input
                txtCurentValue.Text = this.calculator.input;
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurentValue.Text = "";
            this.calculator.input += "1";
            txtCurentValue.Text = this.calculator.input;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurentValue.Text = "";
            this.calculator.input += "2";
            txtCurentValue.Text = this.calculator.input;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurentValue.Text = "";
            this.calculator.input += "3";
            txtCurentValue.Text = this.calculator.input;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurentValue.Text = "";
            this.calculator.input += "4";
            txtCurentValue.Text = this.calculator.input;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurentValue.Text = "";
            this.calculator.input += "5";
            txtCurentValue.Text = this.calculator.input;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurentValue.Text = "";
            this.calculator.input += "6";
            txtCurentValue.Text = this.calculator.input;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurentValue.Text = "";
            this.calculator.input += "7";
            txtCurentValue.Text = this.calculator.input;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurentValue.Text = "";
            this.calculator.input += "8";
            txtCurentValue.Text = this.calculator.input;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurentValue.Text = "";
            this.calculator.input += "9";
            txtCurentValue.Text = this.calculator.input;
        }

        private void BtnPeriod_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }

            if (this.calculator.input.Length == 0)
                this.calculator.input = "0";

            txtCurentValue.Text = "";

            //Look to see if there is already a period
            if (this.calculator.input.IndexOf(".") == -1)
                this.calculator.input += ".";

            txtCurentValue.Text = this.calculator.input;

        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            this.calculator.opperand1 = this.calculator.input;
            this.calculator.op = '+';
            this.calculator.input = string.Empty;
            clear = false; //Don't clear the form on the next number press
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            this.calculator.opperand2 = this.calculator.input;
            try
            {
                this.calculator.Calculate();
                txtCurentValue.Text = this.calculator.result.ToString();
            }
            catch(DivideByZeroException)
            {
                txtCurentValue.Text = "DIV/0!";
            }
            catch(OverflowException)
            {
                txtCurentValue.Text = "Overflow!";
            }
            catch(Exception)
            {
                txtCurentValue.Text = "ERROR!!";
            }

            clear = true; //Clear the form on the next number press
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            this.calculator.opperand1 = this.calculator.input;
            this.calculator.op = '-';
            this.calculator.input = string.Empty;
            
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            this.calculator.opperand1 = this.calculator.input;
            this.calculator.op = '*';
            this.calculator.input = string.Empty;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            this.calculator.opperand1 = this.calculator.input;
            this.calculator.op = '/';
            this.calculator.input = string.Empty;
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            txtCurentValue.Text = "";
            this.calculator.Sqrt();
            txtCurentValue.Text = this.calculator.input;

        }

        private void BtnReciproc_Click(object sender, EventArgs e)
        {
            txtCurentValue.Text = "";
            try
            {
                this.calculator.Reciproc();
                txtCurentValue.Text = this.calculator.input;
            }
            catch(DivideByZeroException)
            {
                txtCurentValue.Text = "DIV/0!";
            }
            catch(Exception)
            {
                txtCurentValue.Text = "ERROR!";
            }
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }

            //Clear the txt box
            txtCurentValue.Text = "";

            //Copy the current input
            string value = this.calculator.input;

            //Remove the current value
            this.calculator.input = string.Empty;

            //rebuild the string minus 1
            for(int i = 0; i < value.Length - 1; i++)
            {
                this.calculator.input += value[i];
            }

            //If the user has erased everything, then display zero
            if (this.calculator.input.Length == 0)
            {
                txtCurentValue.Text = "0";
            }
            else
            {
                //Write the value
                txtCurentValue.Text = this.calculator.input;
            }

            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void BtnPosMin_Click(object sender, EventArgs e)
        {
            txtCurentValue.Text = "";
            this.calculator.NegPos();
            txtCurentValue.Text = this.calculator.input;
        }

        private void ClearForm()
        {
            txtCurentValue.Text = "0";
            this.calculator.input = string.Empty;
            this.calculator.opperand1 = string.Empty;
            this.calculator.opperand2 = string.Empty;
            this.calculator.op = ' ';
            this.clear = false;
        }

        public void OnValueInMemory(object source, EventArgs args)
        {
            lblMemory.Text = "M";
        }

        public void OnValueNotInMemory(object source, EventArgs args)
        {
            lblMemory.Text = "";
        }

        private void BtnMC_Click(object sender, EventArgs e)
        {
            this.calculator.ClearMemory();
        }

        private void BtnMS_Click(object sender, EventArgs e)
        {
            this.calculator.SaveToMemory();
        }

        private void BtnMR_Click(object sender, EventArgs e)
        {
            this.calculator.RecallMemory();
            txtCurentValue.Text = this.calculator.input;
        }

        private void BtnMPlus_Click(object sender, EventArgs e)
        {
            this.calculator.AddToMemory();
        }
    }
}
