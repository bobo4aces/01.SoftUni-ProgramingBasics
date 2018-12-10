using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isItPrime = true;
            for (int i = 2; i <=Math.Sqrt(n); i++)
            {
                if (n%i==0)
                {
                    isItPrime = false;
                    break;
                }
            }
            if (isItPrime&&n>=2)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
