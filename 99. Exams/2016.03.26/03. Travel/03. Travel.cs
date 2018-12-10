using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string place = "";
            double cost = 0;
            if (budjet<=100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        cost = budjet * 0.30;
                        place = "Camp";
                        break;
                    case "winter":
                        cost = budjet * 0.70;
                        place = "Hotel";
                        break;
                    default:
                        break;
                }
            }
            else if (101<=budjet&& budjet <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        cost = budjet * 0.40;
                        place = "Camp";
                        break;
                    case "winter":
                        cost = budjet * 0.80;
                        place = "Hotel";
                        break;
                    default:
                        break;
                }
            }
            else if (1001 <= budjet)
            {
                destination = "Europe";
                cost = budjet * 0.90;
                place = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {cost:f2}");
        }
    }
}
//20:47-20:58
//00:33