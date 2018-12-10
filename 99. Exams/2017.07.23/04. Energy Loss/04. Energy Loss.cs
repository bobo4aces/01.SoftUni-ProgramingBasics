using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Energy_Loss
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int totalEnergy = 100 * a * n;
            int wastedEnergy = 0;
            for (int i = 1; i <= n; i++)
            {
                int hours = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    if (hours%2==0)
                    {
                        wastedEnergy += a*68;
                    }
                    else
                    {
                        wastedEnergy += a * 65;
                    }
                }
                else
                {
                    if (hours % 2 == 0)
                    {
                        wastedEnergy += a * 49;
                    }
                    else
                    {
                        wastedEnergy += a * 30;
                    }
                }
            }
            double totalWastedEnergy = totalEnergy-wastedEnergy;
            double energyLeft = totalWastedEnergy / a / n;
            if (energyLeft>50)
            {
                Console.WriteLine($"They feel good! Energy left: {energyLeft.ToString("0.00")}");
            }
            else
            {
                Console.WriteLine($"They are wasted! Energy left: {energyLeft.ToString("0.00")}");
            }
            
        }
    }
}
