using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            char bigLetter = char.Parse(Console.ReadLine());
            char smallLetter1 = char.Parse(Console.ReadLine());
            char smallLetter2 = char.Parse(Console.ReadLine());
            char smallLetter3 = char.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int b = 'A'; b <= bigLetter; b++)
            {
                for (int s1 = 'a'; s1 <= smallLetter1; s1++)
                {
                    
                    for (int s2 = 'a'; s2 <= smallLetter2; s2++)
                    {
                        
                        for (int s3 = 'a'; s3 <= smallLetter3; s3++)
                        {
                            
                            for (int n = 0; n <= number; n++)
                            {
                                counter++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter-1);
        }
    }
}
