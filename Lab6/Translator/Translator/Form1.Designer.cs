namespace Translator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEnterText = new System.Windows.Forms.Label();
            this.tbEnglish = new System.Windows.Forms.TextBox();
            this.rbPigLatin = new System.Windows.Forms.RadioButton();
            this.rbPigGreek = new System.Windows.Forms.RadioButton();
            this.tbTranslated = new System.Windows.Forms.TextBox();
            this.lblTranslate = new System.Windows.Forms.Label();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterText
            // 
            this.lblEnterText.AutoSize = true;
            this.lblEnterText.Location = new System.Drawing.Point(13, 13);
            this.lblEnterText.Name = "lblEnterText";
            this.lblEnterText.Size = new System.Drawing.Size(116, 13);
            this.lblEnterText.TabIndex = 0;
            this.lblEnterText.Text = "Enter English text here:";
            // 
            // tbEnglish
            // 
            this.tbEnglish.Location = new System.Drawing.Point(16, 30);
            this.tbEnglish.Multiline = true;
            this.tbEnglish.Name = "tbEnglish";
            this.tbEnglish.Size = new System.Drawing.Size(354, 130);
            this.tbEnglish.TabIndex = 1;
            // 
            // rbPigLatin
            // 
            this.rbPigLatin.AutoSize = true;
            this.rbPigLatin.Checked = true;
            this.rbPigLatin.Location = new System.Drawing.Point(16, 187);
            this.rbPigLatin.Name = "rbPigLatin";
            this.rbPigLatin.Size = new System.Drawing.Size(66, 17);
            this.rbPigLatin.TabIndex = 2;
            this.rbPigLatin.TabStop = true;
            this.rbPigLatin.Text = "Pig &Latin";
            this.rbPigLatin.UseVisualStyleBackColor = true;
            this.rbPigLatin.CheckedChanged += new System.EventHandler(this.RbPigLatin_CheckedChanged);
            // 
            // rbPigGreek
            // 
            this.rbPigGreek.AutoSize = true;
            this.rbPigGreek.Location = new System.Drawing.Point(108, 187);
            this.rbPigGreek.Name = "rbPigGreek";
            this.rbPigGreek.Size = new System.Drawing.Size(72, 17);
            this.rbPigGreek.TabIndex = 3;
            this.rbPigGreek.Text = "Pig &Greek";
            this.rbPigGreek.UseVisualStyleBackColor = true;
            this.rbPigGreek.CheckedChanged += new System.EventHandler(this.RbPigGreek_CheckedChanged);
            // 
            // tbTranslated
            // 
            this.tbTranslated.Location = new System.Drawing.Point(16, 228);
            this.tbTranslated.Multiline = true;
            this.tbTranslated.Name = "tbTranslated";
            this.tbTranslated.ReadOnly = true;
            this.tbTranslated.Size = new System.Drawing.Size(354, 172);
            this.tbTranslated.TabIndex = 4;
            // 
            // lblTranslate
            // 
            this.lblTranslate.AutoSize = true;
            this.lblTranslate.Location = new System.Drawing.Point(13, 212);
            this.lblTranslate.Name = "lblTranslate";
            this.lblTranslate.Size = new System.Drawing.Size(106, 13);
            this.lblTranslate.TabIndex = 5;
            this.lblTranslate.Text = "Pig Latin Translation:";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(16, 418);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 5;
            this.btnTranslate.Text = "&Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.BtnTranslate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(98, 418);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(295, 418);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnTranslate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(382, 459);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.lblTranslate);
            this.Controls.Add(this.tbTranslated);
            this.Controls.Add(this.rbPigGreek);
            this.Controls.Add(this.rbPigLatin);
            this.Controls.Add(this.tbEnglish);
            this.Controls.Add(this.lblEnterText);
            this.Name = "frmMain";
            this.Text = "Pig Latin & Greek Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterText;
        private System.Windows.Forms.TextBox tbEnglish;
        private System.Windows.Forms.RadioButton rbPigLatin;
        private System.Windows.Forms.RadioButton rbPigGreek;
        private System.Windows.Forms.TextBox tbTranslated;
        private System.Windows.Forms.Label lblTranslate;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

