using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sleepy_Cat_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeDaysCount = int.Parse(Console.ReadLine());
            int freeDaysPlay = freeDaysCount * 127;
            int workingDaysCount = 365 - freeDaysCount;
            int workingDaysPlay = workingDaysCount * 63;
            int totalPlay = freeDaysPlay + workingDaysPlay;
            if (totalPlay>=30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{(totalPlay - 30000) / 60} hours and {(totalPlay - 30000) % 60} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{(30000 - totalPlay) / 60} hours and {(30000 - totalPlay) % 60} minutes less for play");
            }
            
        }
    }
}
//20:15-20:25