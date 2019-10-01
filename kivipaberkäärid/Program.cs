using System;

namespace kivipaberkäärid
{
    class Program
    {
        static void Main()
        {
            int userRoll;
            int cpuScore = 0;
            int userScore = 0;
            string name;

            //Introduction
            Console.WriteLine("Hello World! Lets play kivi paber käärid!");
            Console.WriteLine("Please, insert your name.");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Hello {name}. Lets begin?");
            Console.Write("Game rules: ");
            Console.WriteLine("Paper bears Rock, Rock beats Scissors, Scissors beat Paper.");
            Console.WriteLine("Scissors corresponds to number 1, Rock corresponds to number 2, Paper correspond to number 3.");
            Console.WriteLine("Game goes on until one of us reaches 3 points. Winner takes all!");
            Console.WriteLine("Lets begin! Keep inserting your desired weapon (number) until the score table decides who is the winner.");

            while (userScore < 3 && cpuScore < 3)               //Playing until either one gets 3 points.
            {
                userRoll = int.Parse(Console.ReadLine());       //User weapon choise input as number.

                //Checking for incorrect User input and declaration of User number input into plain simple words (User choosing weapon). Also if incorrect value
                //inserted, asks to insert correct one. It just works somehow XD
                Console.WriteLine();
                switch (userRoll)
                {
                    case 1:
                        Console.WriteLine("Your chosen weapon is Scissors.");
                        break;
                    case 2:
                        Console.WriteLine("Your chosen weapon is Rock.");
                        break;
                    case 3:
                        Console.WriteLine("Your chosen weapon is Paper.");
                        break;
                    default:    
                        Console.WriteLine("Please, insert correct value, either of 1 or 2 or 3, which correspond to appropriate weapon.");  //If user inserted correct number, game goes on, if not, then asks for input.
                        break;
                }
                
                if (userRoll >= 1 && userRoll <= 3)             //If correct user input, cpu starts choosing its weapon.
                {
                    //CPU choosing its weapon, random number generator for CPU, scaled down to only 3 random numbers - 1 or 2 or 3.
                    Random randomGenerator = new Random();
                    int randomNumber = randomGenerator.Next(1, 4);

                    switch (randomNumber)
                    {
                        case 1:
                            Console.WriteLine("My weapon is Scissors.");
                            break;
                        case 2:
                            Console.WriteLine("My weapon is Rock.");
                            break;
                        case 3:
                            Console.WriteLine("My weapon is Paper.");
                            break;                      
                    }

                    //Deciding who is the winner of each game until one of players reaches 3 points. If userScore and cpuScore is bellow 2 points, game asks to input User weapon again. 
                    //If userScore or cpuScore is at 2 points, comes the last deciding game and game doesn't ask for User weapon again when either of the sides wins, 
                    //unless it is TIE in which case User weapon choise is asked once more, until either sides gets the last third point.
                    Console.WriteLine();
                    if (((randomNumber == 3 && userRoll == 2) || (randomNumber == 2 && userRoll == 1) || (randomNumber == 1 && userRoll == 3)) && (userScore < 2 && cpuScore < 2))
                    {
                        cpuScore++;
                        Console.WriteLine("You LOOSE.");
                        Console.WriteLine($"I have now {cpuScore} points.");
                        Console.WriteLine("Choose your weapon again!");           
                    }

                    else if (((randomNumber == 2 && userRoll == 3) || (randomNumber == 1 && userRoll == 2) || (randomNumber == 3 && userRoll == 1)) && (userScore < 2 && cpuScore < 2))
                    {
                        userScore++;
                        Console.WriteLine("You WIN.");
                        Console.WriteLine($"You have now {userScore} points.");
                        Console.WriteLine("Choose your weapon again!");
                    }

                    else if (((randomNumber == 1 && userRoll == 1) || (randomNumber == 2 && userRoll == 2) || (randomNumber == 3 && userRoll == 3)) && (userScore < 2 && cpuScore < 2))
                    {
                        Console.WriteLine("It is a TIE, none of us gets point.");
                        Console.WriteLine("Choose your weapon again!");
                    }

                    else if (((randomNumber == 3 && userRoll == 2) || (randomNumber == 2 && userRoll == 1) || (randomNumber == 1 && userRoll == 3)) && ((userScore == 2 && userScore < 3) || (cpuScore == 2 && cpuScore < 3)))
                    {
                        cpuScore++;
                        Console.WriteLine("You LOOSE.");
                        Console.WriteLine($"I have now {cpuScore} points.");
                    }

                    else if (((randomNumber == 2 && userRoll == 3) || (randomNumber == 1 && userRoll == 2) || (randomNumber == 3 && userRoll == 1)) && ((userScore == 2 && userScore < 3) || (cpuScore == 2 && cpuScore < 3)))
                    {
                        userScore++;
                        Console.WriteLine("You WIN.");
                        Console.WriteLine($"You have now {userScore} points.");
                    }

                    else
                    {
                        Console.WriteLine("It is a TIE, none of us gets point.");
                        Console.WriteLine("Choose your weapon again!");
                    }
                    Console.WriteLine();
                }

                else        //Game continues until either of players get 3 points.
                {
                    continue;
                }
            }

            //When either of players reaches 3 points, game tells who won and by how many points.
            if (cpuScore == 3)
            {
                Console.WriteLine("One of us won the game. Lets see who it was based on our game score.");               
                Console.WriteLine($"I have now {cpuScore} and You have now {userScore}. That means I won.");
            }

            else
            {
                Console.WriteLine("One of us won the game. Lets see who it was based on our game score."); 
                Console.WriteLine($"You have now {userScore} and I have now {cpuScore}. That means You won.");
            }
            Console.ReadLine();
        }
    }
}