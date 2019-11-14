using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnTranslate_Click(object sender, EventArgs e)
        {
            string english = tbEnglish.Text;
            if(english.Length == 0)
            {
                tbTranslated.Text = "Error. Please enter something to translate.";
                return;
            }

            string response = "";
            if(rbPigLatin.Checked)
            {
                response = (new PigLatinTranslator()).Translate(english);
            }
            else
            {
                response = (new PigGreekTranslator()).Translate(english);
            }

            tbTranslated.Text = response;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            tbEnglish.Text = "";
            tbTranslated.Text = "";
            rbPigLatin.Checked = true;
        }

        private void RbPigLatin_CheckedChanged(object sender, EventArgs e)
        {
            lblTranslate.Text = "Pig Latin Translation:";
        }

        private void RbPigGreek_CheckedChanged(object sender, EventArgs e)
        {
            lblTranslate.Text = "Pig Greek Translation:";
        }
    }
}
