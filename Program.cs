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
            Console.WriteLine("4: Cheater");
            Console.Write("Your Choice: ");

            //Save their choice
            int difficulty = Int32.Parse(Console.ReadLine());

            //determine the number of guesses based off the difficulty chosen
            //if cheater was chosen, set the bool cheater to true
            int guesses = 0;
            bool cheater = false;
            if (difficulty == 1)
            {
                guesses = 8;
            }
            else if (difficulty == 2)
            {
                guesses = 6;
            }
            else if (difficulty == 3)
            {
                guesses = 4;
            }
            else
            {
                cheater = true;
            }

            //Prompt for a guess
            Console.WriteLine("Guess the secret number between 1 and 100!");

            //create a random integer for the user to guess
            Random r = new Random();
            int secretNum = r.Next(1, 101);

            int guess = 0;
            //if cheater is true, run the loop until the answer is correct
            if(cheater){
                while(guess != secretNum){
                    guess = Game(0, secretNum, cheater);
                }
            }
            //Give the user the number of chances determined by the difficulty
            for (int i = guesses; i >= 1; i--)
            {
                if(Game(i, secretNum, cheater) == 0)
                {
                    break;
                }
            }
        }

        static int Game(int guesses, int secretNum, bool cheater)
        {
            //Prompt for a guess
            if (cheater)
            {
                Console.Write("Your Guess: ");
            }
            else if (guesses != 1)
            {
                Console.Write($"{guesses} guesses left: ");
            }
            else
            {
                Console.Write($"{guesses} guess left: ");
            }

            //save the guess
            int guess = Int32.Parse(Console.ReadLine());

            //compare the guess and secretNum
            if (guess == secretNum)
            {
                //if they are equal display success message
                Console.WriteLine("You Win!");
                //return 0 if not on cheater mode
                if(!cheater)
                {
                    return 0;
                } 
            }
            else if (guess > secretNum)
            {
                //if the guess is to high, tell the user
                Console.WriteLine("Too High!");
            }
            else if (guesses != 1)
            {
                //if its not the last turn, tell the user the guess is too low
                Console.WriteLine("Too Low!");
            }
            else
            {
                //else display the lose message
                Console.WriteLine("You Lose!");
            }
            //return the user's guess so if on cheater mode the while loop will end
            return guess;
        }
    }
}
