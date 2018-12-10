using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometersPerMonth = double.Parse(Console.ReadLine());
            double driverSalary = 0;
            if (kilometersPerMonth <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                        driverSalary = kilometersPerMonth * 0.75;
                        break;
                    case "Summer":
                        driverSalary = kilometersPerMonth * 0.90;
                        break;
                    case "Autumn":
                        driverSalary = kilometersPerMonth * 0.75;
                        break;
                    case "Winter":
                        driverSalary = kilometersPerMonth * 1.05;
                        break;
                    default:
                        break;
                }
            }
            else if (5000 < kilometersPerMonth&&kilometersPerMonth <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                        driverSalary = kilometersPerMonth * 0.95;
                        break;
                    case "Summer":
                        driverSalary = kilometersPerMonth * 1.10;
                        break;
                    case "Autumn":
                        driverSalary = kilometersPerMonth * 0.95;
                        break;
                    case "Winter":
                        driverSalary = kilometersPerMonth * 1.25;
                        break;
                    default:
                        break;
                }
            }
            else if (10000 < kilometersPerMonth&& kilometersPerMonth <= 20000)
            {
                driverSalary = kilometersPerMonth * 1.45;        
            }
            double driverSalaryAfterTaxes = (driverSalary * 4) - (driverSalary * 4 * 0.1);
            Console.WriteLine($"{driverSalaryAfterTaxes:f2}");
        }
    }
}
//20:01-20:14