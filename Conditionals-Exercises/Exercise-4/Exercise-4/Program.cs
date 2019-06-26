using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.

            Console.WriteLine("What is the speed limit?");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How fast is the car going?");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Okay");
            }
            else
            {
                const int kmForDemerit = 5;
                var demerits = (carSpeed - speedLimit) / kmForDemerit;

                if (demerits > 12)
                {
                    Console.WriteLine("Your license has been suspended.");
                }
                else
                {
                    Console.WriteLine("Demerit Points = " + demerits);
                }
            }
        }
    }
}
