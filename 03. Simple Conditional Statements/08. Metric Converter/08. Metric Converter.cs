using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            if (input == "mm")
            {
                num = num / 1000;
            }
            if (input == "cm")
            {
                num = num / 100;
            }
            if (input == "mi")
            {
                num = num / 0.000621371192;
            }
            if (input == "in")
            {
                num = num / 39.3700787;
            }
            if (input == "km")
            {
                num = num / 0.001;
            }
            if (input == "ft")
            {
                num = num / 3.2808399;
            }
            if (input == "yd")
            {
                num = num / 1.0936133;
            }
            if (output == "mm")
            {
                num = num * 1000;
            }
            if (output == "cm")
            {
                num = num * 100;
            }
            if (output == "mi")
            {
                num = num * 0.000621371192;
            }
            if (output == "in")
            {
                num = num * 39.3700787;
            }
            if (output == "km")
            {
                num = num * 0.001;
            }
            if (output == "ft")
            {
                num = num * 3.2808399;
            }
            if (output == "yd")
            {
                num = num * 1.0936133;
            }
            Console.WriteLine(num + " " + output);
        }
    }
}
