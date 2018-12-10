using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int coins1lv = int.Parse(Console.ReadLine());
            int coins2lv = int.Parse(Console.ReadLine());
            int bills5lv = int.Parse(Console.ReadLine());
            int total = int.Parse(Console.ReadLine());
            for (int i = 0; i <= coins1lv; i++)
            {
                for (int j = 0; j <= coins2lv; j++)
                {
                    for (int k = 0; k <= bills5lv; k++)
                    {
                        if (i*1+j*2+k* 5 == total)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {total} lv.");
                        }
                    }
                }
            }
        }
    }
}
