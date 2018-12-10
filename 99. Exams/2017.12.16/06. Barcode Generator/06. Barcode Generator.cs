using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int final = int.Parse(Console.ReadLine());
            int startdigit4 = start % 10;
            int startdigit3 = (start / 10) % 10;
            int startdigit2 = (start / 100) % 10;
            int startdigit1 = (start / 1000) % 10;
            int finaldigit4 = final % 10;
            int finaldigit3 = (final / 10) % 10;
            int finaldigit2 = (final / 100) % 10;
            int finaldigit1 = (final / 1000) % 10;
            for (int i = startdigit1; i <= finaldigit1; i++)
            {
                for (int j = startdigit2; j <= finaldigit2; j++)
                {
                    for (int k = startdigit3; k <= finaldigit3; k++)
                    {
                        for (int l = startdigit4; l <= finaldigit4; l++)
                        {
                            if (i%2!=0&& j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
