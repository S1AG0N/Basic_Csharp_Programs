using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst
{
    public class SchoolContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
    

    
}
