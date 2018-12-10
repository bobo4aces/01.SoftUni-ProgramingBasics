using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Tubes_In_A_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double firstPipeFill = p1 * h;
            double secondPipeFill = p2 * h;
            double totalFill = firstPipeFill + secondPipeFill;
            if (v>=totalFill)
            {
                Console.WriteLine($"The pool is {Math.Floor((totalFill / v)*100)}% full. Pipe 1: {Math.Floor((firstPipeFill / totalFill) * 100)}%. Pipe 2: {Math.Floor((secondPipeFill / totalFill) * 100)}%.");
            }
            else
            {
                Console.WriteLine($"For {h} hours the pool overflows with {totalFill-v:f1} liters.");
            }
        }
    }
}
//20:31-20:46