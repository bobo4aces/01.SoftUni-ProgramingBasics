using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthA = double.Parse(Console.ReadLine());
            double heightHouseB = double.Parse(Console.ReadLine());
            double allWalls = lengthA * (lengthA / 2) * 2;
            double square = (lengthA / 2) * (lengthA / 2);
            double triangle = (lengthA / 2 * (heightHouseB - lengthA / 2)) / 2;
            double backWall = square + triangle;
            double entrance = (lengthA / 5) * (lengthA / 5);
            double frontWall = backWall - entrance;
            double allWallsS = allWalls + backWall + frontWall;
            double greenPaintLitres = allWallsS / 3;
            double roof = lengthA * (lengthA / 2) * 2;
            double redPaintLitres = roof/5;
            Console.WriteLine($"{greenPaintLitres:f2}");
            Console.WriteLine($"{redPaintLitres:f2}");
        }
    }
}
//17:58-18:10