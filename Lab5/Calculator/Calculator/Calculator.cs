using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public string input = "";
        public string opperand1 = "0";
        public string opperand2 = "0";
        public char op;
        public double result = 0.0;


        public void Calculate()
        {
            double num1;
            double num2;

            double.TryParse(opperand1, out num1);
            double.TryParse(opperand2, out num2);

            if (op == '+')
            {
                result = num1 + num2;
                input = result.ToString();
            }
            else if (op == '-')
            {
                result = num1 - num2;
                input = result.ToString();
            }
            else if (op == '*')
            {
                result = num1 * num2;
                input = result.ToString();
            }
            else if (op == '/')
            {
                if(num2 != 0)
                {
                    result = num1 / num2;
                    input = result.ToString();
                }
                else
                {
                    throw new DivideByZeroException();
                }
            }
        }

        public void Sqrt()
        {
            double num1;
            double.TryParse(input, out num1);
            result = Math.Sqrt(num1);
            input = result.ToString();
        }

        public void Reciproc()
        {
            double num1;
            double.TryParse(input, out num1);

            if (num1 != 0)
            {
                result = 1 / num1;
                input = result.ToString();
            }
            else
            {
                input = string.Empty;
                throw new DivideByZeroException();
            }
        }

        public void NegPos()
        {
            double num1;
            double.TryParse(input, out num1);

            result = num1 / -1;
            input = result.ToString();
        }

        
 
    }
}
