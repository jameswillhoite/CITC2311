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

        public void Add(decimal value)
        {
            this.currentValue += value;
        }

        public void Sub(decimal value)
        {
            this.currentValue -= value;
        }

        public void Multiply(decimal value)
        {
            this.currentValue *= value;
        }

        public void Divide(decimal value)
        {
            this.currentValue /= value;
        }
    }
}
