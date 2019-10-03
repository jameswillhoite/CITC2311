using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace StudentScores
{
    public partial class frmStudentScores : Form
    {
        /*
         * Define Variables to be used
         */
        protected List<Student> students = new List<Student>(0);

        public frmStudentScores()
        {
            InitializeComponent();
           
        }


        protected void clearForm()
        {
            txtAverage.Text = "";
            txtScoreCount.Text = "";
            txtScoreTotal.Text = "";
        }

        public void addStudent(Student student)
        {
            students.Add(student);

            lbxStudents.Items.Add(student);

        }

        public void refreshStudents()
        {
            lbxStudents.Items.Clear();
            for (int i = 0; i < students.Count(); i++)
            {
                lbxStudents.Items.Add(students[i]);
            }


            lbxStudents.SelectedIndex = -1;
            txtAverage.Text = "";
            txtScoreCount.Text = "";
            txtScoreTotal.Text = "";
        }

        private void FrmStudentScores_Load(object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.name = "John Smith";
            int[] scores = { 98, 58, 78 };
            student1.addScore(scores);
            addStudent(student1);

            Student student2 = new Student();
            student2.name = "Jane Smith";
            int[] scores2 = { 100, 100, 99 };
            student2.addScore(scores2);
            addStudent(student2);

            Student student3 = new Student();
            student3.name = "Bob Jones";
            int[] scores3 = { 38, 40, 15 };
            student3.addScore(scores3);
            addStudent(student3);
        }

        private void LbxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student;

            //Check to see if the index is -1
            if(lbxStudents.SelectedIndex == -1)
            {
                txtAverage.Text = "";
                txtScoreCount.Text = "";
                txtScoreTotal.Text = "";
                return;
            }
            try
            {
                student = students[lbxStudents.SelectedIndex];
                //Sum up total Score
                int score_total = 0;
                int score_count = 0;
                double score_average = 0;
                for(int i = 0; i < student.scores.Count(); i++)
                {
                    score_count++;
                    score_total += student.scores[i].score;
                }
               
                if (score_count > 0)
                {
                    score_average = score_total / score_count;
                }

                txtAverage.Text = String.Format("{0:F0}", score_average);
                txtScoreCount.Text = score_count.ToString();
                txtScoreTotal.Text = String.Format("{0:F0}" ,score_total);
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Selected Student is out of Range.", "Out of range");
            }

            
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewStudent frmNewStudent = new frmAddNewStudent();
            frmNewStudent.setForm1(this);
            frmNewStudent.Show();
            this.Hide();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //Check to see if the User selected a Student
            if(lbxStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Student First.", "Select Student");
                return;
            }
            Student student = students[lbxStudents.SelectedIndex];

            var confirmDelete = MessageBox.Show("Are you sure you want to Delete Student " + student.name + "?", "Delete?", MessageBoxButtons.YesNo);
            if(confirmDelete == DialogResult.No)
            {
                return;
            }

            students.RemoveAt(lbxStudents.SelectedIndex);
            lbxStudents.Items.RemoveAt(lbxStudents.SelectedIndex);
            lbxStudents.SelectedIndex = -1;
            this.refreshStudents();
                       
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //Make sure the User has selected a student
            if(lbxStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student.", "Select Student");
                return;
            }

            Student student = students[lbxStudents.SelectedIndex];
            frmUpdateStudentScores update = new frmUpdateStudentScores();
            update.setStudent(student);
            update.setStudentScoresForm(this);
            update.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
