using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrizantemiCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int laleCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string dayType = Console.ReadLine();
            double hrizantemiPrice = 0;
            double rosesPrice = 0;
            double lalePrice = 0;
            if (season== "Spring"||season== "Summer")
            {
                hrizantemiPrice = hrizantemiCount * 2.00;
                rosesPrice = rosesCount * 4.10;
                lalePrice = laleCount * 2.50;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                hrizantemiPrice = hrizantemiCount * 3.75;
                rosesPrice = rosesCount * 4.50;
                lalePrice = laleCount * 4.15;
            }
            double price = hrizantemiPrice + rosesPrice + lalePrice;
            if (dayType=="Y")
            {
                price = price * 1.15;
            }
            if (laleCount>7&&season=="Spring")
            {
                price = price - (price * 0.05);
            }
            if (rosesCount >=10 && season == "Winter")
            {
                price = price - (price * 0.10);
            }
            if (hrizantemiCount+ rosesCount+ laleCount > 20)
            {
                price = price - (price * 0.20);
            }
            Console.WriteLine($"{(price+2):f2}");
        }
    }
}
//21:20-21:34
//21:54-22:13