using System;
using System.Collections.Generic;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Console.WriteLine("Please enter a few numbers separated by hyphens: ");
            var userInput = Console.ReadLine();
            var splitInput = userInput.Split('-');

            var numList = new List<int>();
            foreach (var num in splitInput)
                numList.Add(Convert.ToInt32(num));

            numList.Sort();

            var isConsecutive = true;

            for (var i = 1; i < numList.Count; i++)
            {
                if (numList[i] != numList[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var response = isConsecutive ? "The numbers are consecutive." : "The numbers are not consecutive.";
            Console.WriteLine(response);
        }
    }
}
