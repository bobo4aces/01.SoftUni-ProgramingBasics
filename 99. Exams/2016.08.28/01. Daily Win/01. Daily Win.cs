using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Daily_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDaysPerMonth = int.Parse(Console.ReadLine());
            double earnedMoneyPerDay = double.Parse(Console.ReadLine());
            double exchangeRate = double.Parse(Console.ReadLine());
            double monthlyPayment = workingDaysPerMonth * earnedMoneyPerDay;
            double yearlyPayment = monthlyPayment * 14.5;
            double tax = yearlyPayment * 0.25;
            double totalPayment = yearlyPayment - tax;
            double totalPaymentInBGN = totalPayment * exchangeRate;
            double averageEarningsPerDay = totalPaymentInBGN / 365;
            Console.WriteLine($"{averageEarningsPerDay:f2}");
        }
    }
}
//20:41-20:58