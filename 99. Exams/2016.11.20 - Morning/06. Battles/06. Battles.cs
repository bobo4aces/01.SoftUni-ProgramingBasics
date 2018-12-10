using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerPokemonsCount = int.Parse(Console.ReadLine());
            int secondPlayerPokemonsCount = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= firstPlayerPokemonsCount; i++)
            {
                for (int j = 1; j <= secondPlayerPokemonsCount; j++)
                {
                    counter++;
                    if (counter<= maxBattles)
                    {
                        Console.Write($"({i} <-> {j}) ");
                    }
                    else
                    {
                        return;
                    }
                }
            }
            
        }
    }
}
//20:20-20:28
//01:09