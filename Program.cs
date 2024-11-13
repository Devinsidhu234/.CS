using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user for the package weight
            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            // Check if the weight exceeds the limit of 50
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End the program
            }

            // Prompt the user for the package width
            Console.WriteLine("Please enter the package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            // Prompt the user for the package height
            Console.WriteLine("Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            // Prompt the user for the package length
            Console.WriteLine("Please enter the package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            // Check if the dimensions exceed the total limit of 50
            int dimensionTotal = packageWidth + packageHeight + packageLength;
            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End the program
            }

            // Calculate the shipping quote: multiply dimensions together, multiply by weight, then divide by 100
            int dimensionProduct = packageWidth * packageHeight * packageLength;
            decimal shippingQuote = (dimensionProduct * packageWeight) / 100m;

            // Display the shipping quote to the user
            Console.WriteLine($"Your estimated total for shipping this package is: ${shippingQuote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}
