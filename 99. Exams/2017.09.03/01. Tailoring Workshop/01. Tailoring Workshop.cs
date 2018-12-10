using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double s = tables * (length + 2 * 0.3) * (width + 2 * 0.3);
            double s1 = tables * (length / 2) * (length / 2);
            double usd = s * 7 + s1 * 9;
            double bgn = usd * 1.85;
            Console.WriteLine($"{Math.Round(usd, 2).ToString("0.00")} USD");
            Console.WriteLine($"{Math.Round(bgn, 2).ToString("0.00")} BGN");

        }
    }
}
