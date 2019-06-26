using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.

            var counter = 0;
            for (var i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                    counter++;
            }
            Console.WriteLine("There are {0} numbers between 1 and 100 that are divisible by 3", counter);
        }
    }
}
