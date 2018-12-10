using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n+1; i++)
            {
                Console.Write(new string('.',n+i));
                if (i<n/2)
                {
                    Console.Write(new string('#', 3 * n - 2*i));
                }
                else
                {
                    Console.Write('#');
                    Console.Write(new string('.', 3 * n - 2*i-2));
                    Console.Write('#');
                }
                Console.WriteLine(new string('.', n + i));
            }
            Console.Write(new string('.',2*n));
            Console.Write(new string('#', n));
            Console.WriteLine(new string('.', 2 * n));
            for (int i = 0; i < n+2; i++)
            {
                
                if ((n+1)/2==i)
                {
                    Console.Write(new string('.', (5 * n)/2 - 5));
                    Console.Write("D^A^N^C^E^");
                    Console.WriteLine(new string('.', (5 * n) / 2 - 5));
                }
                else
                {
                    Console.Write(new string('.', 2 * n - 2));
                    Console.Write(new string('#', n + 4));
                    Console.WriteLine(new string('.', 2 * n - 2));
                }
                
                
            }
        }
    }
}
