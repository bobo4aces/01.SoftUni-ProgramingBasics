using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = "";
            string placeType = "";
            double price = 0;
            if (budget <= 1000)
            {
                placeType = "Camp";
                if (season=="Summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }
            }
            else if (1000<budget&& budget <= 3000)
            {
                placeType = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.80;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.60;
                }
            }
            else if (budget > 3000)
            {
                placeType = "Hotel";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.90;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.90;
                }
            }
            Console.WriteLine($"{ location } - { placeType } - {price:f2}");
        }
    }
}
//16:21-16:38