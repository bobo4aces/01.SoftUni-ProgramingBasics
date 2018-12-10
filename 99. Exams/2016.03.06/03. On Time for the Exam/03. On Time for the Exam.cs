using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());
            int examTime = examHour * 100 + examMinute;
            int arrivalTime = arrivalHour * 100 + arrivalMinute;
            if (arrivalTime>examTime)
            {
                Console.WriteLine("Late");
                if ((arrivalTime - examTime)<=100)
                {
                    Console.WriteLine($"{arrivalTime - examTime} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{(arrivalTime - examTime) / 60}:{(arrivalTime - examTime) % 60} hours after the start");
                }
                
            }
            else if (arrivalTime <= examTime-29)
            {
                Console.WriteLine("On time");
                if ((examTime - arrivalTime) <= 100)
                {
                    Console.WriteLine($"{examTime - arrivalTime} minutes before the start");
                }
                else
                {

                }
            }
            else if (arrivalTime <= examTime - 30)
            {
                Console.WriteLine("Early");
                Console.WriteLine("Late");
                if ((examTime - arrivalTime)<=100)
                {
                    Console.WriteLine($"{examTime - arrivalTime} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{(examTime - arrivalTime) / 60}:{(examTime - arrivalTime) % 60} hours before the start");
                }
                
            }
        }
    }
}
//20:33-