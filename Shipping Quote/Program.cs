using System; // Imports the System namespace so we can use Console and basic .NET types.

namespace ShippingQuote // Defines a namespace to group related code for the ShippingQuote application.
{
    class Program // Defines the Program class (container for the Main method).
    {
        static void Main(string[] args) // Program entry point: execution starts here.
        {
            Console.WriteLine("Welcome to Package Express. PLease follow the instructions below:"); // Prints a welcome/instruction message.

            Console.WriteLine("Please enter package weight:"); // Prompts the user to enter the package weight.
            int weight = int.Parse(Console.ReadLine()); // Reads user input as a string and converts it to an int for weight.

            if (weight > 50) // Checks if the package is too heavy based on the 50-unit limit.
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); // Informs the user the package is too heavy.
            }
            else // Runs if the package weight is 50 or less.
            {
                Console.WriteLine("Please enter the package width:"); // Prompts the user to enter package width.
                int width = int.Parse(Console.ReadLine()); // Reads width input and converts it to an int.

                Console.WriteLine("Please enter the package height:"); // Prompts the user to enter package height.
                int height = int.Parse(Console.ReadLine()); // Reads height input and converts it to an int.

                Console.WriteLine("Please enter the package length:"); // Prompts the user to enter package length.
                int length = int.Parse(Console.ReadLine()); // Reads length input and converts it to an int.

                if (length + width + height > 50) // Checks if the sum of dimensions exceeds the size limit (50).
                {
                    Console.WriteLine("Package too big to be shipped via Package Express."); // Informs the user the package is too large.
                }
                else // Runs if the package is within both weight and size limits.
                {
                    // Calculates shipping cost using the formula: (weight * width * length * height) / 100.
                    // Uses string interpolation ($"...") to include the computed cost in the output.
                    Console.WriteLine($"Your estimated total for shipping this package is: ${(weight * width * length * height) / 100}");
                }
            }

            Console.ReadLine(); // Pauses the program so the console stays open until the user presses Enter.
        }
    }
}
