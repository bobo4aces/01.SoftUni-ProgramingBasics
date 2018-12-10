using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wire_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            int areaLength = int.Parse(Console.ReadLine());
            int areaWidth = int.Parse(Console.ReadLine());
            double netHeight = double.Parse(Console.ReadLine());
            decimal netPricePerMeter = decimal.Parse(Console.ReadLine());
            double netWeightPerMeter = double.Parse(Console.ReadLine());
            double netLenght = 2*areaLength + 2* areaWidth;
            decimal netPrice = (decimal)netLenght * netPricePerMeter;
            double netS = netLenght * netHeight;
            double netWeight = netS * netWeightPerMeter;
            Console.WriteLine(netLenght);
            Console.WriteLine(netPrice.ToString("0.00"));
            Console.WriteLine(netWeight.ToString("0.000"));
        }
    }
}
