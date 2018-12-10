using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int moves = 0;
            for (int numberN = 1; numberN <= n; numberN++)
            {
                for (int numberM = m; numberM >= 1; numberM--)
                {
                    sum += numberN * 2 + numberM * 3;
                    moves++;
                    if (sum >= controlNumber)
                    {
                        Console.WriteLine($"{moves} moves");
                        Console.WriteLine($"Score: {sum} >= {controlNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{moves} moves");
        }
    }
}
//20:43-20:54
//19:30-20:54-1:24