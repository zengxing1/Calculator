using Calculator.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Div : AddFactory
    {
        public  int Calculate(int a, int b)
        {
            if (Math.Abs(b) > 0)
            {
                return a / b;
            }
            else
                throw new DivideByZeroException("除数不能为0");
        }

       
    }
}
