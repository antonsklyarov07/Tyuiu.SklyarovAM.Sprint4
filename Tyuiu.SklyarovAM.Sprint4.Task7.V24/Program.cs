using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SklyarovAM.Sprint4.Task7.V24.Lib;
namespace Tyuiu.SklyarovAM.Sprint4.Task7.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            int cols = 3;
            string str = "651827384219648";
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Строка цифр: {str}");
            Console.WriteLine($"Размер матрицы: {rows} на {cols}");
            Console.WriteLine();
            Console.WriteLine("Сформированная матрица:");
            int charIndex = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{str[charIndex],3}");
                    charIndex++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int result = ds.Calculate(rows, cols, str);
            Console.WriteLine($"Произведение четных чисел: {result}");
            Console.ReadKey();
        }
    }
}
