using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputNumber = double.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double evenNumbers = 0;
            double oddNumbers = 0;
            for (int i = 0; i < inputNumber; i++)
            {
                if (i % 2 == 0)
                {
                    oddNumbers = double.Parse(Console.ReadLine());
                    oddSum += oddNumbers;
                    if (oddNumbers < oddMin)
                    {
                        oddMin = oddNumbers;
                    }
                    if (oddNumbers > oddMax)
                    {
                        oddMax = oddNumbers;
                    }
                }
                else
                {
                    evenNumbers = double.Parse(Console.ReadLine());
                    evenSum += evenNumbers;
                    if (evenNumbers < evenMin)
                    {
                        evenMin = evenNumbers;
                    }
                    if (evenNumbers > evenMax)
                    {
                        evenMax = evenNumbers;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum},");
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin},");
            }
            if (oddMax == double.MinValue)
            {
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax},");
            }
            Console.WriteLine($"EvenSum={evenSum},");
            if (evenMin == double.MaxValue)
            {
                Console.WriteLine($"EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin},");
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine($"EvenMax=No,");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax}");
            }
        }
    }
}
