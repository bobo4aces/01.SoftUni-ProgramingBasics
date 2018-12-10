using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vegetable_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePricePerKilogram = double.Parse(Console.ReadLine());
            double fruitPricePerKilogram = double.Parse(Console.ReadLine());
            int totalKilogramsVegetables = int.Parse(Console.ReadLine());
            int totalKilogramsFruits = int.Parse(Console.ReadLine());
            double totalVegetableCosts = vegetablePricePerKilogram * totalKilogramsVegetables;
            double totalFruitCosts = fruitPricePerKilogram * totalKilogramsFruits;
            double totalCostsInLeva = totalVegetableCosts + totalFruitCosts;
            double totalCostsInEuro = totalCostsInLeva / 1.94;
            Console.WriteLine($"{totalCostsInEuro}");
        }
    }
}
//20:23-20:30