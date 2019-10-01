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
        protected SortedList<int, Student> students = new SortedList<int, Student>(3);
        private int studentCount = 0;
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

        protected void addStudent(Student student)
        {
            students.Add(studentCount, student);

            lbxStudents.Items.Insert(studentCount, student);

            studentCount++;

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStudentScores_Load(object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.name = "John Smith";
            double[] scores = { 98, 58, 78 };
            student1.addScore(scores);
            addStudent(student1);

            Student student2 = new Student();
            student2.name = "Jane Smith";
            double[] scores2 = { 100, 100, 99 };
            student2.addScore(scores2);
            addStudent(student2);

            Student student3 = new Student();
            student3.name = "Bob Jones";
            double[] scores3 = { 38, 40, 15 };
            student3.addScore(scores3);
            addStudent(student3);
        }

        private void LbxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student;
            try
            {
                student = students[lbxStudents.SelectedIndex];
                //Sum up total Score
                double score_total = 0;
                int score_count = 0;
                double score_average = 0;
                foreach (double score in student.scores)
                {
                    score_total += score;
                    score_count++;
                }

                score_average = score_total / score_count;

                txtAverage.Text = String.Format("{0:F3}", score_average);
                txtScoreCount.Text = score_count.ToString();
                txtScoreTotal.Text = String.Format("{0:F0}" ,score_total);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Selected Student is out of Range.", "Out of range");
            }

            
        }
    }
}
