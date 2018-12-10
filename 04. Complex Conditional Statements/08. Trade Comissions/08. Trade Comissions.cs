using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            if (town == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine((sales * 0.05).ToString("0.00"));
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine((sales * 0.07).ToString("0.00"));
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine((sales * 0.08).ToString("0.00"));
                }
                else if (sales > 10000)
                {
                    Console.WriteLine((sales * 0.12).ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine((sales * 0.045).ToString("0.00"));
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine((sales * 0.075).ToString("0.00"));
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine((sales * 0.10).ToString("0.00"));
                }
                else if (sales > 10000)
                {
                    Console.WriteLine((sales * 0.13).ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine((sales * 0.055).ToString("0.00"));
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine((sales * 0.08).ToString("0.00"));
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine((sales * 0.12).ToString("0.00"));
                }
                else if (sales > 10000)
                {
                    Console.WriteLine((sales * 0.145).ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
