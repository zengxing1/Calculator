using Calculator.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Mul : AddFactory
    {
        public  int Calculate(int a, int b)
        {
            return a * b;
        }
    }
}
