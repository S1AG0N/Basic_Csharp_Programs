using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    class Digits
    {  // Class that contains a method demonstrating two integer parameters

            // Void method that takes two integers as parameters
            // It squares the first integer and displays the second integer to the screen
            public void ProcessNumbers(int firstNum, int secondNum)
            {
                // Perform a math operation on the first integer (squaring it)
                int squared = firstNum * firstNum;

                // Display the result of the math operation on the first integer
                Console.WriteLine("First number squared: " + squared);

                // Display the second integer to the screen
                Console.WriteLine("Second number: " + secondNum);
            }
        
    }
}
