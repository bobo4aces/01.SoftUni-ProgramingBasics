using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int leftSum = 0;
            for (int i = 0; i <num; i++)
            {
                leftSum = leftSum+int.Parse(Console.ReadLine());
            }
            int rightSum = 0;
            for (int i = 0; i < num; i++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());
            }
            if (leftSum==rightSum)
            {
                Console.WriteLine("Yes, sum = "+leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = "+Math.Abs(leftSum-rightSum));
            }
        }
    }
}
