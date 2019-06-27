using System;
using System.Collections.Generic;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.

            var numberList = new List<int>();

            while (true)
            {
                Console.Write("Please enter a number or type 'Quit' to exit: ");
                var userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                    break;

                numberList.Add(Convert.ToInt32(userInput));
            }

            var uniqueList = new List<int>();
            foreach (var number in numberList)
            {
                if (!uniqueList.Contains(number))
                    uniqueList.Add(number);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in uniqueList)
                Console.WriteLine(number);
        }
    }
}
