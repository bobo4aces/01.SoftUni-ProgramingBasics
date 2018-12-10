using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Tile_Repair
{
    class Program
    {
        static void Main(string[] args)
        {
            int tileSideLenght = int.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileLenght = double.Parse(Console.ReadLine());
            int benchWidth = int.Parse(Console.ReadLine());
            int benchLenght = int.Parse(Console.ReadLine());
            int totalS = tileSideLenght * tileSideLenght;
            int benchS = benchLenght * benchWidth;
            int coverS = totalS - benchS;
            double tileS = tileWidth * tileLenght;
            double tilesNeeded = coverS / tileS;
            double time = tilesNeeded * 0.2;
            Console.WriteLine($"{tilesNeeded:f2}");
            Console.WriteLine($"{time:f2}");
        }
    }
}
//20:07-20:15