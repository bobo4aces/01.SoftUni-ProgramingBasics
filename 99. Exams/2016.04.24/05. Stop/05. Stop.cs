using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Top
            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', 2 * n + 1));
            Console.WriteLine(new string('.', n + 1));
            //Middle Top
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', n - i));
                Console.Write("//");
                Console.Write(new string('_', (2 * n - 1) + 2 * i));
                Console.Write("\\\\");
                Console.WriteLine(new string('.', n - i));
            }
            //Middle
            Console.Write("//");
            Console.Write(new string('_', (4 * n - 6) / 2));
            Console.Write("STOP!");
            Console.Write(new string('_', (4 * n - 6) / 2));
            Console.WriteLine("\\\\");
            //Bottom
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', i));
                Console.Write("\\\\");
                Console.Write(new string('_', (4 * n - 1) - 2 * i));
                Console.Write("//");
                Console.WriteLine(new string('.', i));
            }
        }
    }
}
//19:39-20:00