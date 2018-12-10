using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int grapeSquareMeters = int.Parse(Console.ReadLine());
            double grapePerSquareMeter = double.Parse(Console.ReadLine());
            int wineLitersNeeded = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            double totalGrape = grapeSquareMeters * grapePerSquareMeter;
            double wine = 0.4 * totalGrape / 2.5;
            if (wine>=wineLitersNeeded)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine-wineLitersNeeded)} liters left -> {Math.Ceiling((wine - wineLitersNeeded) /workersCount)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineLitersNeeded-wine)} liters wine needed.");
            }
            
        }
    }
}
//10:32-10:42