using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();
            var nameArray = new char[name.Length];

            for (var i = name.Length; i > 0; i--)
                nameArray[name.Length - i] = name[i - 1];

            var reversed = new string(nameArray);
            Console.WriteLine("Your name reversed is " + reversed);
        }
    }
}
