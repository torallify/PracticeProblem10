using System;

namespace PreTest.Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Raptor, only the chose few can ride");
            double ridersHeight;
            bool worked;
            string userContinue = null;
            do
            {
                Console.Write("Enter your height in inches: ");

                string userInput = Console.ReadLine();
                worked = double.TryParse(userInput, out ridersHeight);
                
             
                if(worked == false)
                {
                    Console.WriteLine("That wasn't a number!");
                    Console.Write("Please try again: ");
                    userInput = Console.ReadLine();
                    worked = double.TryParse(userInput, out ridersHeight);
                }

                if(ridersHeight <= 0)
                {
                    if (ridersHeight == 0)
                    {
                        Console.WriteLine("\nSilly goose, there is no way you are zero inches tall!\n");
                    }
                    else
                    {
                        Console.WriteLine("That wasn't a positive number!\n");
                        Console.Write("Please try again: ");
                        userInput = Console.ReadLine();
                        worked = double.TryParse(userInput, out ridersHeight);
                    }
                }

                if (ridersHeight < 54)
                {
                    Console.WriteLine($"Sorry, you cannot ride the Raptor. You need {54-ridersHeight} more inches.\n");
                }
                else if(ridersHeight >= 54)
                {
                    Console.WriteLine("Great, you can ride the Raptor!");
                }

                Console.Write("\nWould you like to continue? (y/n) ");
                userContinue = Console.ReadLine().ToLower();
                

            } while (userContinue == "y" || userContinue == "yes");

        }
    }
}
