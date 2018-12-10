using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            for (int i = 1111; i <= 9999; i++)
            {
                n4 = i % 10;
                n3 = (i / 10)%10;
                n2 = (i / 100) % 10;
                n1 = (i / 1000) % 10;
                if (n1+n2==n3+n4&&n% (n1 + n2) == 0&&n1!=0&&n2!=0&&n3!=0&&n4!=0)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
