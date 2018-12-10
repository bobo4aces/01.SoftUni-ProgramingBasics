using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Top
            Console.Write('+');
            Console.Write(new string('~',n-2));
            Console.Write('+');
            Console.WriteLine(new string('.', 2*n+1));
            //Middle Top
            for (int i = 0; i < 2*n+1; i++)
            {
                Console.Write('|');
                Console.Write(new string('.', i));
                Console.Write("\\");
                Console.Write(new string('~', n - 2));
                Console.Write("\\");
                Console.WriteLine(new string('.', 2 * n -i));
            }
            //Middle Bottom
            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.Write(new string('.', i));
                Console.Write('\\');
                Console.Write(new string('.', 2 * n - i));
                Console.Write("|");
                Console.Write(new string('~', n - 2));
                Console.WriteLine("|");
            }
            //Bottom
            Console.Write(new string('.', 2 * n + 1));
            Console.Write('+');
            Console.Write(new string('~', n - 2));
            Console.WriteLine('+');
        }
    }
}
//20:26-20:42
