using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double availableWeekends = (48-h)*3/4+h;
            double avalableHolidays = p *2/3;
            if (year=="leap")
            {
                Console.WriteLine("{0:F0}",Math.Floor((availableWeekends+avalableHolidays)*1.15));
            }
            else if (year == "normal")
            {
                Console.WriteLine("{0:F0}", Math.Floor(availableWeekends + avalableHolidays));
            }
        }
    }
}
