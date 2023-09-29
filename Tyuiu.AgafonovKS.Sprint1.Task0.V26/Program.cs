using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.Agafonovks.Sprint1.Task0.V26.Lib;

namespace Tyuiu.Agafonovks.Sprint1.Task0.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #0 | Выполнил: Агафонов К. С. | ИИПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                          *");
            Console.WriteLine("* Задания #7                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Агафонов Кирилл Сергеевич | ИИПБ-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет выражение 4*5/2-18/2/3 *");
            Console.WriteLine("* и печатает результа на экране.                                           *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ: 4*5/2-18/2/3                                             *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*    РЕЗУЛЬТАТ                                                             *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.Calculate());
            Console.ReadKey();
        }
    }
}