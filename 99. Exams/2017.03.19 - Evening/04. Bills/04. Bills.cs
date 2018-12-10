using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthCount = int.Parse(Console.ReadLine());
            double electricityCostForAllMonths = 0;
            double otherCostForAllMonths = 0;
            for (int i = 0; i < monthCount; i++)
            {
                double electricityCost = double.Parse(Console.ReadLine());
                electricityCostForAllMonths += electricityCost;
                otherCostForAllMonths += (20+15+electricityCost)+ ((20 + 15 + electricityCost)*0.2);
            }
            double waterCostForAllMonths = 20 * monthCount;
            double internetCostForAllMonths = 15 * monthCount;
            double averageCostPerMonth= (electricityCostForAllMonths+ waterCostForAllMonths+ internetCostForAllMonths+ otherCostForAllMonths)/ monthCount;
            Console.WriteLine($"Electricity: {electricityCostForAllMonths:f2} lv");
            Console.WriteLine($"Water: {waterCostForAllMonths:f2} lv");
            Console.WriteLine($"Internet: {internetCostForAllMonths:f2} lv");
            Console.WriteLine($"Other: {otherCostForAllMonths:f2} lv");
            Console.WriteLine($"Average: {averageCostPerMonth:f2} lv");
        }
    }
}
//20:01-20:26