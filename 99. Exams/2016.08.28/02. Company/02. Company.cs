using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Company
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int overtimeEmployeesCount = int.Parse(Console.ReadLine());
            double workingHours = (days - days * 0.1) * 8;
            double overtimeHours = overtimeEmployeesCount * 2*days;
            double totalHours = Math.Floor(workingHours + overtimeHours);
            if (totalHours>=hoursNeeded)
            {
                Console.WriteLine($"Yes!{totalHours-hoursNeeded} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hoursNeeded-totalHours} hours needed.");
            }
            
        }
    }
}
//19:44-19:54