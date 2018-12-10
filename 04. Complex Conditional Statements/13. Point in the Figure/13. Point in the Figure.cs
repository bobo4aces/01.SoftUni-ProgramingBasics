using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int upperX = 2 * h;
            int upperY = 4 * h;
            int lowerX = upperX;
            int lowerY = h;
            int uppX = 3 * h;
            int uppY = h;
            int lowX = 0;
            int lowY = 0;
        }
    }
}
