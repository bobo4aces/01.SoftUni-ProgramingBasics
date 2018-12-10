using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double sideWallS = x * y;
            double windowS = 1.5 * 1.5;
            double allSideWallS = (2 * sideWallS) - (2 * windowS);
            double backWall = x * x;
            double entrance = 1.2 * 2;
            double frontAndBackWalls = 2 * backWall - entrance;
            double totalWallS = allSideWallS + frontAndBackWalls;
            double greenPaintLiters = totalWallS / 3.4;
            double roofSquares = 2 * x * y;
            double roofTriangles = 2 * (x * h / 2);
            double totalRoofS = roofSquares + roofTriangles;
            double redPaintLiters = totalRoofS / 4.3;
            Console.WriteLine($"{greenPaintLiters:f2}");
            Console.WriteLine($"{redPaintLiters:f2}");
        }
    }
}
//15:56-16:09