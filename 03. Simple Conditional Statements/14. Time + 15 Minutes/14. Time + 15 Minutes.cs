using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            if (minutes >= 45)
            {
                hours = hours + 1;
                minutes = minutes - 45;
            }
            else
            {
                minutes = minutes + 15;
            }
            if (hours >= 24)
            {
                hours = 0;
            }
            if (minutes < 10)
            {
                Console.WriteLine(hours + ":0" + minutes);
            }
            else
            {
                Console.WriteLine(hours + ":" + minutes);
            }
        }
    }
}
