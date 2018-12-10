using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lectureCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            
            double lecturePaid = budget / lectureCount;
            int jelevLectureCount = 0;
            int royalLectureCount = 0;
            int roliLectureCount = 0;
            int trofonLectureCount = 0;
            int sinoLectureCount = 0;
            int othersLectureCount = 0;
            for (int i = 0; i < lectureCount; i++)
            {
                string lecturerName = Console.ReadLine();
                switch (lecturerName)
                {
                    case "Jelev":
                        jelevLectureCount++;
                        break;
                    case "RoYaL":
                        royalLectureCount++;
                        break;
                    case "Roli":
                        roliLectureCount++;
                        break;
                    case "Trofon":
                        trofonLectureCount++;
                        break;
                    case "Sino":
                        sinoLectureCount++;
                        break;
                    default:
                        othersLectureCount++;
                        break;
                }
            }
            Console.WriteLine($"Jelev salary: {jelevLectureCount*lecturePaid:f2} lv");
            Console.WriteLine($"RoYaL salary: {royalLectureCount*lecturePaid:f2} lv");
            Console.WriteLine($"Roli salary: {roliLectureCount*lecturePaid:f2} lv");
            Console.WriteLine($"Trofon salary: {trofonLectureCount*lecturePaid:f2} lv");
            Console.WriteLine($"Sino salary: {sinoLectureCount*lecturePaid:f2} lv");
            Console.WriteLine($"Others salary: {othersLectureCount*lecturePaid:f2} lv");
        }
    }
}
//16:38-16:53