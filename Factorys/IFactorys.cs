﻿using Calculator.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Factorys
{
    public interface IFactorys
    {
        Calculators.AddFactory GetCalculator();
    }
}
