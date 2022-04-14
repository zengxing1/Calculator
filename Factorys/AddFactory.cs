using Calculator.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Factorys
{
    public class AddFactory : IFactorys
    {
        public Calculators.AddFactory GetCalculator()
        {
           return new Add();
        }
    }
}
