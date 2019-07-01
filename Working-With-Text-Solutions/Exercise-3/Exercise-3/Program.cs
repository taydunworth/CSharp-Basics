using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

            Console.Write("Please enter a time value in the 24-hour time format (e.g. 19:00" );
            var userInput = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Invalid time");
                break;
            }

            var timeNums = userInput.Split(':');
            if (timeNums.Length != 2)
            {
                Console.WriteLine("Invalid time");
                break;
            }

            Console.WriteLine("Ok");

        }
    }
}
