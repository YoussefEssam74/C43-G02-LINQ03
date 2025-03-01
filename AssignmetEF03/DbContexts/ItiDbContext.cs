using Microsoft.EntityFrameworkCore;

namespace Assignment_ef01.DbContexts
{
    public class ItiDbContext : DbContext
    {
        public ItiDbContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ItiDb02;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseInst> CourseInsts { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<StudCourse> StudCourses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Composite Primary Keys
            modelBuilder.Entity<CourseInst>()
                .HasKey(ci => new { ci.Inst_ID, ci.Course_ID });

            modelBuilder.Entity<StudCourse>()
                .HasKey(sc => new { sc.Stud_ID, sc.Course_ID });

            // One-to-Many Relationships
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.Dep_Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Topic)
                .WithMany()
                .HasForeignKey(c => c.Top_ID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Instructor)
                .WithMany()
                .HasForeignKey(d => d.Ins_ID)
                .OnDelete(DeleteBehavior.Restrict);  // Prevent circular dependency

            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany()
                .HasForeignKey(i => i.Dept_ID)
                .OnDelete(DeleteBehavior.Restrict);  // Prevent circular dependency

            // Many-to-Many Relationships
            modelBuilder.Entity<StudCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudCourses)
                .HasForeignKey(sc => sc.Stud_ID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StudCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudCourses)
                .HasForeignKey(sc => sc.Course_ID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CourseInst>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.CourseInsts)
                .HasForeignKey(ci => ci.Inst_ID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CourseInst>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.CourseInsts)
                .HasForeignKey(ci => ci.Course_ID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
