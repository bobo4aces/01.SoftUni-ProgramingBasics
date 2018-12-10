using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double taxiPrice = double.MaxValue;
            double busPrice = double.MaxValue;
            double trainPrice = double.MaxValue;
            double minPrice = double.MaxValue;
            if (n>=100)
            {
                trainPrice = n * 0.06;
                minPrice = trainPrice;
            }
            if (n >= 20)
            {
                busPrice = n * 0.09;
                if (busPrice<= minPrice)
                {
                    minPrice = busPrice;
                }
            }
            switch (time)
            {
                case "day":
                    taxiPrice = n * 0.79 + 0.70;
                    break;
                case "night":
                    taxiPrice = n * 0.90 + 0.70;
                    break;
                default:
                    break;
            }
            if (taxiPrice<= minPrice)
            {
                minPrice = taxiPrice;
            }
            Console.WriteLine(minPrice);
        }
    }
}
//20:16-20:33