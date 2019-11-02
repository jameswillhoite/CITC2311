namespace SimpleRobot
{
    partial class frmSimpleRobot
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
            this.lblXY = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnGo1 = new System.Windows.Forms.Button();
            this.btnGo10 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblXY
            // 
            this.lblXY.AutoSize = true;
            this.lblXY.Location = new System.Drawing.Point(13, 13);
            this.lblXY.Name = "lblXY";
            this.lblXY.Size = new System.Drawing.Size(35, 13);
            this.lblXY.TabIndex = 0;
            this.lblXY.Text = "label1";
            // 
            // pnlMain
            // 
            this.pnlMain.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(16, 30);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(277, 308);
            this.pnlMain.TabIndex = 1;
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(129, 354);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(35, 23);
            this.btnNorth.TabIndex = 1;
            this.btnNorth.Text = "N";
            this.btnNorth.UseVisualStyleBackColor = true;
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(129, 417);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(35, 23);
            this.btnSouth.TabIndex = 2;
            this.btnSouth.Text = "S";
            this.btnSouth.UseVisualStyleBackColor = true;
            // 
            // btnEast
            // 
            this.btnEast.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEast.Location = new System.Drawing.Point(166, 386);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(35, 23);
            this.btnEast.TabIndex = 3;
            this.btnEast.Text = "E";
            this.btnEast.UseVisualStyleBackColor = true;
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(88, 386);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(35, 23);
            this.btnWest.TabIndex = 4;
            this.btnWest.Text = "W";
            this.btnWest.UseVisualStyleBackColor = true;
            // 
            // btnGo1
            // 
            this.btnGo1.Location = new System.Drawing.Point(12, 386);
            this.btnGo1.Name = "btnGo1";
            this.btnGo1.Size = new System.Drawing.Size(56, 23);
            this.btnGo1.TabIndex = 5;
            this.btnGo1.Text = "Go 1";
            this.btnGo1.UseVisualStyleBackColor = true;
            // 
            // btnGo10
            // 
            this.btnGo10.Location = new System.Drawing.Point(222, 386);
            this.btnGo10.Name = "btnGo10";
            this.btnGo10.Size = new System.Drawing.Size(60, 23);
            this.btnGo10.TabIndex = 6;
            this.btnGo10.Text = "Go 10";
            this.btnGo10.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(218, 445);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmSimpleRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(305, 480);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGo10);
            this.Controls.Add(this.btnGo1);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblXY);
            this.Name = "frmSimpleRobot";
            this.Text = "Simple Robot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXY;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnGo1;
        private System.Windows.Forms.Button btnGo10;
        private System.Windows.Forms.Button btnExit;
    }
}

