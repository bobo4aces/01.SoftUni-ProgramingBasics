using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal inch = decimal.Parse(Console.ReadLine());
            decimal cm = inch * (decimal)2.54;
            Console.WriteLine(cm);
        }
    }
}
