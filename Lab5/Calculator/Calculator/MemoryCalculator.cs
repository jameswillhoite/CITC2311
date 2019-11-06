using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MemoryCalculator : Calculator
    {
        public double memory = 0.0;
        public void SaveToMemory()
        {
            double num;

            double.TryParse(this.input, out num);
            this.memory = num;
        }

        public void AddToMemory()
        {
            double num;

            double.TryParse(this.input, out num);
            this.memory += num;
        }

        public void ClearMemory()
        {
            this.memory = 0.0;
        }

        public void RecallMemory()
        {
            this.input = this.memory.ToString();
        }
    }
}
