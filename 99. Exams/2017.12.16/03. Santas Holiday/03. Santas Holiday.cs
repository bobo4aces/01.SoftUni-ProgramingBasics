using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Santas_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string mark = Console.ReadLine();
            double priceBeforeOff = 0;
            double priceOff = 0;
            if (type== "room for one person")
            {
                priceBeforeOff = (days-1) * 18;
            }
            else if (type == "apartment")
            {
                priceBeforeOff = (days - 1) * 25;
                if ((days - 1)<= 9)
                {
                    priceOff = priceBeforeOff * 0.30;
                }
                else if (10<= (days - 1)&& (days - 1)<=15)
                {
                    priceOff = priceBeforeOff * 0.35;
                }
                else if ((days-1)>=16)
                {
                    priceOff = priceBeforeOff * 0.50;
                }
            }
            else if (type == "president apartment")
            {
                priceBeforeOff = (days - 1) * 35;
                if ((days - 1) <= 9)
                {
                    priceOff = priceBeforeOff * 0.10;
                }
                else if (10 <= (days - 1) && (days - 1) <= 15)
                {
                    priceOff = priceBeforeOff * 0.15;
                }
                else if ((days - 1) >= 16)
                {
                    priceOff = priceBeforeOff * 0.20;
                }
            }
            double totalPrice = priceBeforeOff - priceOff;
            double price = 0;
            if (mark== "positive")
            {
                price = totalPrice + (totalPrice * 0.25);
            }
            else if (mark == "negative")
            {
                price = totalPrice - (totalPrice * 0.10);
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
