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

        protected Student update_student = new Student();
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
            //Make a new instance and copy
            update_student.name = student.name.ToString();

            this.student = student;
            txtName.Text = student.name;
            for(int i = 0; i < student.scores.Count(); i++)
            {
                lbxScores.Items.Add(student.scores[i].score);
                update_student.addScore(student.scores[i].score); //Copy this score to the copy
            }
           
            
        }

        public void addScore(int score)
        {
            update_student.addScore(score);
            lbxScores.Items.Add(score);
        }

        public void refreshScores()
        {
            lbxScores.Items.Clear();
            for(int i = 0; i < update_student.scores.Count(); i++)
            {
                lbxScores.Items.Add(update_student.scores[i].score);
            }
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
            this.student.name = this.update_student.name; //Copy this new object to the original
            this.student.scores.Clear();
            foreach(StudentScore score in this.update_student.scores)
            {
                this.student.addScore(score.score);
            }
            form1.refreshStudents();
            form1.Show();
            this.Close();
        }

        private void BtnClearScores_Click(object sender, EventArgs e)
        {
            var confirm_clear = MessageBox.Show("Are you sure you want to erase all scores for " + update_student.name + "?", "Delete Scores?", MessageBoxButtons.YesNo);
            if(confirm_clear == DialogResult.Yes)
            {
                update_student.scores.Clear();
                lbxScores.Items.Clear();
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                frmUpdateScore update = new frmUpdateScore();
                update.setUpdateForm(this);
                update.setStudent(this.update_student);
                update.setStudentScore(this.update_student.scores[lbxScores.SelectedIndex]);
                this.Hide();
                update.Show();
            } catch(KeyNotFoundException)
            {
                MessageBox.Show("Hmm.. Can seem to find this score.", "Warning");
                return;
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if(lbxScores.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a score to remove.");
                return;
            }
            StudentScore Score = this.update_student.scores[lbxScores.SelectedIndex];
            var confirmDelete = MessageBox.Show("Are you sure want to delete the score " + Score.score + " for " + update_student.name + "?", "Confirm Delete", MessageBoxButtons.YesNo);
            if(confirmDelete == DialogResult.Yes)
            {
                this.update_student.removeScore(lbxScores.SelectedIndex);
                this.refreshScores();
            }
        }
    }
}
