using Calculator.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Factorys
{
    public class SubFactory : IFactorys
    {
        public Calculators.AddFactory GetCalculator()
        {
            return new Sub();
        }
    }
}
