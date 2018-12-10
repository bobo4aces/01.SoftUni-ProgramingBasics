using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f0 = 1;
            int f1 = 1;
            int fibunachi = 2;
            int startNumber = 2;
            if (n < 2)
            {
                Console.WriteLine("1");
            }
            else
            {
                do
                {
                    fibunachi = f0 + f1;
                    f1 = f0;
                    f0 = fibunachi;
                    startNumber++;
                } while (startNumber<=n);
                Console.WriteLine(fibunachi);
            }
        }
    }
}
