using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            while (number<=n)
            {
                Console.WriteLine(number);
                number = number * 2 + 1;
            }
        }
    }
}
