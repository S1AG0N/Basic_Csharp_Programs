using Method_Class_Assignment;
using System;

namespace Method_Class_Assignment
{
    class Program
    {
        static void Main() 
        {
            // Instantiate the MathOperations class to access its methods
            Digits operations = new Digits();

            // Call the method passing in two numbers directly (positional arguments)
            Console.WriteLine("--- Calling method with direct arguments ---");
            operations.ProcessNumbers(4, 7);

            // Call the method specifying the parameters by name (named arguments)
            Console.WriteLine("--- Calling method with named arguments ---");
            operations.ProcessNumbers(firstNum: 5, secondNum: 10);


        }

    }
};