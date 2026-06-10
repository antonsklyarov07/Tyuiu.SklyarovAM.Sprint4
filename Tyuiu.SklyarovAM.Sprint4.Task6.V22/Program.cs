using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SklyarovAM.Sprint4.Task6.V22.Lib;
namespace Tyuiu.SklyarovAM.Sprint4.Task6.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            var weather = new string[] { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };
            var res = ds.Calculate(weather);
            foreach (var element in res)
            {
                Console.WriteLine(element);
            }
        }
    }
}
