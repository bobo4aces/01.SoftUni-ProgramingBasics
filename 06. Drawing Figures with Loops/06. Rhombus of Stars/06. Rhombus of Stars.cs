using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <=n; row++)
            {
                for (int col = 1; col <=n-row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int col = 1; col <= row-1; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int row = 1; row <= n-1; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int col = 1; col <= n-row-1; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
