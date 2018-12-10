using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupStudentsCount = int.Parse(Console.ReadLine());
            int peopleInCar = 0;
            int peopleInMicroBus = 0;
            int peopleInSmallBus = 0;
            int peopleInBigBus = 0;
            int peopleInTrain = 0;
            for (int i = 0; i < groupStudentsCount; i++)
            {
                int peopleCount = int.Parse(Console.ReadLine());
                if (peopleCount <= 5)
                {
                    peopleInCar += peopleCount;
                }
                else if (6 <= peopleCount && peopleCount <= 12)
                {
                    peopleInMicroBus += peopleCount;
                }
                else if (13 <= peopleCount && peopleCount <= 25)
                {
                    peopleInSmallBus += peopleCount;
                }
                else if (26 <= peopleCount && peopleCount <= 40)
                {
                    peopleInBigBus += peopleCount;
                }
                else if (peopleCount >= 41)
                {
                    peopleInTrain += peopleCount;
                }
            }
            int totalPeople = peopleInCar + peopleInMicroBus + peopleInSmallBus + peopleInBigBus + peopleInTrain;
            Console.WriteLine($"{((double)peopleInCar/ totalPeople*100):f2}%");
            Console.WriteLine($"{((double)peopleInMicroBus / totalPeople * 100):f2}%");
            Console.WriteLine($"{((double)peopleInSmallBus / totalPeople * 100):f2}%");
            Console.WriteLine($"{((double)peopleInBigBus / totalPeople * 100):f2}%");
            Console.WriteLine($"{((double)peopleInTrain / totalPeople * 100):f2}%");
        }
    }
}
//19:46-19:56