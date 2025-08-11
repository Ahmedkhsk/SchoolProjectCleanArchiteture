using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entites;

namespace SchoolProject.Infrastructure.Context
{
    public class DBContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentSubjects> StudentSubjects { get; set; }
        public DbSet<DepartmentSubjects> DepartmentSubjects { get; set; }
        public DBContext(DbContextOptions<DBContext> options) : base(options){}
    }
}
