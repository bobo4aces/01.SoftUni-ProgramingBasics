using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentsCount = int.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());
            double price = 0;
            string sport = "";
            if (season== "Winter")
            {
                if (groupType== "boys")
                {
                    price = studentsCount * nightsCount * 9.60;
                    sport = "Judo";
                }
                else if (groupType == "girls")
                {
                    price = studentsCount * nightsCount * 9.60;
                    sport = "Gymnastics";
                }
                else if (groupType == "mixed")
                {
                    price = studentsCount * nightsCount * 10;
                    sport = "Ski";
                }
            }
            else if (season == "Spring")
            {
                if (groupType == "boys")
                {
                    price = studentsCount * nightsCount * 7.20;
                    sport = "Tennis";
                }
                else if (groupType == "girls")
                {
                    price = studentsCount * nightsCount * 7.20;
                    sport = "Athletics";
                }
                else if (groupType == "mixed")
                {
                    price = studentsCount * nightsCount * 9.50;
                    sport = "Cycling";
                }
            }
            else if (season == "Summer")
            {
                if (groupType == "boys")
                {
                    price = studentsCount * nightsCount * 15;
                    sport = "Football";
                }
                else if (groupType == "girls")
                {
                    price = studentsCount * nightsCount * 15;
                    sport = "Volleyball";
                }
                else if (groupType == "mixed")
                {
                    price = studentsCount * nightsCount * 20;
                    sport = "Swimming";
                }
            }
            if (studentsCount>=50)
            {
                price = price * 0.50;
            }
            else if (20<=studentsCount&& studentsCount < 50)
            {
                price = price -(price * 0.15);
            }
            else if (10 <= studentsCount && studentsCount < 20)
            {
                price = price - (price * 0.05);
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
// 1 4as
//19:07