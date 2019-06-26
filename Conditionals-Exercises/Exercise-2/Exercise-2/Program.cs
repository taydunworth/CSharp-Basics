using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)

            Console.Write("Please enter a number that is between 1 and 10: ");
            var userNumber = Convert.ToInt32(Console.ReadLine());
            if (userNumber >= 1 && userNumber <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}
