using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = int.MinValue;
            for (int i = 0; i < num; i++)
            {
                int writtenNum = int.Parse(Console.ReadLine());
                sum += writtenNum;
                if (writtenNum>maxNum)
                {
                    maxNum = writtenNum;
                }
            }
            int newSum = sum - maxNum;
            if (newSum==maxNum)
            {
                Console.WriteLine("Yes, Sum = "+maxNum);
            }
            else
            {
                Console.WriteLine("No, Diff = "+Math.Abs(maxNum-newSum));
            }
        }
    }
}
