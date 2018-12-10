using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fruit_Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int drinksCount = int.Parse(Console.ReadLine());
            double price = 0;
            switch (fruit)
            {
                case "Watermelon":
                    if (size=="small")
                    {
                        price += 2 * 56* drinksCount;
                    }
                    else
                    {
                        price += 5 * 28.70* drinksCount;
                    }
                    break;
                case "Mango":
                    if (size == "small")
                    {
                        price += 2 * 36.66* drinksCount;
                    }
                    else
                    {
                        price += 5 * 19.60* drinksCount;
                    }
                    break;
                case "Pineapple":
                    if (size == "small")
                    {
                        price += 2 * 42.10* drinksCount;
                    }
                    else
                    {
                        price += 5 * 24.80* drinksCount;
                    }
                    break;
                case "Raspberry":
                    if (size == "small")
                    {
                        price += 2 * 20* drinksCount;
                    }
                    else
                    {
                        price += 5 * 15.20* drinksCount;
                    }
                    break;
                default:
                    break;
            }
            if (price>1000)
            {
                price = price * 0.5;
            }
            else if (400<=price&&price<=1000)
            {
                price = price -(price*0.15);
            }
            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
