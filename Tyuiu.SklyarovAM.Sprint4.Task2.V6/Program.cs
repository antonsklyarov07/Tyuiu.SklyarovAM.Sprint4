using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SklyarovAM.Sprint4.Task2.V6.Lib;
namespace Tyuiu.SklyarovAM.Sprint4.Task2.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] arr = new int[15];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(2, 9);
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "\t");
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(arr));
            Console.ReadKey();
        }
    }
}
