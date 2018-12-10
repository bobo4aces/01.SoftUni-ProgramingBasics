using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Top
            Console.Write(new string ('.',(3*n-1)/2));
            Console.Write("x");
            Console.WriteLine(new string('.', (3 * n - 1) / 2));
            Console.Write(new string('.', (3 * n - 3) / 2));
            Console.Write("/x\\");
            Console.WriteLine(new string('.', (3 * n - 3) / 2));
            Console.Write(new string('.', (3 * n - 3) / 2));
            Console.Write("x|x");
            Console.WriteLine(new string('.', (3 * n - 3) / 2));
            //Middle 1
            for (int i = 0; i <= (n-1)/2; i++)
            {
                Console.Write(new string('.', ((n - 1) / 2) - i));
                Console.Write(new string('x', n+i));
                Console.Write("|");
                Console.Write(new string('x', n+i));
                Console.WriteLine(new string('.', ((n - 1) / 2) - i));
                
            }
            for (int i = 0; i <= ((n - 1) / 2)-1; i++)
            {
                Console.Write(new string('.',  i+1));
                Console.Write(new string('x', n-i));
                Console.Write("|");
                Console.Write(new string('x', n-i));
                Console.WriteLine(new string('.',  i+1));

            }
            //Fixed Middle
            Console.Write(new string('.', (3 * n - 3) / 2));
            Console.Write("/x\\");
            Console.WriteLine(new string('.', (3 * n - 3) / 2));
            Console.Write(new string('.', (3 * n - 3) / 2));
            Console.Write("\\x/");
            Console.WriteLine(new string('.', (3 * n - 3) / 2));
            //Middle 2
            for (int i = 0; i <= (n - 1) / 2; i++)
            {
                Console.Write(new string('.', ((3 * n - 3) / 3) - i - 2));
                Console.Write(new string('x', n + i));
                Console.Write("|");
                Console.Write(new string('x', n + i));
                Console.WriteLine(new string('.', ((3 * n - 3) / 3) - i - 2));

            }
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.Write(new string('.', ((3 * n - 3) / 3) + i - 3));
                Console.Write(new string('x', n - i + 1));
                Console.Write("|");
                Console.Write(new string('x', n - i + 1));
                Console.WriteLine(new string('.', ((3 * n - 3) / 3) + i - 3));

            }
            //Bottom
            Console.Write(new string('.', (3 * n - 3) / 2));
            Console.Write("x|x");
            Console.WriteLine(new string('.', (3 * n - 3) / 2));
            Console.Write(new string('.', (3 * n - 3) / 2));
            Console.Write("\\x/");
            Console.WriteLine(new string('.', (3 * n - 3) / 2));
            Console.Write(new string('.', (3 * n - 1) / 2));
            Console.Write("x");
            Console.WriteLine(new string('.', (3 * n - 1) / 2));
        }
    }
}
