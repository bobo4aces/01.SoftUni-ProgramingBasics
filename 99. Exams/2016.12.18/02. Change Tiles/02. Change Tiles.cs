using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double savedMoney = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLength = double.Parse(Console.ReadLine());
            double triangleWall = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double pricePerTile = double.Parse(Console.ReadLine());
            double sumForWorker = double.Parse(Console.ReadLine());
            double floorS = floorWidth * floorLength;
            double tileS = triangleWall * triangleHeight / 2;
            double tilesNeeded = Math.Ceiling(floorS / tileS) + 5;
            double totalSum = tilesNeeded * pricePerTile + sumForWorker;
            if (savedMoney>=totalSum)
            {
                Console.WriteLine($"{(savedMoney-totalSum):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {(totalSum-savedMoney):f2} lv more.");
            }
            
        }
    }
}
//21:07-21:20