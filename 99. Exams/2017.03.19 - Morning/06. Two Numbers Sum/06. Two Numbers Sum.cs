using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int intervalStart = int.Parse(Console.ReadLine());
            int intervalEnd = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combination = 0;
            for (int i = intervalStart; i >= intervalEnd; i--)
            {
                for (int j = intervalStart; j >= intervalEnd; j--)
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
//17:16-17:44
//15:56-17:44-1:48