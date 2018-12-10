using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            double houseSquare = double.Parse(Console.ReadLine());
            int windowsCount = int.Parse(Console.ReadLine());
            double styrofoamPerPacket = double.Parse(Console.ReadLine());
            double styrofoamPacketPrice = double.Parse(Console.ReadLine());
            double houseSquareWithoutWindows = (houseSquare - (windowsCount * 2.4))*1.1;
            double packetsNeeded = Math.Ceiling(houseSquareWithoutWindows / styrofoamPerPacket);
            double packetsPrice = packetsNeeded * styrofoamPacketPrice;
            if (budjet>=packetsPrice)
            {
                Console.WriteLine($"Spent: {packetsPrice:f2}");
                Console.WriteLine($"Left: {(budjet - packetsPrice):f2}");
            }
            else
            {
                Console.WriteLine($"Need more: {(packetsPrice - budjet):f2}");
            }
            
        }
    }
}
//19:43-19:54