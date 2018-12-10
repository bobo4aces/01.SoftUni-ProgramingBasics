using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char operatorType = char.Parse(Console.ReadLine());
            if (n2 == 0 && (operatorType == '/'|| operatorType == '%'))
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else
            {
                switch (operatorType)
                {
                    case '+':
                        if ((n1 + n2) %2==0)
                        {
                            Console.WriteLine($"{n1} {operatorType} {n2} = {n1 + n2} - even"); 
                        }
                        else
                        {
                            Console.WriteLine($"{n1} {operatorType} {n2} = {n1 + n2} - odd");
                        }
                        break;
                    case '-':
                        if((n1 - n2) % 2 == 0)
                        {
                            Console.WriteLine($"{n1} {operatorType} {n2} = {n1 - n2} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{n1} {operatorType} {n2} = {n1 - n2} - odd");
                        }
                        break;
                    case '*':
                        if ((n1 * n2) % 2 == 0)
                        {
                            Console.WriteLine($"{n1} {operatorType} {n2} = {n1 * n2} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{n1} {operatorType} {n2} = {n1 * n2} - odd");
                        }
                        break;
                    case '/':
                        Console.WriteLine($"{n1} / {n2} = {((double)n1 / n2):f2}");
                        break;
                    case '%':
                        Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
//20:25-20:43
//20:50-20:55
//00:41