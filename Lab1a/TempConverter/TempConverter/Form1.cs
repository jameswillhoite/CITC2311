using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverter
{
    public partial class TemperatureConverter : Form
    {
       
        public TemperatureConverter()
        {
            InitializeComponent();
        }

       

        private void BtnFahrenheit_Click(object sender, EventArgs e)
        {
            try
            {
                decimal celsius = 0m;
                //Make sure the user entered a number and not text
                if(!decimal.TryParse(txtTemperature.Text, out celsius))
                {
                    MessageBox.Show("Not a valid Temperature", "Invalid");
                    txtTemperature.Text = "";
                    txtConversion.Text = "";
                    txtTemperature.Focus();
                    return;
                }



                txtConversion.Text = ((celsius * 9/5) + 32).ToString();
                
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Divide By Zero!", "Error");
                return;
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("Here an Arithmetic Exception Occured", "Error");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Here somehting Bad happened here.", "Exception");
                return;
            }

        }

        private void BtnCelsius_Click(object sender, EventArgs e)
        {
            try
            {
                decimal fahrenheit = 0m;
                //Make sure the user entered a number and not text
                if (!decimal.TryParse(txtTemperature.Text, out fahrenheit))
                {
                    MessageBox.Show("Not a valid Temperature", "Invalid");
                    txtTemperature.Text = "";
                    txtConversion.Text = "";
                    txtTemperature.Focus();
                    return;
                }



                txtConversion.Text = ((fahrenheit - 32) *  5 / 9).ToString();

            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Divide By Zero!", "Error");
                return;
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("Here an Arithmetic Exception Occured", "Error");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Here somehting Bad happened here.", "Exception");
                return;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtConversion.Text = "";
            txtTemperature.Text = "";
        }
    }
}
