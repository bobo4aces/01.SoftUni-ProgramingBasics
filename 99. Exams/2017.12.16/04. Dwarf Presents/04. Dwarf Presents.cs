using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Dwarf_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            int dwarfCount = int.Parse(Console.ReadLine());
            int santasMoney = int.Parse(Console.ReadLine());
            int sandClocksCount = 0;
            int magnetsCount = 0;
            int cupsCount = 0;
            int tShirtCount = 0;
            for (int i = 0; i < dwarfCount; i++)
            {
                string present = Console.ReadLine();
                switch (present)
                {
                    case "sand clock":
                        sandClocksCount++;
                        break;
                    case "magnet":
                        magnetsCount++;
                        break;
                    case "cup":
                        cupsCount++;
                        break;
                    case "t-shirt":
                        tShirtCount++;
                        break;
                    default:
                        break;
                }
            }
            double totalPrice = sandClocksCount * 2.20 + magnetsCount * 1.50 + cupsCount * 5.00 + tShirtCount * 10.00;
            if (totalPrice<=santasMoney)
            {
                Console.WriteLine($"Santa Claus has {(santasMoney-totalPrice):f2} more leva left!");
            }
            else
            {
                Console.WriteLine($"Santa Claus will need {(totalPrice - santasMoney):f2} more leva.");
            }
            
        }
    }
}
