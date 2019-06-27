using System;
using System.Collections.Generic;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            var numberList = new List<int>();

            while (numberList.Count < 5)
            {
                Console.Write("Please enter a number: ");
                var newNumber = Convert.ToInt32(Console.ReadLine());

                if (numberList.Contains(newNumber))
                {
                    Console.WriteLine("You've already entered that number.");
                    continue;
                }
                else
                    numberList.Add(newNumber);
            }

            numberList.Sort();

            foreach ( var number in numberList)
                Console.WriteLine(number);
        }
    }
}
