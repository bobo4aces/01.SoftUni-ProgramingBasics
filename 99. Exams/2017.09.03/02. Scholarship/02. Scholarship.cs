using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dohod = decimal.Parse(Console.ReadLine());
            decimal uspeh = decimal.Parse(Console.ReadLine());
            decimal zaplata = decimal.Parse(Console.ReadLine());
            decimal socialnaStipendiq = 0m;
            decimal stipendiq = 0m;
            if (uspeh>=5.5m)
            {
                stipendiq += uspeh * 25m;
            }
            if (uspeh>=4.5m&&dohod<zaplata)
            {
                socialnaStipendiq += zaplata * 0.35m;
            }
            if (socialnaStipendiq == 0m && stipendiq == 0m)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (socialnaStipendiq>stipendiq)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Round(socialnaStipendiq, 0, MidpointRounding.ToEven)} BGN");
            }
            else
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Round(stipendiq, 0, MidpointRounding.ToEven)} BGN");
            }
            
            
                    
            
        }
    }
}
