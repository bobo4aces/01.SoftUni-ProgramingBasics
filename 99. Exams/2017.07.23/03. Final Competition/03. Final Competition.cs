using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double moneyPrize = points*dancers;
            double razhodi = 0;
            if (season=="summer")
            {
                if (place=="Bulgaria")
                {
                    razhodi = moneyPrize * 0.05;
                }
                else
                {
                    moneyPrize = moneyPrize * 1.5;
                    razhodi= moneyPrize * 0.1;
                }
            }
            else
            {
                if (place == "Bulgaria")
                {
                    razhodi = moneyPrize * 0.08;
                }
                else
                {
                    moneyPrize = moneyPrize * 1.5;
                    razhodi = moneyPrize * 0.15;
                }
            }
            double charity = (moneyPrize - razhodi) * 0.75;
            double moneyLeftPerDancer = (moneyPrize - charity-razhodi)/dancers;
            Console.WriteLine($"Charity - { charity.ToString("0.00")}");
            Console.WriteLine($"Money per dancer - {moneyLeftPerDancer.ToString("0.00")}");
        }
    }
}
