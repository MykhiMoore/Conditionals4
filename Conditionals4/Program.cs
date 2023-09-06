using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IfElseStuff();

            Console.ReadLine(); 
        }

        static void IfElseStuff()            
        {
            Console.WriteLine("Please enter how much gold you have: ");
            double goldBalance = double.Parse(Console.ReadLine());
            Console.WriteLine(goldBalance);

            if (goldBalance >= 200)
            {
                Console.WriteLine("Congrats. you have enough to buy at least one ticket");
            }
            else if (goldBalance >= 400)
            {
                Console.WriteLine("Congrats. you have enough to buy you a ticket for you and a friend.");
            }
            else
            {
                Console.WriteLine("Too bad. Go make more money.");
            }
        }
    }
}
