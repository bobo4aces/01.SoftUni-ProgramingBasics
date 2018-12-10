using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('#', (4 * n) + 1));
            for (int i = 0; i <n; i++)
            {
                Console.Write(new string('.',i+1));
                Console.Write(new string('#', 2*n-1-(i*2)));
                if (i==n/2)
                {
                    Console.Write(new string(' ', (2 * i)/2-1));
                    Console.Write("(@)");
                    Console.Write(new string(' ', (2 * i) / 2-1));
                }
                else
                {
                    Console.Write(new string(' ', 2 * i + 1));
                }
                Console.Write(new string('#', 2 * n - 1 - (i * 2)));
                Console.WriteLine(new string('.', i + 1));
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', n + 1 + i));
                Console.Write(new string('#', 2 * n - 1 - (i * 2)));
                Console.WriteLine(new string('.', n + 1 + i));
            }
        }
    }
}
