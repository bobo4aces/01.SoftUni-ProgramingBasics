using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < number; i++)
            {
                int newNumber=int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    oddSum += newNumber;
                }
                else
                {
                    evenSum += newNumber;
                }
            }
            if (oddSum==evenSum)
            {
                Console.WriteLine("Yes Sum = "+oddSum);
            }
            else
            {
                Console.WriteLine("No Diff = "+Math.Abs(oddSum-evenSum));
            }
        }
    }
}
