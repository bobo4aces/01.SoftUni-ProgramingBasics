using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int factoriel = 1;
            do
            {
                factoriel = factoriel * n;
                n--;
            } while (n > 1);
            Console.WriteLine(factoriel);
        }
    }
}
