using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallestRoomS = double.Parse(Console.ReadLine());
            double kitchenS = double.Parse(Console.ReadLine());
            double pricePerMeter = double.Parse(Console.ReadLine());
            double secondRoomS = smallestRoomS * 1.1;
            double thirdRoomS = secondRoomS * 1.1;
            double bathroomS = smallestRoomS / 2;
            double allRoomsS = smallestRoomS + kitchenS + secondRoomS + thirdRoomS + bathroomS;
            double coridor = allRoomsS * 0.05;
            double totalS = allRoomsS + coridor;
            double housePrice = totalS * pricePerMeter;
            Console.WriteLine($"{housePrice:f2}");
        }
    }
}
//20:36-20:43
