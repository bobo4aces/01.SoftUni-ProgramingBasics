using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double domatoQuantity = double.Parse(Console.ReadLine());
            int boxes = int.Parse(Console.ReadLine());
            int jars = int.Parse(Console.ReadLine());
            double totalLutenica = domatoQuantity / 5;
            double totalJars = totalLutenica / 0.535;
            double totalBoxes = totalJars / jars;
            Console.WriteLine($"Total lutenica: {Math.Floor(totalLutenica)} kilograms.");
            if (totalBoxes>boxes)
            {
                Console.WriteLine($"{Math.Floor(totalBoxes- boxes)} boxes left.");
                Console.WriteLine($"{Math.Floor(totalJars-(boxes*jars))} jars left.");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(boxes-totalBoxes)} more boxes needed.");
                Console.WriteLine($"{Math.Floor((boxes * jars)- totalJars)} more jars needed.");
            }
            
            
            
        }
    }
}
