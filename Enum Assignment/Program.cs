using System;  // Allows use of Console and basic system functionality

// Defines an enum at the namespace level
// Enums must be declared outside of methods
enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

// Defines the main program class
class Program
{
    // Entry point of the console application
    static void Main(string[] args)
    {
        // Ask the user to enter the current day
        Console.WriteLine("Please enter the current day of the week:");

        // Read the user's input
        string userInput = Console.ReadLine();

        try
        {
            // Attempt to convert the user's input into the enum type
            // The third parameter (true) makes it case-insensitive
            DaysOfWeek today = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

            // If successful, display the entered day
            Console.WriteLine("You entered: " + today);
        }
        catch
        {
            // If the conversion fails, display an error message
            Console.WriteLine("Please enter an actual day of the week.");
        }

        // Prevent the console window from closing immediately
        Console.ReadLine();
    }
}