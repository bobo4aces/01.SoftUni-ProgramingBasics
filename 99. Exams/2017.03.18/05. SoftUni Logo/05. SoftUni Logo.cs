using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SoftUni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < 2*n; i++)
            {
                Console.Write(new string('.',((12*n-5)/2)-3*i));
                Console.Write(new string('#', 3*i));
                Console.Write(new string('#', 1));
                Console.Write(new string('#', 3 * i));
                Console.WriteLine(new string('.', ((12 * n - 5) / 2) - 3 * i));
            }
            for (int i = 0; i < n-2; i++)
            {
                Console.Write('|');
                Console.Write(new string('.', 3 * i+2));
                Console.Write(new string('#', ((12 * n - 5) - 6)-6*i));
                Console.WriteLine(new string('.', 3 * i+3));
            }
            for (int i = 0; i < n-1; i++)
            {
                Console.Write('|');
                Console.Write(new string('.', 3*n-4));
                Console.Write(new string('#', 6*n+1));
                Console.WriteLine(new string('.', 3 * n - 3));
            }
            Console.Write('@');
            Console.Write(new string('.', 3 * n - 4));
            Console.Write(new string('#', 6 * n + 1));
            Console.WriteLine(new string('.', 3 * n - 3));
        }
    }
}
//19:54-20:38