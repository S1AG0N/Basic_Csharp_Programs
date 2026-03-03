using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_expressions
{
    class Program
    {
        // Entry point of the console application
        static void Main(string[] args)
        {
            // Create a list to store Employee objects
            List<Employee> employees = new List<Employee>()
        {
            // Add at least 10 employees to the list
            new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
            new Employee { Id = 3, FirstName = "Joe", LastName = "Brown" },
            new Employee { Id = 4, FirstName = "Emily", LastName = "Clark" },
            new Employee { Id = 5, FirstName = "Michael", LastName = "Johnson" },
            new Employee { Id = 6, FirstName = "Sarah", LastName = "Davis" },
            new Employee { Id = 7, FirstName = "David", LastName = "Wilson" },
            new Employee { Id = 8, FirstName = "Anna", LastName = "Taylor" },
            new Employee { Id = 9, FirstName = "James", LastName = "Anderson" },
            new Employee { Id = 10, FirstName = "Laura", LastName = "Thomas" }
        };

            // Create a new list to store employees named "Joe"
            List<Employee> joes = new List<Employee>();

            // Loop through each employee in the employees list
            foreach (Employee emp in employees)
            {
                // Check if the employee's FirstName property equals "Joe"
                if (emp.FirstName == "Joe")
                {
                    // If true, add the employee to the joes list
                    joes.Add(emp);
                }
            }

            // Display the employees named Joe (from foreach loop)
            Console.WriteLine("Employees named Joe (foreach loop):");
            foreach (Employee emp in joes)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }

            // Perform the same action using a lambda expression
            // Where() filters the list based on a condition
            List<Employee> joesLambda = employees
                .Where(emp => emp.FirstName == "Joe")
                .ToList();

            // Display the employees named Joe (from lambda expression)
            Console.WriteLine("\nEmployees named Joe (lambda):");
            foreach (Employee emp in joesLambda)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }

            // Use a lambda expression to find employees with Id greater than 5
            List<Employee> idGreaterThanFive = employees
                .Where(emp => emp.Id > 5)
                .ToList();

            // Display employees with Id greater than 5
            Console.WriteLine("\nEmployees with Id greater than 5:");
            foreach (Employee emp in idGreaterThanFive)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName + " - Id: " + emp.Id);
            }

            // Keeps the console window open
            Console.ReadLine();
        }
    }
}