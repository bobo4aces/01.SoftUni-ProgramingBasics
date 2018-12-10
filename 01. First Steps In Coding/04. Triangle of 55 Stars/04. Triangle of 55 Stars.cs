using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle_of_55_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            for (i = 1; i <= 10; i++)
            {
                string astericks = new string('*', i);
                Console.WriteLine(astericks);
            }
        }
    }
}
