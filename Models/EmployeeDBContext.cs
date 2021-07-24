using Microsoft.EntityFrameworkCore;

namespace Exam.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();
            builder.Entity<Department>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();


            base.OnModelCreating(builder);


            builder.Entity<Department>().HasData(new Department
            {
                Id = 1,
                DepartmentName = "HR"

            });

            builder.Entity<Department>().HasData(new Department
            {
                Id = 2,
                DepartmentName = "SC"

            });

            builder.Entity<Department>().HasData(new Department
            {
                Id = 3,
                DepartmentName = "MD"

            });

            builder.Entity<Employee>().HasData(new Employee
            {
                Id = 1,
                Name = "John Carter",
                DepartmentId = 1,
                Salary = 3000

            });

            builder.Entity<Employee>().HasData(new Employee
            {
                Id = 2,
                Name = "Micheal Bean",
                DepartmentId = 2,
                Salary = 1300

            });


            builder.Entity<Employee>().HasData(new Employee
            {
                Id = 3,
                Name = "Jimmy Floy",
                DepartmentId = 3,
                Salary = 2000

            });




        }
    }
}