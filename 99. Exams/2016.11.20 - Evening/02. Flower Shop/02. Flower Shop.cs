using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnoliiCount = int.Parse(Console.ReadLine());
            int ziumbiuliCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int cactusesCount = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());
            double sum = (magnoliiCount * 3.25+ ziumbiuliCount*4+ rosesCount*3.5+ cactusesCount*8)*0.95;
            if (giftPrice <= sum)
            {
                Console.WriteLine($"She is left with {Math.Floor(sum - giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice- sum)} leva.");
            }
            
        }
    }
}
//20:43-20:59
//00:23