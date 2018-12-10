using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string form = Console.ReadLine();
            if (form == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double s = a * a;
                Console.WriteLine(Math.Round(s, 3));
            }
            if (form == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double s = a * b;
                Console.WriteLine(Math.Round(s, 3));
            }
            if (form == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double s = Math.PI * r * r;
                Console.WriteLine(Math.Round(s, 3));
            }
            if (form == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double s = (a * b) / 2;
                Console.WriteLine(Math.Round(s, 3));
            }
        }
    }
}
