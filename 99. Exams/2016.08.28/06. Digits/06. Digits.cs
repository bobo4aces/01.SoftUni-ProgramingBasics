using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n3 = n%10;
            int n2 = (n / 10)%10;
            int n1 = (n / 100) % 10;
            int intervalStart = n1 + n2;
            int intervalEnd = n1 + n3;
            for (int i = 0; i < intervalStart; i++)
            {
                for (int j = 0; j < intervalEnd; j++)
                {


                    if (n % 5 == 0)
                    {
                        n = n - n1;
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - n2;
                    }
                    else
                    {
                        n = n + n3;
                    }
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
        }
    }
}
//20:19-20:37