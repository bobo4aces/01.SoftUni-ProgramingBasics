using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;
            if (month=="May"|| month == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                apartmentPrice = 77;
            }
            if (nightsCount>=15)
            {
                apartmentPrice = apartmentPrice - (apartmentPrice * 0.1);
            }
            if (nightsCount >= 15&&(month == "June" || month == "September"))
            {
                studioPrice = studioPrice - (studioPrice*0.20);
            }
            if (nightsCount >= 15 && (month == "May" || month == "October"))
            {
                studioPrice = studioPrice - (studioPrice * 0.30);
            }
            if ((14>=nightsCount&& nightsCount >= 8) && (month == "May" || month == "October"))
            {
                studioPrice = studioPrice - (studioPrice * 0.05);
            }
            Console.WriteLine($"Apartment: {(apartmentPrice*nightsCount):f2} lv.");
            Console.WriteLine($"Studio: {(studioPrice * nightsCount):f2} lv.");
        }
    }
}
//19:54-20:21
//00:54