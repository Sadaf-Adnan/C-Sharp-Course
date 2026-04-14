using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial greeting
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Get Package Weight
            Console.WriteLine("Please enter the package weight:");
            float weight = float.Parse(Console.ReadLine());

            // Check weight constraint
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Ends the program
            }

            // Get Package Dimensions
            Console.WriteLine("Please enter the package width:");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            float length = float.Parse(Console.ReadLine());

            // Check dimension constraint (Total sum of dimensions)
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Ends the program
            }

            // Calculate Quote
            // Calculation: (Width * Height * Length * Weight) / 100
            float quote = (width * height * length * weight) / 100;

            // Display Quote formatted as currency
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
            
            // Keep console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
