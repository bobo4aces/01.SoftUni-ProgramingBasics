using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('.',n));
            Console.Write(new string('*', 3*n));
            Console.WriteLine(new string('.', n));
            //Top
            for (int i = 0; i < n-1; i++)
            {
                Console.Write(new string('.', n-1-i));
                Console.Write('*');
                Console.Write(new string('.', 3 * n+2*i));
                Console.Write('*');
                Console.WriteLine(new string('.', n - 1 - i));
            }
            Console.WriteLine(new string('*', 5*n));
            //Bottom
            for (int i = 0; i < 2*n+1; i++)
            {
                Console.Write(new string('.',i+1));
                Console.Write('*');
                if (i== 2 * n)
                {
                    Console.Write(new string('*', 5 * n - 4 - 2 * i));
                }
                else
                {
                    Console.Write(new string('.', 5 * n - 4 - 2 * i));
                }
                Console.Write('*');
                Console.WriteLine(new string('.', i + 1));
            }
        }
    }
}
//11:18-11:23
//19:37-19:43