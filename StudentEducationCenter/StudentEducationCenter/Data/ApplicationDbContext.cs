using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentEducationCenter.Data.Models;

namespace StudentEducationCenter.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<CourseRequest> CourseRequests { get; set; }
        public DbSet<AgeGroup> AgeGroups { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ChildCourse> ChildrenCourses { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Position> Positions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ChildCourse>()
                .HasKey(cc => new { cc.ChildId, cc.CourseId });

            builder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TeacherId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Teacher>()
                .HasMany(t => t.Courses)
                .WithOne(c => c.Teacher)
                .HasForeignKey(c => c.TeacherId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<ChildCourse>()
                .HasOne(cc => cc.Child)
                .WithMany(c => c.ChildCourses)
                .HasForeignKey(cc => cc.ChildId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<CourseRequest>()
                .HasOne(cr => cr.Child)
                .WithMany(c => c.CourseRequests)
                .HasForeignKey(cr => cr.ChildId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<CourseRequest>()
                .HasOne(cr => cr.Course)
                .WithMany()
                .HasForeignKey(cr => cr.CourseId)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(builder);
        }

    }
}