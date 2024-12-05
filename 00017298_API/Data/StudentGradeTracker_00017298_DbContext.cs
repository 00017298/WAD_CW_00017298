using _00017298_API.Models;
using Microsoft.EntityFrameworkCore;

namespace _00017298_API.Data
{
    public class StudentGradeTracker_00017298_DbContext:DbContext
    {
        public StudentGradeTracker_00017298_DbContext(DbContextOptions<StudentGradeTracker_00017298_DbContext> o) : base(o) { }
        public DbSet<StudentGradeTracker_00017298> StudentGradeTracker_00017298s  { get; set; }
        public DbSet<Category_00017298> Categories_00017298 { get; set; }

    }
}
