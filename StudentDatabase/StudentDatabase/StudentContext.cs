using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace StudentDatabase
{
    internal class StudentContext:DbContext
    {
        public StudentContext() : base("StudentDB") { }
        public DbSet<Student> Students { get; set; }


    }
}
