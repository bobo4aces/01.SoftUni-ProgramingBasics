using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiaQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());
            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice - (rakiaPrice * 0.40);
            double beerPrice = rakiaPrice - (rakiaPrice * 0.80);
            double moneyNeeded = whiskeyPrice * whiskeyQuantity + rakiaPrice * rakiaQuantity + winePrice*wineQuantity + beerPrice * beerQuantity;
            Console.WriteLine($"{moneyNeeded:f2}");
        }
    }
}
//20:05