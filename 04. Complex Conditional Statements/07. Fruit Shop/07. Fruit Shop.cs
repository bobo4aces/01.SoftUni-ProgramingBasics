﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            if (day=="Monday"|| day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit=="banana")
                {
                    Console.WriteLine((quantity* 2.50).ToString("0.00"));
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine((quantity * 1.20).ToString("0.00"));
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine((quantity * 0.85).ToString("0.00"));
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine((quantity * 1.45).ToString("0.00"));
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine((quantity * 2.70).ToString("0.00"));
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine((quantity * 5.50).ToString("0.00"));
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine((quantity * 3.85).ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine((quantity * 2.70).ToString("0.00"));
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine((quantity * 1.25).ToString("0.00"));
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine((quantity * 0.90).ToString("0.00"));
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine((quantity * 1.60).ToString("0.00"));
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine((quantity * 3.00).ToString("0.00"));
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine((quantity * 5.60).ToString("0.00"));
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine((quantity * 4.20).ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}