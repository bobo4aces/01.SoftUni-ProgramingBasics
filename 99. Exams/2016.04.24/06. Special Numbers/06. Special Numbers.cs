using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int n1 = 1; n1 <= 9; n1++)
            {
                for (int n2 = 1; n2 <= 9; n2++)
                {
                    for (int n3 = 1; n3 <= 9; n3++)
                    {
                        for (int n4 = 1; n4 <= 9; n4++)
                        {
                            if (n%n1==0&& n % n2 == 0 && n % n3 == 0 && n % n4 == 0)
                            {
                                Console.Write($"{n1}{n2}{n3}{n4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
//20:01-20:06
//01:30