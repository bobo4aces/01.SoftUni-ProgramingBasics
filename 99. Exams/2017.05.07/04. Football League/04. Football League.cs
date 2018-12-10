using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int fansCount = int.Parse(Console.ReadLine());
            int sectorA = 0;
            int sectorB = 0;
            int sectorV = 0;
            int sectorG = 0;
            for (int i = 0; i < fansCount; i++)
            {
                string sector=Console.ReadLine();
                switch (sector)
                {
                    case "A":
                        sectorA++;
                        break;
                    case "B":
                        sectorB++;
                        break;
                    case "V":
                        sectorV++;
                        break;
                    case "G":
                        sectorG++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"{(double)sectorA/fansCount*100:f2}%");
            Console.WriteLine($"{(double)sectorB /fansCount * 100:f2}%");
            Console.WriteLine($"{(double)sectorV /fansCount * 100:f2}%");
            Console.WriteLine($"{(double)sectorG / fansCount * 100:f2}%");
            Console.WriteLine($"{(double)fansCount / capacity * 100:f2}%");
        }
    }
}
