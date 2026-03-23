using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDatabase
{
    public class Student
    {
            public int Id { get; set; }          // primary key
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public DateTime DateEnrolled { get; set; }
        
    }
}
