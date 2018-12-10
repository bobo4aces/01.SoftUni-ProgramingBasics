using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleInGroupCount = int.Parse(Console.ReadLine());
            double transportBudjet = 0;
            if (peopleInGroupCount<=4)
            {
                transportBudjet=budjet-(budjet*0.75);
            }
            else if (5<=peopleInGroupCount&&peopleInGroupCount<=9)
            {
                transportBudjet = budjet - (budjet * 0.60);
            }
            else if (10 <= peopleInGroupCount && peopleInGroupCount <= 24)
            {
                transportBudjet = budjet - (budjet * 0.50);
            }
            else if (25 <= peopleInGroupCount && peopleInGroupCount <= 49)
            {
                transportBudjet = budjet - (budjet * 0.40);
            }
            else if (peopleInGroupCount>= 50)
            {
                transportBudjet = budjet - (budjet * 0.25);
            }
            double totalAmountForTickets = 0;
            switch (category)
            {
                case "Normal":
                    totalAmountForTickets = 249.99 * peopleInGroupCount;
                    break;
                case "VIP":
                    totalAmountForTickets = 499.99 * peopleInGroupCount;
                    break;
                default:
                    break;
            }
            if (transportBudjet >= totalAmountForTickets)
            {
                Console.WriteLine($"Yes! You have {(transportBudjet - totalAmountForTickets):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalAmountForTickets- transportBudjet):f2} leva.");
            }
            
        }
    }
}
//10:43-10:59