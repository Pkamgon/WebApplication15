using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication15.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext()
            :base("name=StudentConnection")
        {
          
        }

        public DbSet<Student>StudentTable { get; set; }
        public DbSet<Grade>GradeTable { get; set; }
    }
}