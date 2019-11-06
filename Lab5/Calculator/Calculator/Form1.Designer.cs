namespace Calculator
{
    partial class frmCalculator
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
            this.txtCurentValue = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnReciproc = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPosMin = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.pnlMemory = new System.Windows.Forms.Panel();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.lblMemory = new System.Windows.Forms.Label();
            this.pnlMemory.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCurentValue
            // 
            this.txtCurentValue.Location = new System.Drawing.Point(17, 14);
            this.txtCurentValue.Multiline = true;
            this.txtCurentValue.Name = "txtCurentValue";
            this.txtCurentValue.ReadOnly = true;
            this.txtCurentValue.Size = new System.Drawing.Size(246, 29);
            this.txtCurentValue.TabIndex = 0;
            this.txtCurentValue.TabStop = false;
            this.txtCurentValue.Text = "0";
            this.txtCurentValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(59, 53);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(158, 53);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 35);
            this.btnClear.TabIndex = 2;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btn7
            // 
            this.btn7.ForeColor = System.Drawing.Color.Blue;
            this.btn7.Location = new System.Drawing.Point(59, 94);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(36, 26);
            this.btn7.TabIndex = 3;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // btn8
            // 
            this.btn8.ForeColor = System.Drawing.Color.Blue;
            this.btn8.Location = new System.Drawing.Point(101, 94);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(36, 26);
            this.btn8.TabIndex = 4;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btn9
            // 
            this.btn9.ForeColor = System.Drawing.Color.Blue;
            this.btn9.Location = new System.Drawing.Point(143, 94);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(36, 26);
            this.btn9.TabIndex = 5;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.ForeColor = System.Drawing.Color.Red;
            this.btnDivide.Location = new System.Drawing.Point(185, 94);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(36, 26);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.TabStop = false;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // btn4
            // 
            this.btn4.ForeColor = System.Drawing.Color.Blue;
            this.btn4.Location = new System.Drawing.Point(59, 126);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(36, 26);
            this.btn4.TabIndex = 7;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn5
            // 
            this.btn5.ForeColor = System.Drawing.Color.Blue;
            this.btn5.Location = new System.Drawing.Point(101, 126);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(36, 26);
            this.btn5.TabIndex = 8;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn6
            // 
            this.btn6.ForeColor = System.Drawing.Color.Blue;
            this.btn6.Location = new System.Drawing.Point(143, 126);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(36, 26);
            this.btn6.TabIndex = 9;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.ForeColor = System.Drawing.Color.Red;
            this.btnMultiply.Location = new System.Drawing.Point(185, 126);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(36, 26);
            this.btnMultiply.TabIndex = 10;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // btn1
            // 
            this.btn1.ForeColor = System.Drawing.Color.Blue;
            this.btn1.Location = new System.Drawing.Point(59, 158);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(36, 26);
            this.btn1.TabIndex = 11;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn2
            // 
            this.btn2.ForeColor = System.Drawing.Color.Blue;
            this.btn2.Location = new System.Drawing.Point(101, 158);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(36, 26);
            this.btn2.TabIndex = 12;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn3
            // 
            this.btn3.ForeColor = System.Drawing.Color.Blue;
            this.btn3.Location = new System.Drawing.Point(143, 158);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(36, 26);
            this.btn3.TabIndex = 13;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.ForeColor = System.Drawing.Color.Red;
            this.btnMinus.Location = new System.Drawing.Point(185, 158);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(36, 26);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.TabStop = false;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // btn0
            // 
            this.btn0.ForeColor = System.Drawing.Color.Blue;
            this.btn0.Location = new System.Drawing.Point(59, 190);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(36, 26);
            this.btn0.TabIndex = 15;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.ForeColor = System.Drawing.Color.Red;
            this.btnPlus.Location = new System.Drawing.Point(185, 190);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(36, 26);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.TabStop = false;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.ForeColor = System.Drawing.Color.Blue;
            this.btnSqrt.Location = new System.Drawing.Point(227, 94);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(36, 26);
            this.btnSqrt.TabIndex = 17;
            this.btnSqrt.TabStop = false;
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.BtnSqrt_Click);
            // 
            // btnReciproc
            // 
            this.btnReciproc.ForeColor = System.Drawing.Color.Blue;
            this.btnReciproc.Location = new System.Drawing.Point(227, 126);
            this.btnReciproc.Name = "btnReciproc";
            this.btnReciproc.Size = new System.Drawing.Size(36, 26);
            this.btnReciproc.TabIndex = 18;
            this.btnReciproc.TabStop = false;
            this.btnReciproc.Text = "1/X";
            this.btnReciproc.UseVisualStyleBackColor = true;
            this.btnReciproc.Click += new System.EventHandler(this.BtnReciproc_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.ForeColor = System.Drawing.Color.Red;
            this.btnEqual.Location = new System.Drawing.Point(227, 158);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(36, 58);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.TabStop = false;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // btnPosMin
            // 
            this.btnPosMin.ForeColor = System.Drawing.Color.Blue;
            this.btnPosMin.Location = new System.Drawing.Point(101, 190);
            this.btnPosMin.Name = "btnPosMin";
            this.btnPosMin.Size = new System.Drawing.Size(36, 26);
            this.btnPosMin.TabIndex = 20;
            this.btnPosMin.TabStop = false;
            this.btnPosMin.Text = "+/-";
            this.btnPosMin.UseVisualStyleBackColor = true;
            this.btnPosMin.Click += new System.EventHandler(this.BtnPosMin_Click);
            // 
            // btnPeriod
            // 
            this.btnPeriod.ForeColor = System.Drawing.Color.Blue;
            this.btnPeriod.Location = new System.Drawing.Point(143, 190);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(36, 26);
            this.btnPeriod.TabIndex = 21;
            this.btnPeriod.TabStop = false;
            this.btnPeriod.Text = ".";
            this.btnPeriod.UseVisualStyleBackColor = true;
            this.btnPeriod.Click += new System.EventHandler(this.BtnPeriod_Click);
            // 
            // pnlMemory
            // 
            this.pnlMemory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMemory.Controls.Add(this.lblMemory);
            this.pnlMemory.Location = new System.Drawing.Point(17, 53);
            this.pnlMemory.Name = "pnlMemory";
            this.pnlMemory.Size = new System.Drawing.Size(36, 35);
            this.pnlMemory.TabIndex = 22;
            // 
            // btnMC
            // 
            this.btnMC.ForeColor = System.Drawing.Color.Red;
            this.btnMC.Location = new System.Drawing.Point(17, 94);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(36, 26);
            this.btnMC.TabIndex = 23;
            this.btnMC.TabStop = false;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.BtnMC_Click);
            // 
            // btnMR
            // 
            this.btnMR.ForeColor = System.Drawing.Color.Red;
            this.btnMR.Location = new System.Drawing.Point(17, 126);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(36, 26);
            this.btnMR.TabIndex = 24;
            this.btnMR.TabStop = false;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.BtnMR_Click);
            // 
            // btnMS
            // 
            this.btnMS.ForeColor = System.Drawing.Color.Red;
            this.btnMS.Location = new System.Drawing.Point(17, 158);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(36, 26);
            this.btnMS.TabIndex = 25;
            this.btnMS.TabStop = false;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.BtnMS_Click);
            // 
            // btnMPlus
            // 
            this.btnMPlus.ForeColor = System.Drawing.Color.Red;
            this.btnMPlus.Location = new System.Drawing.Point(17, 190);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(36, 26);
            this.btnMPlus.TabIndex = 26;
            this.btnMPlus.TabStop = false;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = true;
            this.btnMPlus.Click += new System.EventHandler(this.BtnMPlus_Click);
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Location = new System.Drawing.Point(9, 10);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(0, 13);
            this.lblMemory.TabIndex = 27;
            // 
            // frmCalculator
            // 
            this.AcceptButton = this.btnEqual;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(275, 228);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.pnlMemory);
            this.Controls.Add(this.btnPeriod);
            this.Controls.Add(this.btnPosMin);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnReciproc);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtCurentValue);
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.FrmCalculator_Load);
            this.pnlMemory.ResumeLayout(false);
            this.pnlMemory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurentValue;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnReciproc;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPosMin;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Panel pnlMemory;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Label lblMemory;
    }
}

