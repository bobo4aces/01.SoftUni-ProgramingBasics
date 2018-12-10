using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysSantaMissing = int.Parse(Console.ReadLine());
            int foodLeftKg = int.Parse(Console.ReadLine());
            double firstDeerFoodPerDay = double.Parse(Console.ReadLine());
            double secondDeerFoodPerDay = double.Parse(Console.ReadLine());
            double thirdDeerFoodPerDay = double.Parse(Console.ReadLine());
            double neededFoodFirstDeer = daysSantaMissing * firstDeerFoodPerDay;
            double neededFoodSecondDeer = daysSantaMissing * secondDeerFoodPerDay;
            double neededFoodThirdDeer = daysSantaMissing * thirdDeerFoodPerDay;
            double totalFoodNeeded = neededFoodFirstDeer + neededFoodSecondDeer + neededFoodThirdDeer;
            if (totalFoodNeeded<=foodLeftKg)
            {
                Console.WriteLine($"{Math.Floor(foodLeftKg - totalFoodNeeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFoodNeeded-foodLeftKg)} more kilos of food are needed.");
            }
            
        }
    }
}
