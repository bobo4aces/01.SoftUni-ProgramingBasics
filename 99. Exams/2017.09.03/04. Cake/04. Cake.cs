using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());
            bool isItStop = false;
            int piecesTaken;
            int totalPieces = cakeLength * cakeWidth;
            do
            {
                isItStop = int.TryParse(Console.ReadLine(),out piecesTaken);
                totalPieces=totalPieces-piecesTaken;
            } while (isItStop == true||piecesTaken<0);
            if (totalPieces>0)
            {
                Console.WriteLine($"{totalPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
            }
            
        }
    }
}
