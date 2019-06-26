using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.Write("Please enter a series of numbers separates by commas: ");
            var userInput = Console.ReadLine();

            var numbers = userInput.Split(',');

            var maxNum = Convert.ToInt32(numbers[0]);

            foreach (var indivNum in numbers)
            {
                var number = Convert.ToInt32(indivNum);
                if (number > maxNum)
                    maxNum = number;
            }

            Console.WriteLine("The largest number is " + maxNum);
        }
    }
}
