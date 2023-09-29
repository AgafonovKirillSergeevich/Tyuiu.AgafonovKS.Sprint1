using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AgafonovKS.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            int letters = 0;
            int symbols = 0;
            foreach (char c in value)
            {
                if (char.IsLetter(c))
                {
                    letters++;
                }
                else
                {
                    symbols++;
                }
            }

            return letters > symbols;
        }

    }
}
