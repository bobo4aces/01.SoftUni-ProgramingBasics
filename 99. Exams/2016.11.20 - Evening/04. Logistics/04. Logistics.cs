using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int goodsCount = int.Parse(Console.ReadLine());
            int tonnes = 0;
            int tonnesMicrobus = 0;
            int tonnesTruck = 0;
            int tonnesTrain = 0;
            for (int i = 0; i < goodsCount; i++)
            {
                tonnes = int.Parse(Console.ReadLine());
                if (tonnes >= 12)
                {
                    tonnesTrain += tonnes;
                }
                else if (11 >= tonnes && tonnes >= 4)
                {
                    tonnesTruck += tonnes;
                }
                else
                {
                    tonnesMicrobus += tonnes;
                }
            }
            int totalPrice = tonnesMicrobus * 200 + tonnesTruck * 175 + tonnesTrain * 120;
            int totalTonnes = tonnesMicrobus + tonnesTruck + tonnesTrain;
            double averagePricePerTonne = totalPrice / (double)totalTonnes;
            Console.WriteLine($"{averagePricePerTonne:f2}");
            Console.WriteLine($"{(double)tonnesMicrobus / totalTonnes * 100:f2}%");
            Console.WriteLine($"{(double)tonnesTruck / totalTonnes * 100:f2}%");
            Console.WriteLine($"{(double)tonnesTrain / totalTonnes * 100:f2}%");
        }
    }
}
//19:10-19:38-20:04