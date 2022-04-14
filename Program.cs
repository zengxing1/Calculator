using Calculator.Calculators;
using Calculator.Factorys;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int dataX, dataY, result;
            string op;
            Console.WriteLine("请输入第一个操作数:");
            dataX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入操作符:");
            op = Convert.ToString(Console.ReadLine());
            Console.WriteLine("请输入第二个操作数:");
            dataY = Convert.ToInt32(Console.ReadLine());

            Calculators.AddFactory calculator;
            IFactorys ft = null;
            Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string factoryname = conf.AppSettings.Settings[op].Value;
            Assembly ass = Assembly.Load("Calculator");
            ft = (IFactorys)ass.CreateInstance(factoryname);
            calculator = ft.GetCalculator();
            result = calculator.Calculate(dataX, dataY);
            Console.WriteLine("{0}{1}{2}={3}", dataX, op, dataY,result);
            Console.ReadKey();



        }
    }
}
