using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AgafonovKS.Sprint1.Task7.V7.Lib
{
    public class DataService : ISprint1Task7V7
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round(((Math.Cos(x) / (3.14 - 2 * Math.Pow(y, x))) + 16 * x * Math.Cos(x * y) - 2), 3);
            return res;
        }
    }
}
