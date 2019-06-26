using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)

            var secretNum = new Random().Next(1, 10);
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess the secret number that is between 1 and 10.");
                var userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess == secretNum)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine("You lost!");
        }
    }
}
