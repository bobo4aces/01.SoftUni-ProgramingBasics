using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Top
            Console.Write(new string('.',2*n-1));
            Console.Write("/|\\");
            Console.WriteLine(new string('.', 2 * n - 1));
            Console.Write(new string('.', 2 * n - 1));
            Console.Write("\\|/");
            Console.WriteLine(new string('.', 2 * n - 1));
            //Middle
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(new string('.', (2 * n - 1)-i));
                Console.Write('*');
                Console.Write(new string('-', i));
                Console.Write('*');
                Console.Write(new string('-', i));
                Console.Write('*');
                Console.WriteLine(new string('.', (2 * n - 1) - i));
            }
            //Bottom
            Console.WriteLine(new string('*', 4 * n + 1));
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write('*');
                Console.Write('.');
            }
            Console.WriteLine('*');
            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}
//18:53-19:06