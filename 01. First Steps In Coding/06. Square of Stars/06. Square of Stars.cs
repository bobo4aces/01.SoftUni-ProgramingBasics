using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string firstRow = new String('*', n);
            Console.WriteLine(firstRow);
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('*');
                Console.Write(new String(' ', n - 2));
                Console.WriteLine('*');
            }
            string lastRow = firstRow;
            Console.WriteLine(lastRow);
        }
    }
}
