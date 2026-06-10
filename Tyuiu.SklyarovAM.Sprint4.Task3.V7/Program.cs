using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SklyarovAM.Sprint4.Task3.V7.Lib;

namespace Tyuiu.SklyarovAM.Sprint4.Task3.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = {
            { 9, 6, 9, 3, 7 },
            { 3, 3, 3, 8, 2 },
            { 2, 1, 3, 5, 2 },
            { 6, 2, 3, 2, 5 },
            { 4, 5, 6, 9, 5 }
            };
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(matrix));
            Console.ReadKey();
        }
    }
}
