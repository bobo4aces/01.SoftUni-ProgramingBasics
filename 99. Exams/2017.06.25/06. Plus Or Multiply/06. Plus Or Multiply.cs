using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Plus_Or_Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isItNumber = true;
            for (int num1 = 1; num1 <= 30; num1++)
            {
                for (int num2 = 1; num2 <= 30; num2++)
                {
                    for (int num3 = 1; num3 <= 30; num3++)
                    {
                        if (num1<num2&&num2<num3&&num1+num2+num3==n)
                        {
                            Console.WriteLine($"{num1} + {num2} + {num3} = {n}");
                            isItNumber = false;
                        }
                        if (num1 > num2 && num2 > num3 && num1 * num2 * num3 == n)
                        {
                            Console.WriteLine($"{num1} * {num2} * {num3} = {n}");
                            isItNumber = false;
                        }
                    }
                }
            }
            if (isItNumber)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
