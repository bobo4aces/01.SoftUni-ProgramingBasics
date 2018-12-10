using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Smart_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int lillyAge = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int pricePerSingleToy = int.Parse(Console.ReadLine());
            double savedMoney = 0;
            double takenMoney = 0;
            int toysCount = 0;
            for (int i = 1; i <= lillyAge; i++)
            {
                if (i%2==0)
                {
                    savedMoney += (i/2)*10;
                    takenMoney++;
                }
                else
                {
                    toysCount++;
                }
            }
            double savedMoneyFromToys = toysCount * pricePerSingleToy;
            double totalSavedMoney = savedMoney + savedMoneyFromToys-takenMoney;
            if (totalSavedMoney>=washingMachinePrice)
            {
                Console.WriteLine($"Yes! {(totalSavedMoney-washingMachinePrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMachinePrice- totalSavedMoney):f2}");
            }
        }
    }
}
//19:01-19:24