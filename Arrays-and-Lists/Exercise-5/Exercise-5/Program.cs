using System;
using System.Collections.Generic;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.

            string[] numbers;

            while (true)
            {
                Console.Write("Please enter a list of at least five numbers separated by commas: ");
                var userInput = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(userInput))
                {
                    numbers = userInput.Split(',');
                    if (numbers.Length >= 5)
                        break;

                    Console.WriteLine("You entered an invalid list.");
                }
            }

            var numList = new List<int>();
            foreach (var num in numbers)
                numList.Add(Convert.ToInt32(num));

            var smallThree = new List<int>();
            while (smallThree.Count < 3)
            {
                var min = numList[0];
                foreach (var num in numList)
                {
                    if (num < min)
                        min = num;
                }
                smallThree.Add(min);
                numList.Remove(min);
            }

            var smallList = new List<string>();
            foreach (var num in smallThree)
                smallList.Add(Convert.ToString(num));

            Console.WriteLine("The 3 smallest numbers are: " + smallList[0] + ", " + smallList[1] + ", and " + smallList[2]);
        }
	}
}
