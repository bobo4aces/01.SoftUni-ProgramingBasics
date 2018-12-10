using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());
            double stepsPerDay = Math.Ceiling((steps / days) / steps*100);
            double percentSteps = stepsPerDay / dancers;
            if (stepsPerDay<=13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {percentSteps.ToString("0.00")}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {percentSteps.ToString("0.00")}% steps to be learned per day.");
            }
            
        }
    }
}
