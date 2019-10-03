using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentScores
{
    public class Student
    {
        public string name = "";
        public List<StudentScore> scores = new List<StudentScore>(0);


        public void addScore(int score)
        {
            StudentScore Score = new StudentScore();
            Score.score = score;
            scores.Add(Score);
        }

        public void addScore(Array array_scores)
        {
            foreach (int score in array_scores)
            {
                StudentScore Score = new StudentScore();
                Score.score = score;
                scores.Add(Score);
            }
        }

        public void updateScore(int index, int score)
        {
            try
            {
                scores[index].score = score;
            } catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Could not update this Score.", "Not Found");
                return;
            }
        }

        public void removeScore(int index)
        {
            try
            {
                scores.RemoveAt(index);
            } catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Could not remove this score from " + name, "Unable to remove");
                return;
            }
        }

        public StudentScore getScore(int index)
        {
            try
            {
                return scores[index];
            } catch (KeyNotFoundException)
            {
                MessageBox.Show("Hmm, I can't find this Score", "Score not found");
                return new StudentScore();
            }
        }

        public override string ToString()
        {
            string text = name + " ";
            text += String.Join("|", scores);

            return text;
        }
    }
}
