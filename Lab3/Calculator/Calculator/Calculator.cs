using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        protected decimal currentValue = 0m;
        protected decimal opperand1 = 0m;
        protected decimal opperand2 = 0m;
        protected string op = "";

        public decimal CurrentValue { get; } = 0m;

        public void Add()
        {
            decimal value = this.opperand1 + this.opperand2;
            this.currentValue = value;
        }

        public void Sub(decimal value)
        {
            this.currentValue -= value;
        }

        public void Multiply(decimal value)
        {
            this.currentValue *= value;
        }

        public void Divide()
        {

            decimal value = this.opperand1 / this.opperand2;
            this.opperand1 = value;
            this.currentValue = value;
            this.op = "";
        }

        public void Calculate()
        {
            switch(this.op)
            {
                case "+":
                    this.Add();
                    break;

            }

            this.opperand1 = this.currentValue;
            this.op = "";
        }

        public decimal GetCurrentValue()
        {
            return this.currentValue;
        }

        public void setOperator(string op)
        {
            this.op = op;
        }

        public bool setNumber(string number)
        {
            decimal num;
            if(!decimal.TryParse(number, out num))
            {
                return false;
            }

            if (this.opperand1 != 0)
            {
                this.opperand2 = num;
            }
            else
                this.opperand1 = num;

            return true;

        }
    }
}
