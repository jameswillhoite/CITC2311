using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleRobot
{
    public partial class frmSimpleRobot : Form
    {
        private Robot robot = new Robot();

        public frmSimpleRobot()
        {
            InitializeComponent();
            this.robot.RobotMoved += this.OnRobotMoved;
            this.robot.OutOfRange += this.OnRobotOutOfRange;
            SetDirection("N");
            //Center the Robot
            lblRobot.Left = pnlMain.Width / 2;
            lblRobot.Top = pnlMain.Height / 2;

            //Display the Starting position
            lblXY.Text = this.robot.GetPosition;
        }

        public void OnRobotMoved(object source, EventArgs args)
        {
            lblXY.Text = this.robot.GetPosition;
            
            //Get the "0,0" of the panel
            int x = pnlMain.Width / 2;
            int y = pnlMain.Height / 2;

            x += this.robot.GetX;
            y += (this.robot.GetY * -1);

            lblRobot.Left = x;
            lblRobot.Top = y;

        }

        public void OnRobotOutOfRange(object source, EventArgs args)
        {
            MessageBox.Show("Robot cannot move that direction. Out of Range. Try a different direction.", "Out Of Moves");
        }

        private void SetDirection(string Direction)
        {
            int d = 233;
            switch(Direction)
            {
                case "N":
                    d = 233;
                    break;
                case "S":
                    d = 234;
                    break;
                case "E":
                    d = 232;
                    break;
                case "W":
                    d = 231;
                    break;
            }

            lblRobot.Text = ((Char)d).ToString();
        }

        private void BtnNorth_Click(object sender, EventArgs e)
        {
            this.robot.Direction = "N";
            SetDirection("N");
        }

        private void BtnWest_Click(object sender, EventArgs e)
        {
            this.robot.Direction = "W";
            SetDirection("W");
        }

        private void BtnEast_Click(object sender, EventArgs e)
        {
            this.robot.Direction = "E";
            SetDirection("E");
        }

        private void BtnSouth_Click(object sender, EventArgs e)
        {
            this.robot.Direction = "S";
            SetDirection("S");
        }

        private void BtnGo1_Click(object sender, EventArgs e)
        {
            this.robot.Go1();
        }

        private void BtnGo10_Click(object sender, EventArgs e)
        {
            this.robot.Go10();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
