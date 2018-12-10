using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Christmas_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Top
            Console.Write(new string('-',2*n));
            Console.Write(new string('*', n));
            Console.WriteLine(new string('-', 2 * n));
            //Middle Top
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('-', 2 * n-2-2*i));
                Console.Write(new string('*', i));
                Console.Write('*');
                Console.Write(new string('&', (n+2)+2*i));
                Console.Write('*');
                Console.Write(new string('*', i));
                Console.WriteLine(new string('-', 2 * n - 2 - 2 * i));
            }
            //Middle
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('-', n-1-i));
                Console.Write("**");
                Console.Write(new string('~', 5*n-2*(n - 1 - i)-4));
                Console.Write("**");
                Console.WriteLine(new string('-', n - 1 - i));
            }
            Console.Write(new string('-', n/2));
            Console.Write('*');
            Console.Write(new string('|', 4 * n - 2));
            Console.Write('*');
            Console.WriteLine(new string('-', n / 2));
            //Second Middle
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('-', n/2+i));
                Console.Write("**");
                Console.Write(new string('~', 5 * n - 2 * (n / 2 + i) - 4));
                Console.Write("**");
                Console.WriteLine(new string('-', n / 2 + i));
            }
            //
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('-', n+ 2 * i));
                Console.Write(new string('*', (n-1)/2-i));
                Console.Write('*');
                Console.Write(new string('&', 2*n -2*i));
                Console.Write('*');
                Console.Write(new string('*', (n - 1) / 2 - i));
                Console.WriteLine(new string('-', n + 2 * i));
            }
            Console.Write(new string('-', 2 * n));
            Console.Write(new string('*', n));
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
