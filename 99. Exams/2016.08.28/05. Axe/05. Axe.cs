using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Top
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-',3*n));
                Console.Write('*');
                Console.Write(new string('-', i));
                Console.Write('*');
                Console.WriteLine(new string('-', (2 * n-2)-i));
            }
            //Middle Top
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('*', 3 * n+1));
                Console.Write(new string('-', n-1));
                Console.Write('*');
                Console.WriteLine(new string('-', n - 1));
            }
            //Middle Bottom
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('-', 3 * n -i));
                Console.Write('*');
                if (i==n/2-1)
                {
                    Console.Write(new string('*', n - 1 + 2 * i));
                }
                else
                {
                    Console.Write(new string('-', n - 1 + 2 * i));
                }
                Console.Write('*');
                Console.WriteLine(new string('-', n - 1-i));
            }
        }
    }
}
//19:27-20:19
//02:24