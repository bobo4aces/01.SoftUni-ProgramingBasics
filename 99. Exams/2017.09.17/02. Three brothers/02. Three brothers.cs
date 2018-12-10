using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal time1 = decimal.Parse(Console.ReadLine());
            decimal time2 = decimal.Parse(Console.ReadLine());
            decimal time3 = decimal.Parse(Console.ReadLine());
            decimal time4 = decimal.Parse(Console.ReadLine());
            decimal overallTime = 1 / (1 / time1 + 1 / time2 + 1 / time3);
            decimal cleaningTime = overallTime * 1.15m;
            Console.WriteLine("Cleaning time: {0}", Math.Round(cleaningTime, 2));
            decimal hours = Math.Round(time4, 2) - Math.Round(cleaningTime, 2);
            if (hours >= 0)
            {
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Abs(Math.Floor(hours)));
            }
            else
            {
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Abs(Math.Floor(hours)));
            }
        }
    }
}
