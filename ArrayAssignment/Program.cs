using System;
using System.Collections.Generic; // Required for List<T>

// -----------------------------
// SECTION 1: Pulling a name from a string array
// -----------------------------

// Create a string array containing 10 names
string[] names = new string[]
{
    "Prisca", "Phillip", "Patricia", "Steven",
    "Gift", "Patience", "Perpetua", "Tayana",
    "Noku", "Talia"
};

// Ask the user to enter a number between 1 and 10
Console.WriteLine("There are 10 names so use any random number between 1-10 to choose a name: ");

// Read user input and convert it to an integer
int number = int.Parse(Console.ReadLine());

// Check if the number is within valid range
if (number >= 1 && number <= 10)
{
    // Arrays are zero-indexed, so subtract 1 from user input
    Console.WriteLine("The random name generated is: " + names[number - 1]);
}
else
{
    // Display error message if input is outside the allowed range
    Console.WriteLine("The number you entered is outside the range");
}


// -----------------------------
// SECTION 2: Pulling a number from an integer array
// -----------------------------

// Create an integer array with 10 three-digit numbers
int[] numbers = new int[]
{
    742, 315, 908, 561, 284,
    673, 490, 857, 126, 934
};

// Ask the user to select a position
Console.WriteLine("Please enter any random number from 1-10:");

// Read and convert input
int position = int.Parse(Console.ReadLine());

// Validate the position entered
if (position >= 1 && position <= 10)
{
    // Subtract 1 because arrays start at index 0
    Console.WriteLine("Your lucky number is: " + numbers[position - 1]);
}
else
{
    Console.WriteLine("The number you have entered is out of range.");
}


// -----------------------------
// SECTION 3: Using a List of strings
// -----------------------------

// Create a List<string> containing the same names
List<string> list = new List<string>()
{
    "Prisca",
    "Phillip",
    "Patricia",
    "Steven",
    "Gift",
    "Patience",
    "Perpetua",
    "Tayana",
    "Noku",
    "Talia"
};

// Prompt user to enter a number
Console.WriteLine("Please enter the number to see the magic name:");

// Convert input to integer
int num = int.Parse(Console.ReadLine());

// Access the list element (Lists are also zero-indexed)
Console.WriteLine("Tadaaaa: " + list[num - 1]);