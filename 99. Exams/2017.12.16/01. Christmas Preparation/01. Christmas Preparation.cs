using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Christmas_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int paper = int.Parse(Console.ReadLine());
            int plat = int.Parse(Console.ReadLine());
            double glueLiters = double.Parse(Console.ReadLine());
            int percentOff = int.Parse(Console.ReadLine());
            double paperPrice = paper * 5.80;
            double platPrice = plat * 7.20;
            double gluePrice = glueLiters * 1.20;
            double totalPrice = paperPrice + platPrice + gluePrice;
            double priceWithOff = totalPrice - ((totalPrice * percentOff) / 100);
            Console.WriteLine($"{priceWithOff:f3}");
        }
    }
}
