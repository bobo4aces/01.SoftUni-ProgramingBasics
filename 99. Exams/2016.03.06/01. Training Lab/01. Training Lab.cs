using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double hCm = h * 100;
            double wCm = w * 100;
            int totalH =(int)hCm -100;
            int desksPerRow = totalH / 70;
            int rows = (int)wCm / 120;
            int totalSpaces =(desksPerRow*rows)-3;
            Console.WriteLine(totalSpaces);
        }
    }
}
//20:01-20:15