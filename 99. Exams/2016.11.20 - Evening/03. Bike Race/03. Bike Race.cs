using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorsCount = int.Parse(Console.ReadLine());
            int seniorsCount = int.Parse(Console.ReadLine());
            string raceType = Console.ReadLine().ToLower();
            double tax = 0;
            switch (raceType)
            {
                case "trail":
                    tax = juniorsCount * 5.50 + seniorsCount * 7;
                    break;
                case "cross-country":
                    tax = juniorsCount * 8 + seniorsCount * 9.5;
                    break;
                case "downhill":
                    tax = juniorsCount * 12.25 + seniorsCount * 13.75;
                    break;
                case "road":
                    tax = juniorsCount * 20 + seniorsCount * 21.50;
                    break;
                default:
                    break;
            }
            if (juniorsCount+seniorsCount>=50)
            {
                tax = tax - (tax * 0.25);
            }
            double sum = tax-(tax * 0.05);
            Console.WriteLine($"{sum:f2}");
        }
    }
}
//00:20?