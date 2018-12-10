using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSpeed = int.Parse(Console.ReadLine());
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            double firstDistance = firstSpeed * (firstTime / 60.0);
            double secondSpeed = firstSpeed * 1.1;
            double secondDistance = (secondSpeed) * (secondTime / 60.0);
            double thirdSpeed = secondSpeed * 0.95;
            double thirdDistance = thirdSpeed * (thirdTime / 60.0);
            double kilometers = firstDistance + secondDistance + thirdDistance;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
//20:53-21:06