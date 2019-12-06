using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void techniciansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!this.ValidateFields())
                return;
            this.Validate();
            this.techniciansBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.techSupportDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techSupportDataSet.Technicians' table. You can move, or remove it, as needed.
            this.techniciansTableAdapter.Fill(this.techSupportDataSet.Technicians);

        }

        protected bool ValidateFields()
        {
            // Name 50
            if(nameTextBox.Text.Length > 50)
            {
                MessageBox.Show("The name is too long. Please enter only up to 50 characters");
                return false;
            }

            // email 50
            if(emailTextBox.Text.Length > 50)
            {
                MessageBox.Show("The email address is too long. Please enter only up to 50 characters");
                return false;
            }
            // phone 20
            if(phoneTextBox.Text.Length > 20)
            {
                MessageBox.Show("The phone number is too long. Please only enter up to 20 characters");
                return false;
            }

            return true;
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
