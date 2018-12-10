using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;
            for (int i = 1; i <= period; i++)
            {
                int patientsCount = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && untreatedPatients > treatedPatients)
                {
                    doctors++;
                }
                if (doctors>= patientsCount)
                {
                    treatedPatients += patientsCount;
                }
                else
                {
                    
                    treatedPatients += doctors;
                    untreatedPatients += patientsCount - doctors;
                    
                }
                
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
//19:07-19:27