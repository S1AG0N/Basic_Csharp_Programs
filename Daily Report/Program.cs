// Import the System namespace so we can use Console and built-in types.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Print the college name as the first line of the report.
        Console.WriteLine("Academy of Learning Career College");

        // Print the report title as the second line of the report.
        Console.WriteLine("Student Daily Report.");

        // Ask the student for their name.
        Console.WriteLine("What is your name?");
        string studentName = Console.ReadLine(); // Store the name as a string.

        // Ask the student what course they are on.
        Console.WriteLine("What course are you on?");
        string courseName = Console.ReadLine(); // Store the course name as a string.

        // Ask the student for the page number they are on.
        Console.WriteLine("What page number?");
        string pageInput = Console.ReadLine(); // Read input as a string first.
        int pageNumber = int.Parse(pageInput); // Convert the input to an integer.

        // Ask if the student needs help; they must answer true or false.
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
        string helpInput = Console.ReadLine(); // Read input as a string first.
        bool needsHelp = bool.Parse(helpInput); // Convert the input to a boolean.

        // Ask about any positive experiences the student wants to share.
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string positiveExperiences = Console.ReadLine(); // Store the response as a string.

        // Ask for any other feedback the student would like to provide.
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string additionalFeedback = Console.ReadLine(); // Store the response as a string.

        // Ask how many hours the student studied today.
        Console.WriteLine("How many hours did you study today?");
        string hoursInput = Console.ReadLine(); // Read input as a string first.
        double studyHours = double.Parse(hoursInput); // Convert the input to a double (supports decimals like 2.5).

        // Print the closing message to end the program.
        Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
    }
}
