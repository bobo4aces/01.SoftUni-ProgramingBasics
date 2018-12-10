using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int speakingDollsCount = int.Parse(Console.ReadLine());
            int teddyBearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());
            double puzzlePrice = 2.60;
            double speakingDollsPrice = 3;
            double teddyBearsPrice = 4.1;
            double minionsPrice = 8.20;
            double trucksPrice = 2;
            double money = puzzlePrice * puzzleCount + speakingDollsPrice * speakingDollsCount + teddyBearsPrice * teddyBearsCount + minionsPrice * minionsCount + trucksPrice * trucksCount;
            int toysCount = puzzleCount + speakingDollsCount + teddyBearsCount + minionsCount + trucksCount;
            if (toysCount>=50)
            {
                money=money-(money*0.25);
            }
            double moneyLeft = money - (money * 0.10);
            if (moneyLeft >= excursionPrice)
            {
                Console.WriteLine($"Yes! {(moneyLeft - excursionPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(excursionPrice- moneyLeft):f2} lv needed.");
            }
            
        }
    }
}
