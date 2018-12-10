using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriaPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKilograms = double.Parse(Console.ReadLine());
            double safridKilograms = double.Parse(Console.ReadLine());
            double midiKilograms = double.Parse(Console.ReadLine());
            double palamudPrice = skumriaPrice * 1.6;
            double safridPrice = cacaPrice * 1.8;
            double palamudSum = palamudKilograms * palamudPrice;
            double safridSum = safridKilograms * safridPrice;
            double midiSum = midiKilograms * 7.5;
            double totalSum = palamudSum + safridSum + midiSum;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
//20:36-20:43