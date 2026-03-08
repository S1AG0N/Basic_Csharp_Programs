using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Step 1: Ask the user for a number
        Console.WriteLine("Please enter a number:");
        string number = Console.ReadLine();

        // Step 2: Save the number to a text file
        File.AppendAllText("numbers.txt", number + "\n");
        Console.WriteLine("Number saved to file!");

        // Step 3: Read and print the text file
        Console.WriteLine("\nHere is what is in the file:");
        string fileContents = File.ReadAllText("numbers.txt");
        Console.WriteLine(fileContents);
    }
}