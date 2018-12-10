using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            int p3 = int.Parse(Console.ReadLine());
            int sec = p1 + p2 + p3;
            int min = 0;
            if (sec > 59)
            {
                min++; sec = sec - 60;
            }
            if (sec > 59)
            {
                min++; sec = sec - 60;
            }
            if (sec > 59)
            {
                min++; sec = sec - 60;
            }
            if (sec < 10)
            {
                Console.WriteLine(min + ":0" + sec);
            }
            else
            {
                Console.WriteLine(min + ":" + sec);
            }
        }
    }
}
