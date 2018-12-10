using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int topStudents = 0;
            int goodStudents = 0;
            int middleStudents = 0;
            int fail = 0;
            double totalGrades = 0;
            for (int i = 0; i < studentsCount; i++)
            {
                double studentGrade = double.Parse(Console.ReadLine());
                totalGrades += studentGrade;
                if (studentGrade>=5.00)
                {
                    topStudents++;
                }
                else if (4.00<=studentGrade&& studentGrade <= 4.99)
                {
                    goodStudents++;
                }
                else if (3.00 <= studentGrade && studentGrade <= 3.99)
                {
                    middleStudents++;
                }
                else if (studentGrade<= 2.99)
                {
                    fail++;
                }
            }
            Console.WriteLine($"Top students: {((topStudents/(double)studentsCount)*100):f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {((goodStudents / (double)studentsCount) * 100):f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {((middleStudents / (double)studentsCount) * 100):f2}%");
            Console.WriteLine($"Fail: {((fail / (double)studentsCount) * 100):f2}%");
            Console.WriteLine($"Average: {(totalGrades / studentsCount):f2}");
        }
    }
}
//22:15-22:35
//1:19