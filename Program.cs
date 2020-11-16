using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt for a guess
            Console.WriteLine("Guess the secret number!");
            Console.Write("Your Guess: ");

            //save the guess and print it back to the screen
            string guess = Console.ReadLine();
            Console.WriteLine(guess);
        }
    }
}
