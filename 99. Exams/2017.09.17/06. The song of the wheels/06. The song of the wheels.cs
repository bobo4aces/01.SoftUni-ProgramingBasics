using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int ab = 0;
            int bc = 0;
            int cd = 0;
            string password = "";
            int counter=0;
            for (int i = 1111; i <= 9999; i++)
            {
                //a = i % 10;
                //ab = i / 10;
                //b = ab % 10;
                //bc = i / 100;
                //c = bc % 10;
                //cd = i / 1000;
                //d = cd % 10;
                d = i % 10;
                cd = i / 10;
                c = cd % 10;
                bc = i / 100;
                b = bc % 10;
                ab = i / 1000;
                a = ab % 10;
                if (a<b&&c>d&&a!=0&&b != 0&&c != 0&& d != 0)
                {
                    if (m==a*b+c*d)
                    {
                        Console.Write($"{a}{b}{c}{d} ");
                        counter++;
                        if (counter == 4)
                        {
                            password += $"{a}{b}{c}{d}";
                        }
                    }
                    
                }
                
            }
            Console.WriteLine();
            if (password!="")
            {
                Console.WriteLine($"Password: {password}");
            }
            else
            {
                Console.WriteLine("No!");
            }
            
        }
    }
}
