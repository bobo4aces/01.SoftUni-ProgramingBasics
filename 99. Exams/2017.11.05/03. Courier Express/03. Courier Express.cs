using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string serviceType = Console.ReadLine().ToLower();
            double distance = double.Parse(Console.ReadLine());
            double price = 0.0;
            if (serviceType=="standard")
            {
                
                if (weight > 91.0)
                {
                    price += distance * 0.20;
                }
                else if (weight > 41.0 &&weight< 91.0)
                {
                    price += distance * 0.15;
                }
                else if (weight > 11.0 && weight < 41.0)
                {
                    price += distance * 0.10;
                }
                else if (weight > 1.0 && weight < 11.0)
                {
                    price += distance * 0.05;
                }
                else
                {
                    price += distance * 0.03;
                }
            }
            else if (serviceType == "express")
            {
                
                if (weight > 91.0)
                {
                    price += ((distance * ((0.20 * 0.01) * weight))) + (distance * 0.20);
                }
                else if (weight > 41.0 && weight < 91.0)
                {
                    price += ((distance * ((0.15 * 0.02) * weight))) + (distance * 0.15);
                }
                else if (weight > 11.0 && weight < 41.0)
                {
                    price += ((distance * ((0.10 * 0.05) * weight))) + (distance * 0.10);
                }
                else if (weight > 1.0 && weight < 11.0)
                {
                    price += ((distance * ((0.05 * 0.40) * weight))) + (distance * 0.05);
                }
                else
                {
                    price += ((distance * ((0.05 * 0.80) * weight))) + (distance * 0.05);
                }
            }
            Console.WriteLine($"The delivery of your shipment with weight of {weight.ToString("0.000")} kg. would cost {price.ToString("0.00")} lv.");
        }
    }
}
