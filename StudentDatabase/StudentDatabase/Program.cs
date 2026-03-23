using System;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            // open a session with the database
            using (var db = new StudentContext())
            {
                // create a new student object
                var student = new Student
                {
                    FirstName = "Phil",
                    LastName = "Smith",
                    Email = "phil@email.com",
                    DateEnrolled = DateTime.Now
                };

                // add student to the Students table
                db.Students.Add(student);

                // save changes to the database
                db.SaveChanges();

                Console.WriteLine("Student added successfully!");
                Console.WriteLine("-----------------------------");

                // retrieve and display all students
                foreach (var s in db.Students)
                {
                    Console.WriteLine($"ID: {s.Id}");
                    Console.WriteLine($"Name: {s.FirstName} {s.LastName}");
                    Console.WriteLine($"Email: {s.Email}");
                    Console.WriteLine($"Enrolled: {s.DateEnrolled}");
                }

                Console.ReadLine();
            }
        }
    }
}