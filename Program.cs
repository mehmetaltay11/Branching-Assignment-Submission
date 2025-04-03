using System;

namespace ShippingQuoteCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Presents the user with a welcome message for the shipping service
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Requests and stores the weight value of the package
            Console.WriteLine("Please enter the package weight:");
            float weight = Convert.ToSingle(Console.ReadLine());

            // Evaluates if the package weight exceeds the maximum shipping limit
            if (weight > 50)
            {
                // Displays a rejection notice for packages that are too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Terminates the application for overweight packages
            }

            // Collects the width dimension of the package from user input
            Console.WriteLine("Please enter the package width:");
            float width = Convert.ToSingle(Console.ReadLine());

            // Collects the height dimension of the package from user input
            Console.WriteLine("Please enter the package height:");
            float height = Convert.ToSingle(Console.ReadLine());

            // Collects the length dimension of the package from user input
            Console.WriteLine("Please enter the package length:");
            float length = Convert.ToSingle(Console.ReadLine());

            // Analyzes if the combined dimensions are within the shipping parameters
            if (width + height + length > 50)
            {
                // Informs the user that the package size is not acceptable for shipping
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Stops the program execution for oversized packages
            }

            // Determines the shipping cost using the defined calculation method
            float quote = (height * width * length * weight) / 100;

            // Shows the user their shipping quote formatted as currency
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Waits for a keypress before closing the console window
            Console.ReadKey();
        }
    }
}