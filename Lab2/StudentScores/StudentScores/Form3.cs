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
    public partial class frmUpdateStudentScores : Form
    {
        protected frmStudentScores form1;

        protected Student student;
        public frmUpdateStudentScores()
        {
            InitializeComponent();
        }

        public void setStudentScoresForm(frmStudentScores form)
        {
            form1 = form;
        }

        public void setStudent(Student student)
        {
            this.student = student;
            txtName.Text = student.name;
            foreach(int score in student.scores)
            {
                lbxScores.Items.Add(score);
            }
            
        }

        public void addScore(int score)
        {
            student.addScore(score);
            lbxScores.Items.Add(score);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frmAddScore add = new frmAddScore();
            add.setUpdateForm(this);
            add.Show();
            this.Hide();
        }

        private void BtnOkay_Click(object sender, EventArgs e)
        {
            form1.refreshStudents();
            form1.Show();
            this.Close();
        }

        private void BtnClearScores_Click(object sender, EventArgs e)
        {
            var confirm_clear = MessageBox.Show("Are you sure you want to erase all scores for " + student.name + "?", "Delete Scores?", MessageBoxButtons.YesNo);
            if(confirm_clear == DialogResult.Yes)
            {
                student.scores.Clear();
                lbxScores.Items.Clear();
            }

        }
    }
}
