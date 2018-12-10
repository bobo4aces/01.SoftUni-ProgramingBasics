using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Divide
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number%2==0)
                {
                    counter2++;
                }
                if (number % 3 == 0)
                {
                    counter3++;
                }
                if (number % 4 == 0)
                {
                    counter4++;
                }
            }
            Console.WriteLine($"{((double)counter2/n*100):f2}%");
            Console.WriteLine($"{((double)counter3 / n * 100):f2}%");
            Console.WriteLine($"{((double)counter4 / n * 100):f2}%");
        }
    }
}
//19:36-19:43