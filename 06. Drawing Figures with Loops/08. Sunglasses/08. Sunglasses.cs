using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //upper
            Console.Write(new string ('*',2*n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
            //middle
            for (int i = 0; i < n - 2; i++)
            {


                Console.Write(new string('*', 1));
                Console.Write(new string('/', 2 * n - 2));
                Console.Write(new string('*', 1));
            
                if (i==(n - 1) / 2 - 1)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
            
                Console.Write(new string('*', 1));
                Console.Write(new string('/', 2 * n - 2));
                Console.WriteLine(new string('*', 1));
                
            }

            //lower
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));

        }
    }
}
