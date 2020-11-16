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
                else if(i == 1)
                {
                    //else if its the last turn display the lose message
                    Console.WriteLine("You Lose!");
                }
                else
                {
                    //otherwise display the failure message
                    Console.WriteLine("Wrong!");
                }

            }


        }
    }
}
