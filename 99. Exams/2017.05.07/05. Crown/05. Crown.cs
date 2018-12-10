using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write('@');
            Console.Write(new string(' ',n-2));
            Console.Write('@');
            Console.Write(new string(' ', n - 2));
            Console.WriteLine('@');
            Console.Write("**");
            Console.Write(new string(' ', n - 3));
            Console.Write('*');
            Console.Write(new string(' ', n - 3));
            Console.WriteLine("**");
            for (int i = 0; i < (n-1)/3; i++)
            {
                Console.Write('*');
                Console.Write(new string('.',i+1));
                Console.Write('*');
                Console.Write(new string(' ', (n+1)/2 - 2*i));
                Console.Write('*');
                Console.Write(new string('.', 2*i+1));
                Console.Write('*');
                Console.Write(new string(' ', (n - 5) - 2 * i));
                Console.Write('*');
                Console.Write(new string('.', i+1));
                Console.WriteLine('*');
            }
            Console.Write('*');
            Console.Write(new string('.', (n +1)  / 3));
            Console.Write('*');
            Console.Write(new string('.', n - 3));
            Console.Write('*');
            Console.Write(new string('.', (n - 1) / 2));
            Console.WriteLine('*');

            Console.Write('*');
            Console.Write(new string('.', n/2));
            Console.Write(new string('*', (n-1)/3));
            Console.Write('.');
            Console.Write(new string('*', (n - 1) / 3));
            Console.Write(new string('.', n / 2));
            Console.WriteLine('*');
            Console.WriteLine(new string('*', (2 * n) - 1));
            Console.WriteLine(new string('*', (2 * n) - 1));
        }
    }
}
