using System;

namespace kivipaberkäärid
{
    class Program
    {
        static void Main()
        {
            int userRoll;
            int cpuPoint = 0;
            int userPoint = 0;
            int rolls = 0;
            string name;

            //Introduction
            Console.WriteLine("Hello World! Lets play kivi paber käärid!");
            Console.WriteLine("Please, insert your name.");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Hello {name}. Lets begin?");
            Console.Write("Game rules:");
            Console.WriteLine("Paper bears rock, rock beats scissors, scissors beat paper.");
            Console.WriteLine("Paper corresponds to number 1, rock corresponds to number 2, scissors correspond to number 3.");
            Console.WriteLine("Game goes on until one of us reaches 3 points. Winner takes all!");
            Console.WriteLine("Lets begin! Insert your weapon (number).");
            userRoll = int.Parse(Console.ReadLine());

            //Declaration of user number input into plain simple words
            while ((userPoint < 3 && cpuPoint < 3) && rolls <= 3)
            {
                if (userRoll == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Your weapon is Paper.");
                }

                else if (userRoll == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Your weapon is Rock.");
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Your weapon is Scissors.");
                }

                //Random number generator for CPU, scaled down to only 3 random numbers - 1 or 2 or 3.
                Random randomGenerator = new Random();
                int randomNumber = randomGenerator.Next(1, 4);

                //Declaration of CPU random numbers into plain simple text.
                if (randomNumber == 1)
                {
                    Console.WriteLine("My weapon is Paper.");
                }

                else if (randomNumber == 2)
                {
                    Console.WriteLine("My weapon is Rock.");
                }

                else
                {
                    Console.WriteLine("My weapon is Scissors.");
                }

                //Deciding who is the winner.
                if (randomNumber > userRoll)
                {
                    Console.WriteLine();
                    Console.WriteLine("You LOOSE.");
                    cpuPoint++;
                    Console.WriteLine($"I have now {cpuPoint} points.");
                    Console.WriteLine("Choose your weapon again.");
                    Console.WriteLine();
                    rolls++;                   
                }

                else if (randomNumber < userRoll)
                {
                    Console.WriteLine();
                    Console.WriteLine("You WIN.");
                    userPoint++;
                    Console.WriteLine($"You have now {userPoint} points.");
                    Console.WriteLine("Choose your weapon again.");
                    Console.WriteLine();
                    rolls++;
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("It is a TIE.");
                    Console.WriteLine("Choose your weapon again.");
                    Console.WriteLine();
                }

                if (cpuPoint == 3)
                {
                    Console.WriteLine($"I have now {cpuPoint} and you have now {userPoint}. That means I won.");
                }

                else if (userPoint == 3)
                {
                    Console.WriteLine($"You have now {userPoint} and I have now {cpuPoint}. That means you won.");
                }
                userRoll = int.Parse(Console.ReadLine());
                continue;
            }
        }
    }
}
