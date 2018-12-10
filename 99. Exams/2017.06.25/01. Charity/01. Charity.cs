using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int chiefs = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            int cakesPerChief = cakes * 45;
            double wafflesPerChief = waffles * 5.80;
            double pancakesPerChief = pancakes * 3.20;
            double moneyPerDay = (cakesPerChief + wafflesPerChief + pancakesPerChief)*chiefs;
            double money = moneyPerDay * days;
            double moneyLeft = money - (money / 8);
            Console.WriteLine(moneyLeft.ToString("0.00"));
        }
    }
}
