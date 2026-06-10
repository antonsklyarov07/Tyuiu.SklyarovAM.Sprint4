using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SklyarovAM.Sprint4.Task1.V6.Lib;

namespace Tyuiu.SklyarovAM.Sprint4.Task1.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] numsArray = new int[10];
            for (int i = 0; i < numsArray.Length; i++)
            { 
                Console.WriteLine("Введите значение " + i + " элемента массива:");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i] + "\t");
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(numsArray));
            Console.ReadKey();
        }
    }
}
