using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoinsCount = int.Parse(Console.ReadLine());
            double chineeseYoansCount = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());
            int bitcoinsInLeva = bitcoinsCount * 1168;
            double chineeseYoansInDollars = chineeseYoansCount * 0.15;
            double chineeseYoansInLeva = chineeseYoansInDollars * 1.76;
            double totalLeva = bitcoinsInLeva + chineeseYoansInLeva;
            double totalLevaInEuro = totalLeva / 1.95;
            double commissionToPay = totalLevaInEuro * (commission*0.01);
            Console.WriteLine($"{(totalLevaInEuro - commissionToPay):f2}");
        }
    }
}
//10:19-10:31