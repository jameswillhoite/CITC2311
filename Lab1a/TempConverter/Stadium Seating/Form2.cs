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
    public partial class frmStadiumSeating : Form
    {
        public frmStadiumSeating()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtClassA_Sold.Text = "";
            txtClassB_Sold.Text = "";
            txtClassC_Sold.Text = "";
            clearRevenue();

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

            //Make sure there is Valid Data entered in
            if(int.TryParse(txtClassA_Sold.Text, out soldA))
            {
                MessageBox.Show("Invalid amount sold for Class A", "Invalid Data");
                txtClassA_Sold.Focus();
                clearRevenue();
                return;
            }
            if(int.TryParse(txtClassB_Sold.Text, out soldB))
            {
                MessageBox.Show("Invalid amount sold for Class B", "Invalid Data");
                txtClassB_Sold.Focus();
                clearRevenue();
                return;
            }
            if(int.TryParse(txtClassC_Sold.Text, out soldC))
            {
                MessageBox.Show("Invlaid amount sold for Class C", "Invlaid Data");
                txtClassC_Sold.Focus();
                clearRevenue();
                return;
            }

            txtClassA_Revenue.Text = (costA * soldA).ToString();
            total += costA * soldA;
            txtClassB_Revenue.Text = (costB * soldB).ToString();
            total += costB * soldB;
            txtClassC_Revenue.Text = (costC * soldC).ToString();
            total += costC * soldB;

            txtTotal_Revenue.Text = total.ToString();

        }

        private void clearRevenue()
        {
            txtClassA_Revenue.Text = "";
            txtClassB_Revenue.Text = "";
            txtClassC_Revenue.Text = "";
            txtTotal_Revenue.Text = "";
        }
    }
}
