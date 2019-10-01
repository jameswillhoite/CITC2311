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
        public List<double> scores = new List<double>(0);

        public void addScore(double score)
        {
            scores.Add(score);
        }

        public void addScore(Array array_scores)
        {
            foreach(double score in array_scores)
            {
                scores.Add(score);
            }
        }

        public void updateScore(int index, double score)
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
            foreach(double score in scores)
            {
                text += "|" + score;
            }

            return text;
        }
    }
}
