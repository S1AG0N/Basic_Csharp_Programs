using System;

namespace Calling_Method_Asssignment
{
    class Program
    {
        static void Main()
        {
            // Create an instance of the Calling_Method_Assignment class to access its methods
            Calling_Method_Assignment math = new Calling_Method_Assignment();

            // Prompt the user to enter a number
            Console.WriteLine("Enter a number: ");

            // Read the user's input and convert it from a string to an integer
            int userNum = Convert.ToInt32(Console.ReadLine());

            // Call the Square method and display the result
            Console.WriteLine("Square: " + math.Square(userNum));

            // Call the Double method and display the result
            Console.WriteLine("Double: " + math.Double(userNum));

            // Call the SubtractTen method and display the result
            Console.WriteLine("Subtract 10: " + math.SubtractTen(userNum));
        }
    }
}