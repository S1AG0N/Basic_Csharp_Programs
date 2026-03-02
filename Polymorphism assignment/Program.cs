using System;
using Polymorphism_assignment;

namespace Polymorphism_assignment
{
    class Program
    {
       static void Main(string[] args)
        {
            IQuittable employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Calls the Quit method through the interface reference
            // The runtime executes Employee's implementation of Quit
            employee.Quit();

            // Keeps the console window open until a key is pressed
            Console.ReadLine();
        }
    }
}
