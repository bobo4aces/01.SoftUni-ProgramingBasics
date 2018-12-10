using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            double moneyLeft = 0;
            for (int i = 1800; i <= yearToLive; i++)
            {
                if (i%2==0)
                {
                    money = money - 12000;
                }
                else
                {
                    money = money - (12000 + (((18+(i - 1800))*50)));
                }
            }
            if (money>=0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive.");
            }
            
        }
    }
}
//10:59-11:10