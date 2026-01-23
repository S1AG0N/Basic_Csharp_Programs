using System; // Gives access to basic .NET classes like Console.
using System.Collections.Generic; // Provides generic collections (List<T>, Dictionary<TKey,TValue>, etc.). Not used here.
using System.Linq; // Provides LINQ query features. Not used here.
using System.Text; // Provides text-related classes. Not used here.
using System.Threading.Tasks; // Provides task-based async features. Not used here.

namespace MathAssignemnt // Defines a namespace to organize the code.
{
    class Program // Defines the Program class (the container for the Main method).
    {
        static void Main(string[] args) // The entry point of the console application.
        {
            Console.WriteLine("Please enter your number: "); // Prompts the user to type a number.

            int num1 = int.Parse(Console.ReadLine()); // Reads user input (string) and converts it into an int stored in num1.

            Console.WriteLine("Number multiplied by 50=: " + (num1 * 50)); // Multiplies num1 by 50 and prints the result.
            Console.WriteLine("Number added to 25=: " + (num1 + 25)); // Adds 25 to num1 and prints the result.
            Console.WriteLine("Number divided by 12.5=: " + (num1 / 12.5)); // Divides num1 by 12.5 (result is a double) and prints it.
            Console.WriteLine("Number greater than 50:::" + (num1 > 50)); // Checks if num1 is greater than 50 and prints True/False.
            Console.WriteLine("Modulus of number and 7=:" + (num1 % 7)); // Computes num1 mod 7 (remainder) and prints it.

            Console.ReadLine(); // Pauses the program so the console window stays open until the user presses Enter.
        }
    }
}
