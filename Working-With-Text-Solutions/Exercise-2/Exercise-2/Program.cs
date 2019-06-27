using System;
using System.Collections.Generic;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

            Console.WriteLine("Please enter a few numbers separated by hyphens: ");

            var userInput = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(userInput))
                return;

            var splitInput = userInput.Split('-');
            var numList = new List<int>();
            foreach (var num in splitInput)
                numList.Add(Convert.ToInt32(num));

            var newList = new List<int>();
            var areDuplicates = false;
            foreach (var num in numList)
            {
                if (!newList.Contains(num))
                    newList.Add(num);
                else
                {
                    areDuplicates = true;
                    break;
                }
            }

            if (areDuplicates)
                Console.WriteLine("There are duplicates.");
            else
                Console.WriteLine("There are no duplicates.");
        }
    }
}
