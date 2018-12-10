using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isItInt = true;
            int number;
            do
            {
                Console.Write("Enter even number: ");
                var n = Console.ReadLine();
                
                isItInt = int.TryParse(n, out number);
                if (isItInt == false)
                {
                    Console.WriteLine("Invalid number!");
                }
                else if (number % 2 == 0)
                {
                    Console.WriteLine($"Even number entered: {n}");
                }
                else
                {
                    Console.WriteLine("The number is not even.");
                }
            } while (isItInt==false||number%2==1);
            
        }
    }
}
