using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Money_Prize
{
    class Program
    {
        static void Main(string[] args)
        {
            int projectParts = int.Parse(Console.ReadLine());
            double moneyPrizePerPoint=double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= projectParts; i++)
            {
                int points = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    sum += points *2;
                }
                else
                {
                    sum += points;
                }
            }
            double prize = sum * moneyPrizePerPoint;
            Console.WriteLine($"The project prize was {prize:f2} lv.");
        }
    }
}
