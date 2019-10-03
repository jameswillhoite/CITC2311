using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentScores
{
    public partial class frmAddNewStudent : Form
    {
        protected Student student = new Student();

        protected frmStudentScores form1;
        public frmAddNewStudent()
        {
            InitializeComponent();
        }

        public void setForm1(frmStudentScores form)
        {
            form1 = form;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void BtnAddScore_Click(object sender, EventArgs e)
        {
            int score;
            if(!int.TryParse(txtScore.Text, out score) || score < 0 || score > 100)
            {
                MessageBox.Show("Please Enter a Score between 0 and 100.", "Invalid Score");
                txtScore.Text = "";
                txtScore.Focus();
                return;
            }

            addScore(score);
            txtScore.Text = "";
            txtScore.Focus();
        }

        private void addScore(int score)
        {
            student.addScore(score);
            List<int> temp = new List<int>(0);
            for(int i = 0; i < student.scores.Count(); i++)
            {
                temp.Add(student.scores[i].score);
            }
            txtScores.Text = String.Join("|", temp.ToArray());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            student.scores.Clear();
            txtScores.Text = "";
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            //Check to make sure the name is okay
            Regex rx = new Regex(@"^[a-zA-Z\s]*$", RegexOptions.Compiled);
          
            if(!rx.IsMatch(txtName.Text))
            {
                MessageBox.Show("Invalid Characters for the name. Use [a-zA-Z] and space", "Invalid Name");
                txtName.Focus();
                return;
            }

            //Add the Name to the Student Object
            student.name = txtName.Text;

            //If all is okay, then add this student to the main form
            form1.addStudent(student);
            form1.Show();
            this.Close();
        }
    }
}
