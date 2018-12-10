using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());
            int totalHours = workersCount * workingDays * 8;
            if (totalHours>=hoursNeeded)
            {
                Console.WriteLine($"{totalHours - hoursNeeded} hours left");
            }
            else
            {
                Console.WriteLine($"{hoursNeeded- totalHours} overtime");
                Console.WriteLine($"Penalties: {(hoursNeeded - totalHours)*workingDays}");
            }
        }
    }
}
//18:10-18:18