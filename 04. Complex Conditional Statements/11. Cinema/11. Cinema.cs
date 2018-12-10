using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            if (type=="Premiere")
            {
                Console.WriteLine("{0:F2} leva",rows*columns*12);
            }
            else if (type == "Normal")
            {
                Console.WriteLine("{0:F2} leva", rows * columns * 7.5);
            }
            else if (type == "Discount")
            {
                Console.WriteLine("{0:F2} leva", rows * columns * 5);
            }
        }
    }
}
