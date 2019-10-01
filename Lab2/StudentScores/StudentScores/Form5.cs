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

        //TODO: Possibly create Class for Score ????

        public frmUpdateScore()
        {
            InitializeComponent();
        }

        public void setUpdateForm(frmUpdateStudentScores update)
        {
            this.update = update;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
