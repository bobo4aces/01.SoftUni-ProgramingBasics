using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int col = 0; col <n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    if (row + col + 1<=n)
                    {
                        Console.Write($"{row + col + 1} ");
                    }
                    else
                    {
                        Console.Write($"{2 *n-(row+col+1)} ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
