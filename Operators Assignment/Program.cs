using System;
using Operators_Assignment;

class Program
{
    static void Main(string[] args)
    {
        // Create first Employee object
        Employee emp1 = new Employee();
        emp1.Id = 1;
        emp1.FirstName = "John";
        emp1.LastName = "Smith";

        // Create second Employee object
        Employee emp2 = new Employee();
        emp2.Id = 1;
        emp2.FirstName = "Jane";
        emp2.LastName = "Doe";

        // Compare the two employees using the overloaded == operator
        if (emp1 == emp2)
        {
            Console.WriteLine("The employees are equal.");
        }
        else
        {
            Console.WriteLine("The employees are not equal.");
        }

        Console.ReadLine();
    }
}