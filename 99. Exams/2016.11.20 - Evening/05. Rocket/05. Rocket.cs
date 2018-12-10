using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Top
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.',3*n/2-1-i));
                Console.Write('/');
                Console.Write(new string(' ', 2*i));
                Console.Write('\\');
                Console.WriteLine(new string('.', 3 * n / 2-1 - i));
            }
            Console.Write(new string('.', n/2));
            Console.Write(new string('*', 2 * n));
            Console.WriteLine(new string('.', n/2));
            //Middle
            for (int i = 0; i < 2*n; i++)
            {
                Console.Write(new string('.', n / 2));
                Console.Write('|');
                Console.Write(new string('\\', 2 * n-2));
                Console.Write('|');
                Console.WriteLine(new string('.', n / 2));
            }
            //Bottom
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('.', n / 2-i));
                Console.Write('/');
                Console.Write(new string('*', 2 * n - 2+2*i));
                Console.Write('\\');
                Console.WriteLine(new string('.', n / 2-i));
            }
        }
    }
}
//20:05-20:26