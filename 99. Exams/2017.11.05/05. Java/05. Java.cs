using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ',n));
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("~ ");
                }
                Console.WriteLine("~");
            }
            Console.Write(new string('=',3*n+5));
            Console.WriteLine();
            for (int i = 0; i < n-2; i++)
            {
                Console.Write('|');
                if (i==(n-2)/2)
                {
                    Console.Write(new string('~', n));
                    Console.Write("JAVA");
                    Console.Write(new string('~', n));
                }
                else
                {
                    Console.Write(new string('~', 2 * n +4));
                }
                
                Console.Write('|');
                Console.Write(new string(' ', n - 1));
                Console.WriteLine('|');
            }
            Console.WriteLine(new string('=', 3 * n + 5));
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ',i-1));
                Console.Write('\\');
                Console.Write(new string('@',((3 * n + 6) - n )- (2*i)));
                Console.Write('/');
                Console.WriteLine();
            }
            Console.WriteLine(new string('=', (3 * n+6)-n));
        }
    }
}
