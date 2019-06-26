using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            var factorial = 1;
            Console.Write("Please enter a number: ");
            var userNum = Convert.ToInt32(Console.ReadLine());

            for (var i = 1; i <= userNum; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("{0}! = {1}", userNum, factorial);
        }
    }
}
