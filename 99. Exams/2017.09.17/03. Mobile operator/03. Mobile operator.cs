using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string lenght = Console.ReadLine().ToLower();
            string type = Console.ReadLine().ToLower();
            string internet = Console.ReadLine().ToLower();
            decimal months = decimal.Parse(Console.ReadLine());
            decimal price = 0.0m;
            if (lenght == "one")
            {
                
                    if (type == "small")
                    {
                        price += 9.98m;

                    }
                    if (type == "middle")
                    {
                        price += 18.99m;
                    }
                    if (type == "large")
                    {
                        price += 25.98m;
                    }
                    if (type == "extralarge")
                    {
                        price += 35.99m;
                    }
                
                    if (internet == "yes")
                    {
                        if (price <= 10.0m)
                        {
                            price += 5.5m;
                        }
                        else
                        {
                            if (price <= 30.0m)
                            {
                                price += 4.35m;
                            }
                            if (price > 30.0m)
                            {
                                price += 3.85m;
                            }
                        }
                    }
            
                
            }
            if (lenght == "two")
            {
                
                    if (type == "small")
                    {
                        price += 8.58m;
                    }
                    if (type == "middle")
                    {
                        price += 17.09m;
                    }
                    if (type == "large")
                    {
                        price += 23.59m;
                    }
                    if (type == "extralarge")
                    {
                        price += 31.79m;
                    }
                
                
                    if (internet == "yes")
                    {
                        if (price <= 10.0m)
                        {
                            price += 5.5m;
                        }
                        else
                        {
                            if (price <= 30.0m)
                            {
                                price += 4.35m;
                            }
                            if (price > 30.0m)
                            {
                                price += 3.85m;
                            }
                        }
                    }
                
                price -= price * 0.0375m;
            }
            decimal finalPrice = price * months;
            Console.WriteLine("{0} lv.",Math.Round(finalPrice,2).ToString("0.00"));
        }
        }
    }

