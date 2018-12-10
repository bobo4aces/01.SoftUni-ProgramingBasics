using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            for (int i = 1; i <=number; i++)
            {
                int writtenNumber = int.Parse(Console.ReadLine());
                if (writtenNumber<min)
                {
                    min = writtenNumber;
                }
            }
            Console.WriteLine(min);
        }
    }
}
