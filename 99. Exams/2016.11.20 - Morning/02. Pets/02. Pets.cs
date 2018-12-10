using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double dogsFoodPerDay = double.Parse(Console.ReadLine());
            double catsFoodPerDay = double.Parse(Console.ReadLine());
            double turtlesFoodPerDay = double.Parse(Console.ReadLine());
            double totalFoodForDog = dogsFoodPerDay * daysCount;
            double totalFoodForCat = catsFoodPerDay * daysCount;
            double totalFoodForTurtle = (turtlesFoodPerDay/1000) * daysCount;
            double totalFood = totalFoodForDog + totalFoodForCat + totalFoodForTurtle;
            if (totalFood<=foodLeft)
            {
                Console.WriteLine($"{Math.Floor(foodLeft - totalFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFood - foodLeft)} more kilos of food are needed.");
            }
            
        }
    }
}
//20:44-20:52
//00:16