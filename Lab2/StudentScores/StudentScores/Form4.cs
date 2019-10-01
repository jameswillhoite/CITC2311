using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentScores
{
    public partial class frmAddScore : Form
    {
        frmUpdateStudentScores update;

        public frmAddScore()
        {
            InitializeComponent();
        }

        public void setUpdateForm(frmUpdateStudentScores update)
        {
            this.update = update;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            update.Show();
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int score = -1;
            //Make sure the User Entered a Valid Score
            if(!int.TryParse(txtScore.Text, out score) || score < 0 || score > 100)
            {
                MessageBox.Show("Please enter a valid score between 0 and 100", "Invalid Score");
                return;
            }

            update.addScore(score);
            txtScore.Text = "";
            txtScore.Focus();
        }
    }
}
