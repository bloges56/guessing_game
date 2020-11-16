﻿using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt for a guess
            Console.WriteLine("Guess the secret number!");

            //declare and init secretNum
            int secreteNum = 42;

            //Give the user four chances
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Your Guess: ");
                //save the guess
                int guess = Int32.Parse(Console.ReadLine());

                //compare the guess and secretNum
                if (guess == secreteNum)
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
}
