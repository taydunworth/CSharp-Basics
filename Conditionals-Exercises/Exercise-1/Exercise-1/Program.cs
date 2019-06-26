using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program which takes two numbers from the console and displays the maximum of the two.

            Console.Write("Please enter a number: ");
            var numOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter another number: ");
            var numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numOne + numTwo);
        }
    }
}
