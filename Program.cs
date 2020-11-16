using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt for a guess
            Console.WriteLine("Guess the secret number!");

            //create a random integer for the user to guess
            Random r = new Random();
            int secretNum = r.Next(1,101);

            //Give the user four chances
            for (int i = 4; i >=1; i--)
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
