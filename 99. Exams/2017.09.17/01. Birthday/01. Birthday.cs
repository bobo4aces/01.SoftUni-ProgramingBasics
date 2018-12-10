using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lenght = decimal.Parse(Console.ReadLine());
            decimal wight = decimal.Parse(Console.ReadLine());
            decimal hight = decimal.Parse(Console.ReadLine());
            decimal percent = decimal.Parse(Console.ReadLine());
            decimal obem = lenght * wight * hight;
            decimal litres = obem * 0.001m;
            decimal newPercent = percent * 0.01m;
            decimal usedLitres = litres * (1.0m - newPercent);
            Console.WriteLine(Math.Round(usedLitres,3));
        }
    }
}
