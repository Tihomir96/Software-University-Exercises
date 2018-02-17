using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext:DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Homework> HomeworkSubmissions { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.Property(e => e.Name)
                    .IsUnicode()
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("CHAR(10)")
                    .IsUnicode(false)
                    .IsRequired(false);

                entity.Property(e => e.RegisteredOn)
                    .HasColumnType("DATETIME2");

                entity.Property(e => e.Birthday)
                    .HasColumnType("DATETIME2")
                    .IsRequired(false);

                entity.HasMany(e => e.HomeworkSubmissions)
                    .WithOne(e=>e.Student)
                    .HasForeignKey(e=>e.HomeworkId);
            });
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.CourseId);
                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode()
                    .IsRequired();

                entity.Property(e => e.Description)
                    .IsUnicode()
                    .IsRequired(false);

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATETIME2");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATETIME2");
                
                entity.HasMany(e => e.Resources)
                    .WithOne(e=>e.Course)
                    .HasForeignKey(e=>e.CourseId);

                entity.HasMany(e => e.HomeworkSubmissions)
                    .WithOne(e => e.Course)
                    .HasForeignKey(e => e.CourseId);
            });
            modelBuilder.Entity<Resource>(entity =>
            {
                entity.HasKey(e => e.ResourceId);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode();

                entity.Property(e => e.Url)
                    .IsUnicode(false);

                entity.HasOne(e => e.Course)
                    .WithMany(e => e.Resources)
                    .HasForeignKey(e => e.CourseId);
            });
            modelBuilder.Entity<Homework>(entity =>
            {
                entity.HasKey(e => e.HomeworkId);

                entity.Property(e => e.Content)
                    .IsUnicode(false);

                entity.Property(e => e.SubmissionTime)
                    .HasColumnType("DATETIME2");
            });
            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(sk => new {sk.CourseId, sk.StudentId});

                entity.HasOne(e => e.Course)
                    .WithMany(e =>e.StudentsEnrolled)
                    .HasForeignKey(e => e.CourseId);

                entity.HasOne(e => e.Student)
                    .WithMany(e => e.CourseEnrollments)
                    .HasForeignKey(e => e.StudentId);
            });
        }
    }
}
