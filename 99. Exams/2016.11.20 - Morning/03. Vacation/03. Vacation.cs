using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int adultsCount = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());
            string transportType = Console.ReadLine();
            double price = 0;
            switch (transportType)
            {
                case "train":
                    price = 2*(24.99 * adultsCount + 14.99 * studentsCount);
                    break;
                case "bus":
                    price = 2 * (32.50 * adultsCount + 28.50 * studentsCount);
                    break;
                case "boat":
                    price = 2 * (42.99 * adultsCount + 39.99 * studentsCount);
                    break;
                case "airplane":
                    price = 2 * (70.00 * adultsCount + 50.00 * studentsCount);
                    break;
                default:
                    break;
            }
            if (adultsCount+studentsCount>=50&&transportType=="train")
            {
                price = price * 0.50;
            }
            double hotelPrice = 82.99 * nightsCount;
            double commission=(price+hotelPrice)*0.10;
            double totalPrice = price + hotelPrice + commission;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
//19:32-19:44