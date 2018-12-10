using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal quantity = 0.0m;
            decimal degrees = 0.0m;
            decimal averageDegrees = 0.0m;
            decimal input = 0.0m;
            for (int i = 0; i < n; i++)
            {
                input = decimal.Parse(Console.ReadLine());
                degrees = decimal.Parse(Console.ReadLine());
                averageDegrees += input * degrees;
                quantity += input;
            }

            decimal totalDegrees= averageDegrees/quantity;
            Console.WriteLine("Liter: {0}",Math.Round(quantity,2).ToString("0.00"));
            Console.WriteLine("Degrees: {0}", Math.Round(totalDegrees, 2).ToString("0.00"));
            if (totalDegrees > 42m)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
            else if (totalDegrees < 42m&& totalDegrees >= 38m )
            {
                Console.WriteLine("Super!");
            }
            else if (totalDegrees < 38m)
            {
                Console.WriteLine("Not good, you should baking!");
            }
        }
    }
}
