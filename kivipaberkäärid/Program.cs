using System;

namespace kivipaberkäärid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Lets play kivi paber käärid!");
            value = Console.ReadLine();
            Console.WriteLine($"Your weapon is {value}.");

            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 4);

            if (randomNumber == 1) 
                {
                Console.WriteLine("My weapon is Kivi");
                }

            else if (randomNumber == 2)
            {
                Console.WriteLine("My weapon is Käärid");
            }

            else
            {
                Console.WriteLine("My weapon is Paber");
            }

            if (randomNumber > value)
            {
                Console.WriteLine("You loose");
            }

            else if (randomNumber < value)
            {
                Console.WriteLine("You win");
            }

            else
            {
                Console.WriteLine("Tie");
            }
        }
    }
}
