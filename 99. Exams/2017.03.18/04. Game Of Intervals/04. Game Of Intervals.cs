using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int allMovesCount = int.Parse(Console.ReadLine());
            double result = 0;
            int from0To9 = 0;
            int from10To19 = 0;
            int from20To29 = 0;
            int from30To39 = 0;
            int from40To50 = 0;
            int invalidNumbers = 0;
            for (int i = 0; i < allMovesCount; i++)
            {
                int interval = int.Parse(Console.ReadLine());
                if (0<=interval&&interval<=9)
                {
                    from0To9++;
                    result += interval * 0.2;
                }
                else if (10 <= interval && interval <= 19)
                {
                    from10To19++;
                    result += interval * 0.3;
                }
                else if (20 <= interval && interval <= 29)
                {
                    from20To29++;
                    result += interval * 0.4;
                }
                else if (30 <= interval && interval <= 39)
                {
                    from30To39++;
                    result += 50;
                }
                else if (40 <= interval && interval <= 50)
                {
                    from40To50++;
                    result += 100;
                }
                else
                {
                    invalidNumbers++;
                    result /= 2;
                }
            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {((from0To9/(double)allMovesCount)*100.0):f2}%");
            Console.WriteLine($"From 10 to 19: {((from10To19/(double)allMovesCount)*100.0):f2}%");
            Console.WriteLine($"From 20 to 29: {((from20To29/(double)allMovesCount)*100.0):f2}%");
            Console.WriteLine($"From 30 to 39: {((from30To39/(double)allMovesCount)*100.0):f2}%");
            Console.WriteLine($"From 40 to 50: {((from40To50/ (double)allMovesCount)*100.0):f2}%");
            Console.WriteLine($"Invalid numbers: {((invalidNumbers/ (double)allMovesCount)*100.0):f2}%");
        }
    }
}
//18:32-18:44
//19:32-19:54