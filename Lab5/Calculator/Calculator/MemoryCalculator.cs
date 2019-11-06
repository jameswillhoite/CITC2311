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

        public delegate void MemoryCalculatorEventHandler(object source, EventArgs args);

        public event MemoryCalculatorEventHandler ValueStoredInMemory;

        public delegate void NotInMemoryCalculatorEventHandler(object source, EventArgs args);

        public event NotInMemoryCalculatorEventHandler ValueNotInMemory;

        protected virtual void OnValueInMemory()
        {
            if ( ValueStoredInMemory != null)
            {
                ValueStoredInMemory(this, EventArgs.Empty);
            }
        }

        protected virtual void OnValueNotInMemory()
        {
            if ( ValueNotInMemory != null)
            {
                ValueNotInMemory(this, EventArgs.Empty);
            }
        }
        public void SaveToMemory()
        {
            double num;

            double.TryParse(this.input, out num);
            this.memory = num;

            this.OnValueInMemory();
        }

        public void AddToMemory()
        {
            double num;

            double.TryParse(this.input, out num);
            this.memory += num;

            this.OnValueInMemory();
        }

        public void ClearMemory()
        {
            this.memory = 0.0;
            this.OnValueNotInMemory();
        }

        public void RecallMemory()
        {
            this.input = this.memory.ToString();
        }
    }
}
