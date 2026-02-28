using System;

// Define a public class named MathOperations
// This class contains mathematical methods we can reuse
public class MathOperations
{
    // Method 1: Adds 10 to the given number
    // Takes one integer parameter and returns an integer
    public int AddTen(int number)
    {
        return number + 10;
    }

    // Method 2: Multiplies the given number by 5
    // Takes one integer parameter and returns an integer
    public int MultiplyByFive(int number)
    {
        return number * 5;
    }

    // Method 3: Squares the given number
    // Takes one integer parameter and returns an integer
    public int SquareNumber(int number)
    {
        return number * number;
    }
}