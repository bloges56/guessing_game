using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt for a difficulty level
            Console.WriteLine("Choose a difficulty");
            Console.WriteLine("1: Easy");
            Console.WriteLine("2: Medium");
            Console.WriteLine("3: Hard");
            Console.Write("Your Choice: ");

            //Save their choice
            int difficulty = Int32.Parse(Console.ReadLine());

            //determine the number of guesses based off the difficulty chosen
            int guesses;
            if(difficulty == 1)
            {
                guesses = 8;
            }
            else if(difficulty == 2)
            {
                guesses = 6;
            }
            else
            {
                guesses = 4;
            }

            //Prompt for a guess
            Console.WriteLine("Guess the secret number!");

            //create a random integer for the user to guess
            Random r = new Random();
            int secretNum = r.Next(1,101);

            //Give the user the number of chances determined by the difficulty
            for (int i = guesses; i >=1; i--)
            {
                //Prompt
                if(i == 1){
                    Console.Write($"{i} Guess left: ");
                }
                else
                {
                    Console.Write($"{i} Guesses left: ");
                }
                
                //save the guess
                int guess = Int32.Parse(Console.ReadLine());

                //compare the guess and secretNum
                if (guess == secretNum)
                {
                    //if they are equal display success message
                    Console.WriteLine("You Win!");
                    //break out of loop
                    break;
                }
                else if(guess > secretNum)
                {
                    //if the guess is to high, tell the user
                    Console.WriteLine("Too High!");
                }
                else if(i != 1)
                {
                    //if its not the last turn, tell the user the guess is too low
                    Console.WriteLine("Too Low!");
                }
                else
                {
                    //else display the lose message
                    Console.WriteLine("You Lose!");
                }

            }


        }
    }
}
