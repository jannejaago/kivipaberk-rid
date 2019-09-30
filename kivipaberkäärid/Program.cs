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
            //int rolls = 0;
            string name;

            //Introduction
            Console.WriteLine("Hello World! Lets play kivi paber käärid!");
            Console.WriteLine("Please, insert your name.");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Hello {name}. Lets begin?");
            Console.Write("Game rules:");
            Console.WriteLine("Paper bears Rock, Rock beats Scissors, Scissors beat Paper.");
            Console.WriteLine("Scissors corresponds to number 1, Rock corresponds to number 2, Paper correspond to number 3.");
            Console.WriteLine("Game goes on until one of us reaches 3 points. Winner takes all!");
            Console.WriteLine("Lets begin! Insert your weapon (number).");
            userRoll = int.Parse(Console.ReadLine());
           
            //Checking for incorrect User input and declaration of user number input into plain simple words (User choosing weapon). 
            switch (userRoll)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Your weapon is Scissors.");
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Your weapon is Rock.");
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Your weapon is Paper.");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Please, insert correct value, either of 1 or 2 or 3, which correspond to appropriate weapon.");
                    break;
            }

            //Random number generator for CPU, scaled down to only 3 random numbers - 1 or 2 or 3.
            if (userRoll >= 1 && userRoll <= 3)
            {
                //CPU choosing its weapon
                Random randomGenerator = new Random();
                int randomNumber = randomGenerator.Next(1, 4);

                if (randomNumber == 1)
                {
                    Console.WriteLine("My weapon is Scissors.");
                }

                else if (randomNumber == 2)
                {
                    Console.WriteLine("My weapon is Rock.");
                }

                else
                {
                    Console.WriteLine("My weapon is Paper.");
                }

                //Deciding who is the winner.
                if ((randomNumber == 3 && userRoll == 2) || (randomNumber == 2 && userRoll == 1) || (randomNumber == 1 && userRoll == 3))
                {
                    Console.WriteLine();
                    Console.WriteLine("You LOOSE.");
                    cpuPoint++;
                    Console.WriteLine($"I have now {cpuPoint} points.");
                    //Console.WriteLine("Choose your weapon again.");
                    Console.WriteLine();
                }

                else if ((randomNumber == 2 && userRoll == 3) || (randomNumber == 1 && userRoll == 2) || (randomNumber == 3 && userRoll == 1))
                {
                    Console.WriteLine();
                    Console.WriteLine("You WIN.");
                    userPoint++;
                    Console.WriteLine($"You have now {userPoint} points.");
                    //Console.WriteLine("Choose your weapon again.");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("It is a TIE.");
                    //Console.WriteLine("Choose your weapon again.");
                    Console.WriteLine();
                }
            }

            /*if (cpuPoint == 3)
            {
                Console.WriteLine($"I have now {cpuPoint} and you have now {userPoint}. That means I won.");
            }

            else if (userPoint == 3)
            {
                Console.WriteLine($"You have now {userPoint} and I have now {cpuPoint}. That means you won.");
            }*/
        }
    }
}
