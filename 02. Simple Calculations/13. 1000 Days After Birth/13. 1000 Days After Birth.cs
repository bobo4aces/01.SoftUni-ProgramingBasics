using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthday = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            var days = birthday.AddDays(999.9);
            Console.WriteLine(days.ToString("dd-MM-yyyy", null));
        }
    }
}
