using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalGlasses = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());
            int totalWorkingHours = 8 * workersCount * workingDays;
            double madeGlasses = Math.Floor(totalWorkingHours / 5.0);
            if (madeGlasses>=totalGlasses)
            {
                Console.WriteLine($"{ ((madeGlasses-totalGlasses) * 4.2).ToString("0.00") } extra money");
            }
            else
            {
                Console.WriteLine($"Losses: { ((totalGlasses-madeGlasses) * 4.2).ToString("0.00") }");
            }
            
        }
    }
}
//16:10-16:20