using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            for (int num1 = m; num1 >=1; num1--)
            {
                for (int num2 = n; num2 >= 1; num2--)
                {
                    for (int num3 = l; num3 >= 1; num3--)
                    {
                        if ((num1*100+num2*10+num3)%3==0)
                        {
                            specialNumber += 5;
                        }
                        else if (num3==5)
                        {
                            specialNumber -= 2;
                        }
                        else if ((num1 * 100 + num2 * 10 + num3) % 2 == 0)
                        {
                            specialNumber *= 2;
                        }
                        if (specialNumber >= controlNumber)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
                            return;
                        }
                    }
                }  
            }
            Console.WriteLine($"No! {specialNumber} is the last reached special number.");
        }
    }
}
