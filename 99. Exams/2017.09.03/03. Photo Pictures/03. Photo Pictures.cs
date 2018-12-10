using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Photo_Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictureCount = int.Parse(Console.ReadLine());
            string pictureType = Console.ReadLine();
            string deliveryMethod = Console.ReadLine();
            decimal totalPrice = 0;
            if (pictureType == "9X13")
            {
                totalPrice = pictureCount * 0.16m;
                if (pictureCount>50)
                {
                    totalPrice = totalPrice - (totalPrice * 0.05m);
                }
            }
            else if (pictureType == "10X15")
            {
                totalPrice = pictureCount * 0.16m;
                if (pictureCount > 80)
                {
                    totalPrice = totalPrice - (totalPrice * 0.03m);
                }
            }
            else if (pictureType == "13X18")
            {
                totalPrice = pictureCount * 0.38m;
                if (pictureCount > 100)
                {
                    totalPrice = totalPrice - (totalPrice * 0.05m);
                }
                else if (pictureCount<=100&&pictureCount>=50)
                {
                    totalPrice = totalPrice - (totalPrice * 0.03m);
                }
            }
            else if (pictureType == "20X30")
            {
                totalPrice = pictureCount * 2.90m;
                if (pictureCount > 50)
                {
                    totalPrice = totalPrice - (totalPrice * 0.09m);
                }
                else if (pictureCount <= 50 && pictureCount >= 10)
                {
                    totalPrice = totalPrice - (totalPrice * 0.07m);
                }
            }
            if (deliveryMethod=="online")
            {
                totalPrice = totalPrice - (totalPrice * 0.02m);
            }
            Console.WriteLine($"{totalPrice.ToString("0.00")}BGN");
        }
    }
}
