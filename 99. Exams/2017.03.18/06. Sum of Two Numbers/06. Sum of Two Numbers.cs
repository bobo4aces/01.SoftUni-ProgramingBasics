using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int intervalStart = int.Parse(Console.ReadLine());
            int intervalEnd = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combination = 0;
            for (int i = intervalStart; i <= intervalEnd; i++)
            {
                for (int j = intervalStart; j <= intervalEnd; j++)
                {
                    combination++;
                    if (i+j==magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combination} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
            }
            
            Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
        }
    }
}
//20:38-20:46
//15:58-20:46-4:00