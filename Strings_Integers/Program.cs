// Import the System namespace so we can use basic console functions
using System;

// Import the Collections.Generic namespace so we can use List<T>
using System.Collections.Generic;

// Create a list of integers and initialize it with 10 values
List<int> list = new List<int>()
{
    482, 731, 905, 264, 618, 357, 849, 192, 776, 530
};

// Ask the user to enter a divisor number
Console.WriteLine("Can you enter a divisor for the list:");

try
{
    // Read user input from the console and convert it to an integer
    // If the user enters something that is not a number,
    // this will throw a FormatException
    int num = Convert.ToInt32(Console.ReadLine());

    // Loop through each number in the list using a for loop
    for (int i = 0; i < list.Count; i++)
    {
        // Divide each list item by the user-entered number
        // and display the calculation result on the screen
        Console.WriteLine(list[i] + "/" + num + "=" + (list[i] / num));
    }
}

// Catch block handles errors if the user enters invalid input
catch (FormatException ex)
{
    // Display the error message to the user
    Console.WriteLine(ex);

    // Pause the program so the user can see the error before it closes
    Console.ReadLine();
}