using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Top
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('*',i+1));
                Console.Write('\\');
                Console.Write(new string('-', 2*n-1-2*i));
                Console.Write('/');
                Console.WriteLine(new string('*', i+1));
            }
            //Middle
            for (int i = 0; i < n/3; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', n/2 + i));
                Console.Write('\\');
                Console.Write(new string('*', n - 2 * i));
                Console.Write('/');
                Console.Write(new string('*', n / 2 + i));
                Console.WriteLine('|');
            }
            //Bottom
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', i + 1));
                Console.Write('\\');
                Console.Write(new string('*', 2 * n - 1 - 2 * i));
                Console.Write('/');
                Console.WriteLine(new string('-', i + 1));
            }
        }
    }
}
//19:56-20:19