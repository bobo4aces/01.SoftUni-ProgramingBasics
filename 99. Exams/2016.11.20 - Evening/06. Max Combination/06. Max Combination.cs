using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int intervalStart = int.Parse(Console.ReadLine());
            int intervalEnd = int.Parse(Console.ReadLine());
            int maxCombinations = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = intervalStart; i <= intervalEnd; i++)
            {
                for (int j = intervalStart; j <= intervalEnd; j++)
                {
                    counter++;
                    if (counter<= maxCombinations)
                    {
                        Console.Write($"<{i}-{j}>");
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
//20:46-20:32