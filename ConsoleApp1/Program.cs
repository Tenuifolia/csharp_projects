using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Ask the magic 8 ball a question? (press 'Enter' to exit) ");
            string userInput = Console.ReadLine();

            int randInt = random.Next(1,8);

            if (userInput != "") {
                if (randInt == 1)
                {
                    Console.WriteLine("It is certain");
                }
                else if (randInt == 2)
                {
                    Console.WriteLine("Outlook good");
                }
                else if (randInt == 3)
                {
                    Console.WriteLine("Ask again later");
                }
                else if (randInt == 4)
                {
                    Console.WriteLine("Concentrate and ask again");
                }
                else if (randInt == 5)
                {
                    Console.WriteLine("Reply hazy, try again");
                }
                else if (randInt == 6)
                {
                    Console.WriteLine("My reply is no");
                }
                else if (randInt == 7)
                {
                    Console.WriteLine("My sources say no");
                }
                else if (randInt == 8)
                {
                    Console.WriteLine("You may rely on it");
                }

            }
            Console.ReadKey();
        }
    }
}
