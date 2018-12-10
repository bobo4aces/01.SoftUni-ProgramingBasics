using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            double grapeSquare = double.Parse(Console.ReadLine());
            double kilogramsPerMeter = double.Parse(Console.ReadLine());
            double junk = double.Parse(Console.ReadLine());
            double grapeQuantity = grapeSquare * kilogramsPerMeter;
            double grapeLeft = grapeQuantity - junk;
            double rakiaQuantity = grapeLeft * 0.45 / 7.5;
            double rakiaIncome = rakiaQuantity * 9.8;
            double grapeIncome = grapeLeft * 0.55 * 1.5;
            Console.WriteLine(rakiaIncome.ToString("0.00"));
            Console.WriteLine(grapeIncome.ToString("0.00"));
        }
    }
}
//19:30-19:43