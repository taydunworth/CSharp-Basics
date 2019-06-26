using System;

namespace Exercise_2
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
            var maxNum = (numOne > numTwo) ? numOne : numTwo;
            Console.WriteLine("The larger number of the two is " + maxNum);
        }
    }
}
