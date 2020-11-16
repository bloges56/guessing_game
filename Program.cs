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

            //save the guess
            int guess = Int32.Parse(Console.ReadLine());
            //declare and init secretNum
            int secreteNum = 42;

            //compare the guess and secretNum
            if(guess == secreteNum)
            {
                //if they are equal display success message
                Console.WriteLine("You Win!");
            }
            else
            {
                //else display failure message
                Console.WriteLine("You Lose!");
            }
            

            

            
        }
    }
}
