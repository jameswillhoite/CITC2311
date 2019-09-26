using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadiumSeating
{
    public partial class frmStadiumSeating : Form
    {
        public frmStadiumSeating()
        {
            InitializeComponent();
        }

        private void BtnCalculateRevenue_Click(object sender, EventArgs e)
        {
            decimal costA = 15m;
            decimal costB = 12m;
            decimal costC = 9m;
            decimal total = 0m;

            int soldA = 0;
            int soldB = 0;
            int soldC = 0;

            try
            {
                //Make sure there is Valid Data entered in
                if (!int.TryParse(txtClassA_Sold.Text, out soldA) || soldA < 0)
                {
                    MessageBox.Show("Invalid amount sold for Class A", "Invalid Data");
                    txtClassA_Sold.Focus();
                    clearRevenue();
                    return;
                }
                if (!int.TryParse(txtClassB_Sold.Text, out soldB) || soldB < 0)
                {
                    MessageBox.Show("Invalid amount sold for Class B", "Invalid Data");
                    txtClassB_Sold.Focus();
                    clearRevenue();
                    return;
                }
                if (!int.TryParse(txtClassC_Sold.Text, out soldC) || soldC < 0)
                {
                    MessageBox.Show("Invlaid amount sold for Class C", "Invlaid Data");
                    txtClassC_Sold.Focus();
                    clearRevenue();
                    return;
                }
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("Seems that you entered invalid Data. Please correct and try again.", "Invalid Data");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("What did you Enter here? I've had a error. Please correct.", "Really Bad Error");
                return;
            }

            txtClassA_Revenue.Text = string.Format("{0:C}", (costA * soldA));
            total += costA * soldA;
            txtClassB_Revenue.Text = string.Format("{0:C}", (costB * soldB));
            total += costB * soldB;
            txtClassC_Revenue.Text = string.Format("{0:C}", (costC * soldC));
            total += costC * soldC;

            txtTotal_Revenue.Text = string.Format("{0:C}", total);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtClassA_Sold.Text = "";
            txtClassB_Sold.Text = "";
            txtClassC_Sold.Text = "";
            clearRevenue();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearRevenue()
        {
            txtClassA_Revenue.Text = "";
            txtClassB_Revenue.Text = "";
            txtClassC_Revenue.Text = "";
            txtTotal_Revenue.Text = "";
        }

        private void clearRevenue(object sender, EventArgs e)
        {
            clearRevenue();
        }
    }
}
