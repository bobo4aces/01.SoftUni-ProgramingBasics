using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double excellentMark = 0.0;
            double veryGoodMark = 0.0;
            double goodMark = 0.0;
            double satisfactoryMark = 0.0;
            double poorMark = 0.0;
            for (int i = 0; i < n; i++)
            {
                double mark = double.Parse(Console.ReadLine());
                if (mark>76.5)
                {
                    excellentMark++;
                }
                else if (mark < 76.5&&mark> 58.5)
                {
                    veryGoodMark++;
                }
                else if (mark < 58.5 && mark > 40.5)
                {
                    goodMark++;
                }
                else if (mark < 40.5 && mark > 22.5)
                {
                    satisfactoryMark++;
                }
                else if (mark < 22.5)
                {
                    poorMark++;
                }
            }
            Console.WriteLine($"{(poorMark/n).ToString("0.00%")} poor marks");
            Console.WriteLine($"{(satisfactoryMark / n).ToString("0.00%")} satisfactory marks");
            Console.WriteLine($"{(goodMark / n).ToString("0.00%")} good marks");
            Console.WriteLine($"{(veryGoodMark / n).ToString("0.00%")} very good marks");
            Console.WriteLine($"{(excellentMark / n).ToString("0.00%")} excellent marks");
        }
    }
}
