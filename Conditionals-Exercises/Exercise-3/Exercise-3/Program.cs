using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
			{
				// Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

				Console.Write("Enter the width of your image: ");
				var width = Convert.ToInt32(Console.ReadLine());

				Console.Write("Enter the height of your image: ");
				var height = Convert.ToInt32(Console.ReadLine());

				if (width > height)
					Console.WriteLine("Your image is landscape.");
				else if (width < height)
					Console.WriteLine("Your image is portrait.");
				else
					Console.WriteLine("Your image is a square.");

			}
		}
    }
}
