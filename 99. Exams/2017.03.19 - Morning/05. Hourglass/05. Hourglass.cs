using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Top
            Console.WriteLine(new string('*',2*n+1));
            Console.Write(".*");
            Console.Write(new string(' ', 2 * n -3));
            Console.WriteLine("*.");
            //Middle Top
            for (int i = 0; i < n-2; i++)
            {
                Console.Write(new string('.',2+i));
                Console.Write('*');
                Console.Write(new string('@', (2*n-5) -2* i));
                Console.Write('*');
                Console.WriteLine(new string('.', 2 + i));
            }
            //Middle
            Console.Write(new string('.',n));
            Console.Write('*');
            Console.WriteLine(new string('.', n));
            //Middle Bottom
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(new string('.', (n-1) - i));
                Console.Write('*');
                Console.Write(new string(' ', (1 + i) - 1));
                Console.Write('@');
                Console.Write(new string(' ', (1+i)-1));
                Console.Write('*');
                Console.WriteLine(new string('.', (n - 1) - i));
            }
            //Bottom
            Console.Write(".*");
            Console.Write(new string('@', 2 * n - 3));
            Console.WriteLine("*.");
            Console.WriteLine(new string('*', 2 * n + 1));
        }
    }
}
//16:56-17:15