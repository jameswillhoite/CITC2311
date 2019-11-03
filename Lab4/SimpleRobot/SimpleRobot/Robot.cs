using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRobot
{
    class Robot
    {
        private string direction = "N";

        private int x = 0;

        private int y = 0;

        private int max = 100;

        public string GetPosition { get { return "X=" + this.x + " , Y=" + this.y; } }

        public int GetX { get => x; }

        public int GetY { get => y; }


        public string Direction { get => direction; set => direction = value.ToUpper(); }

        public delegate void RobotMovedEventHandler(object source, EventArgs args);

        public event RobotMovedEventHandler RobotMoved;
        
        protected virtual void OnRobotMoved()
        {
            if (RobotMoved != null)
            {
                RobotMoved(this, EventArgs.Empty);
            }
        }

        public delegate void OutOfRangeEventHandler(object source, EventArgs args);

        public event OutOfRangeEventHandler OutOfRange;

        protected virtual void OnOutOfRange()
        {
            if (OutOfRange != null)
            {
                OutOfRange(this, EventArgs.Empty);
            }
        }

        public void Go1()
        {
            this.Move(this.direction, 1);
        }

        public void Go10()
        {
            this.Move(this.direction, 10);
        }

        private void Move(string Direction, int value)
        {
            switch (Direction)
            {
                case "N":
                    if (this.y + value > this.max)
                    {
                        OnOutOfRange();
                    }
                    else
                    {
                        this.y += value;
                        OnRobotMoved();
                    }
                    break;
                case "S":
                    if(this.y - value < (this.max * -1))
                    {
                        OnOutOfRange();
                    }
                    else
                    {
                        this.y -= value;
                        OnRobotMoved();
                    }
                    break;
                case "E":
                    if(this.x + value > this.max)
                    {
                        OnOutOfRange();
                    }
                    else
                    {
                        this.x += value;
                        OnRobotMoved();
                    }
                    break;
                case "W":
                    if(this.x - value < (this.max * -1))
                    {
                        OnOutOfRange();
                    }
                    else
                    {
                        this.x -= value;
                        OnRobotMoved();
                    }
                    break;
                default:
                    OnOutOfRange();
                    break;
            }
        }

    }
}
