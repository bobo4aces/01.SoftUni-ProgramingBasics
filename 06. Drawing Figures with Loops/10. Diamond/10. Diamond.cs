using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstRow = (n - 1) / 2;
            int secondRow = 1;
            int thirdRow = n - 2 * (((n - 1) / 2) - 2);
            int forthRow = 1;
            int fifthRow = (n - 1) / 2;
            Console.WriteLine($"{ firstRow}+{ secondRow}+{ thirdRow}+{ forthRow}+{ fifthRow}");
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', firstRow-i));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', thirdRow));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('-', fifthRow-i));
            }
        }
    }
}
