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
        public List<int> scores = new List<int>(0);

        public void addScore(int score)
        {
            scores.Add(score);
        }

        public void addScore(Array array_scores)
        {
            foreach(int score in array_scores)
            {
                scores.Add(score);
            }
        }

        public void updateScore(int index, int score)
        {
            try
            {
                scores[index] = score;
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
                scores.Remove(index);
            } catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Could not remove this score from " + name, "Unable to remove");
                return;
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
