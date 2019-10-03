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
    public partial class frmUpdateScore : Form
    {
        protected frmUpdateStudentScores update;

        protected Student student;

        protected StudentScore Score;

        //TODO: Possibly create Class for Score ????

        public frmUpdateScore()
        {
            InitializeComponent();
        }

        public void setUpdateForm(frmUpdateStudentScores update)
        {
            this.update = update;
        }

        public void setStudent(Student student)
        {
            this.student = student;
        }

        public void setStudentScore(StudentScore Score)
        {
            this.Score = Score;
            txtScore.Text = Score.score.ToString();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.update.Show();
            this.Close();
           
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int score;
            if(!int.TryParse(txtScore.Text, out score) || score < 0 || score > 100)
            {
                MessageBox.Show("Please enter a Valid Score between 0 and 100.", "Invalid Score");
                return;
            }

            this.Score.score = score;
            this.update.refreshScores();
            this.update.Show();
            this.Close();
        }
    }
}
