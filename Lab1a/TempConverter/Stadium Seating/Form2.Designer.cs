namespace Stadium_Seating
{
    partial class frmStadiumSeating
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClassC_Sold = new System.Windows.Forms.TextBox();
            this.txtClassB_Sold = new System.Windows.Forms.TextBox();
            this.txtClassA_Sold = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotal_Revenue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClassC_Revenue = new System.Windows.Forms.TextBox();
            this.txtClassB_Revenue = new System.Windows.Forms.TextBox();
            this.txtClassA_Revenue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculateRevenue = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClassC_Sold);
            this.groupBox1.Controls.Add(this.txtClassB_Sold);
            this.groupBox1.Controls.Add(this.txtClassA_Sold);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // txtClassC_Sold
            // 
            this.txtClassC_Sold.Location = new System.Drawing.Point(91, 125);
            this.txtClassC_Sold.Name = "txtClassC_Sold";
            this.txtClassC_Sold.Size = new System.Drawing.Size(100, 20);
            this.txtClassC_Sold.TabIndex = 7;
            // 
            // txtClassB_Sold
            // 
            this.txtClassB_Sold.Location = new System.Drawing.Point(91, 96);
            this.txtClassB_Sold.Name = "txtClassB_Sold";
            this.txtClassB_Sold.Size = new System.Drawing.Size(100, 20);
            this.txtClassB_Sold.TabIndex = 2;
            // 
            // txtClassA_Sold
            // 
            this.txtClassA_Sold.Location = new System.Drawing.Point(91, 64);
            this.txtClassA_Sold.Name = "txtClassA_Sold";
            this.txtClassA_Sold.Size = new System.Drawing.Size(100, 20);
            this.txtClassA_Sold.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Class C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Class B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class A:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotal_Revenue);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtClassC_Revenue);
            this.groupBox2.Controls.Add(this.txtClassB_Revenue);
            this.groupBox2.Controls.Add(this.txtClassA_Revenue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(278, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 187);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            // 
            // txtTotal_Revenue
            // 
            this.txtTotal_Revenue.Location = new System.Drawing.Point(92, 125);
            this.txtTotal_Revenue.Name = "txtTotal_Revenue";
            this.txtTotal_Revenue.ReadOnly = true;
            this.txtTotal_Revenue.Size = new System.Drawing.Size(100, 20);
            this.txtTotal_Revenue.TabIndex = 9;
            this.txtTotal_Revenue.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total:";
            // 
            // txtClassC_Revenue
            // 
            this.txtClassC_Revenue.Location = new System.Drawing.Point(92, 92);
            this.txtClassC_Revenue.Name = "txtClassC_Revenue";
            this.txtClassC_Revenue.ReadOnly = true;
            this.txtClassC_Revenue.Size = new System.Drawing.Size(100, 20);
            this.txtClassC_Revenue.TabIndex = 7;
            this.txtClassC_Revenue.TabStop = false;
            // 
            // txtClassB_Revenue
            // 
            this.txtClassB_Revenue.Location = new System.Drawing.Point(92, 63);
            this.txtClassB_Revenue.Name = "txtClassB_Revenue";
            this.txtClassB_Revenue.ReadOnly = true;
            this.txtClassB_Revenue.Size = new System.Drawing.Size(100, 20);
            this.txtClassB_Revenue.TabIndex = 5;
            this.txtClassB_Revenue.TabStop = false;
            // 
            // txtClassA_Revenue
            // 
            this.txtClassA_Revenue.Location = new System.Drawing.Point(92, 31);
            this.txtClassA_Revenue.Name = "txtClassA_Revenue";
            this.txtClassA_Revenue.ReadOnly = true;
            this.txtClassA_Revenue.Size = new System.Drawing.Size(100, 20);
            this.txtClassA_Revenue.TabIndex = 4;
            this.txtClassA_Revenue.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Class C:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Class B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Class A:";
            // 
            // btnCalculateRevenue
            // 
            this.btnCalculateRevenue.Location = new System.Drawing.Point(84, 284);
            this.btnCalculateRevenue.Name = "btnCalculateRevenue";
            this.btnCalculateRevenue.Size = new System.Drawing.Size(100, 66);
            this.btnCalculateRevenue.TabIndex = 4;
            this.btnCalculateRevenue.Text = "&Calculate Revenue";
            this.btnCalculateRevenue.UseVisualStyleBackColor = true;
            this.btnCalculateRevenue.Click += new System.EventHandler(this.BtnCalculateRevenue_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(213, 284);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 66);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(342, 284);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 66);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmStadiumSeating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 387);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateRevenue);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStadiumSeating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stadium Seating";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClassC_Sold;
        private System.Windows.Forms.TextBox txtClassB_Sold;
        private System.Windows.Forms.TextBox txtClassA_Sold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotal_Revenue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClassC_Revenue;
        private System.Windows.Forms.TextBox txtClassB_Revenue;
        private System.Windows.Forms.TextBox txtClassA_Revenue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculateRevenue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}