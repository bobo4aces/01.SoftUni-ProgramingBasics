using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char intervalStart = char.Parse(Console.ReadLine());
            char intervalEnd = char.Parse(Console.ReadLine());
            char intervalMiss = char.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = intervalStart; i <= intervalEnd; i++)
            {
                for (int j = intervalStart; j <= intervalEnd; j++)
                {
                    for (int k = intervalStart; k <= intervalEnd; k++)
                    {
                        if (i!=intervalMiss && j != intervalMiss && k != intervalMiss)
                        {
                            counter++;
                            Console.Write($"{(char)i}{(char)j}{(char)k} ");
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
//19:06-20:31
//2:57