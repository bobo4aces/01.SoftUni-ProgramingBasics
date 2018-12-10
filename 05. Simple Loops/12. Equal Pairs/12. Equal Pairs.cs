using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstGroup = 0;
            int secondGroup = 0;
            int difference = 0;
            int maxDifference = int.MinValue;
            bool isEqual = false;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    firstGroup = 0;
                    firstGroup += number1 + number2;
                    sum = number1 + number2;
                    difference = 0;
                    difference += secondGroup - firstGroup;
                    if (difference > maxDifference)
                    {
                        maxDifference = difference;
                    }
                }
                else
                {
                    secondGroup = 0;
                    secondGroup += number1 + number2;
                    difference = 0;
                    difference += secondGroup - firstGroup;
                    if (difference == 0)
                    {
                        isEqual = true;
                    }
                    if (difference > maxDifference)
                    {
                        maxDifference = difference;
                    }


                }
            }
            if (isEqual || n == 1)
            {
                Console.WriteLine($"Yes,value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={Math.Abs(difference)}");
            }
        }
    }
}
