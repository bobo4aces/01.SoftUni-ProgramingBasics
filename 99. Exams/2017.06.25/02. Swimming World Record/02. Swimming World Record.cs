using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Swimming_World_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());
            double ivanchosTime = distance * timePerMeter;
            double additionalTime=Math.Floor((distance / 15)) * 12.5;
            double time = ivanchosTime + additionalTime;
            double secondsNeeded = time - record;
            if (time<record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {time.ToString("0.00")} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {secondsNeeded.ToString("0.00")} seconds slower.");
            }
            
        }
    }
}
