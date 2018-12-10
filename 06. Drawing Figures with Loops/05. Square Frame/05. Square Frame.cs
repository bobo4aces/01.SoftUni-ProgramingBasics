using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("+");
            for (int top = 1; top <= n-2; top++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
            for (int middle = 1; middle <= n-2; middle++)
            {
                Console.Write("|");
                for (int i = 0; i < n-2; i++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }
            Console.Write("+");
            for (int top = 1; top <= n - 2; top++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
